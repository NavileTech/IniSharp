using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Collections.Specialized.BitVector32;
using static System.Net.Mime.MediaTypeNames;

namespace IniSharpBox
{


    /// <summary>
    /// Class for manage ini file
    /// </summary>
    public partial class IniSharp : IniItemList
    {
        private FileInfo? _inifile = null;

        private int _fieldId = 0;
        private PARSE_STATE State = PARSE_STATE.INIT;


        /// <summary>
        /// Get/Set trace debug 
        /// </summary>
        public Boolean EnableDebug { get; set; }

        /// <summary>
        /// Return true if an error occur during file parsing ,otherwise false (negate of Success)
        /// </summary>
        public Boolean Error
        { get { return (_Errors.Count() > 0); } }

        /// <summary>
        /// Return true if parsing susseed , otherwise false  (negate of Error)
        /// </summary>
        public Boolean Success
        { get { return (!Error || (!HasException)); } }

        /// <summary>
        /// List of verbose error 
        /// </summary>
        private List<String> _Errors = new List<String>();

        /// <summary>
        /// Return list of verbose error 
        /// </summary>
        public List<String> Errors
        { get { return _Errors; } }


        /// <summary>
        /// Return true if an exception occur during file parsing , otherwise false 
        /// </summary>
        public Boolean HasException
        { get { return (_Exceptions.Count() > 0); } }

        /// <summary>
        /// List of verbose Exceptions 
        /// </summary>
        private List<String> _Exceptions = new List<String>();

        /// <summary>
        /// Return list of verbose error 
        /// </summary>
        public List<String> Exceptions
        { get { return _Exceptions; } }

        //private ERROR _ErrorType = ERROR.NOT_EXECUTE;
        //public ERROR ErrorType
        //{
        //    get { return _ErrorType; }
        //}

        /// <summary>
        /// List of section of ini file
        /// </summary>
        public Sections Sections { get; set; }

        /// <summary>
        /// Indexer declaration
        /// https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/indexers/using-indexers
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Section this[int index]
        {
            get
            {
                return this.Sections.AccessorGet(index, this.Config.BYINDEX);
            }
            set
            {
                this.Sections.AccessorSet(value, index, this.Config.BYINDEX);
            }
        }

        /// <summary>
        /// Indexer declaration
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Section this[String name]
        {
            get
            {
                return this.Sections.AccessorGet(name, this.Config.BYNAME);
            }
            set
            {
                this.Sections.AccessorSet(value, name, this.Config.BYNAME);
            }
        }

        private void Trace(String message)
        {
            if (EnableDebug == true)
            {
                Debug.WriteLine(message);
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="config"></param>
        public IniSharp(String filename, IniConfig? config)
        {
            this._Constructor(new FileInfo(filename), config);
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="filename"></param>
        public IniSharp(String filename)
        {
            this._Constructor(new FileInfo(filename), new IniConfig());
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="config"></param>
        public IniSharp(FileInfo filename, IniConfig config)
        {
            this._Constructor(filename, config);
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="filename"></param>
        public IniSharp(FileInfo filename)
        {
            this._Constructor(filename, new IniConfig());
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="config"></param>
        public IniSharp(IniConfig config)
        {
            this._Constructor(null, config);
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public IniSharp()
        {
            this._Constructor(null, new IniConfig());
        }

        /// <summary>
        /// Inner construct of class
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="config"></param>
        private void _Constructor(FileInfo? filename, IniConfig? config)
        {
            if (filename != null)
            {
                if (filename.Exists == true)
                {
                    this._inifile = filename;
                }
                else
                {
                    this._inifile = null;
                }
            }

            EnableDebug = false;

            this.Comments = new List<String>();

            
            if(config == null)
            {
                _Config = new IniConfig();
            }
            else
            {
                _Config = config;
            }

            this.Sections = new Sections(this.Config);
        }


        /// <summary>
        /// Parse a ini file passed as string 
        /// Ex : File.ReadAllText
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public Boolean Read(String text)
        {
            this._inifile = null;

            String[] lines = text.Split(new string[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            return _Read(lines);
        }

        /// <summary>
        /// Parse a ini file passed as array of string 
        /// Ex : File.ReadAllLines
        /// </summary>
        /// <param name="lines"></param>
        /// <returns></returns>
        public Boolean Read(String[] lines)
        {
            this._inifile = null;
            return _Read(lines);
        }

        /// <summary>
        /// Parse a ini file , filename is passed by constructor
        /// </summary>
        /// <returns></returns>
        public Boolean Read()
        {
            Boolean ReturnValue = false;
            try
            {
                if (this._inifile != null)
                {
                    if (String.IsNullOrEmpty(this._inifile.FullName) == false)
                    {
                        if (this._inifile.Exists == true)
                        {
                            String[] lines = File.ReadAllLines(this._inifile.FullName);
                            ReturnValue = this._Read(lines);
                        }
                        else
                        {
                            this._Errors.Add($"File : {this._inifile.FullName} do not exist");
                            ReturnValue = false;
                        }
                    }
                    else
                    {
                        this._Errors.Add($"Filename is null or empty");
                        ReturnValue = false;
                    }
                }
                else
                {
                    this._Errors.Add($"File is null");
                    ReturnValue = false;
                }
            }
            catch (Exception e)
            {
                this._Exceptions.Add(e.Message);
                ReturnValue = false;
            }

            return ReturnValue;
        }

        /// <summary>
        /// Inner method : parse a ini file passed as array of string 
        /// </summary>
        /// <param name="lines"></param>
        /// <returns></returns>
        private Boolean _Read(String[] lines)
        {
            Boolean ReturnValue = false;

            try
            {
                Sections = new Sections(Config);
                _fieldId = 0;

                State = PARSE_STATE.INIT;
                for (int i = 0; i < lines.Length; i++)
                {
                    String Line = lines[i];

                    if (Line.StartsWith("#") || Line.StartsWith(";"))
                    {
                        // Comment
                        continue;
                    }

                    if ((Line.Trim().StartsWith("[") == true) && (Line.Trim().EndsWith("]") == true))
                    {
                        String sectionName = Line.Replace("]", "").Replace("[", "").Trim();
                        Section section = new Section(Sections.Count + 1, sectionName, this.Config);
                        _fieldId = 0;
                        for (int j = i+1; j < lines.Length; j++)
                        {
                            Line = lines[j];

                            if (Line.StartsWith(";") == true)
                            {
                                // Comment
                                section.Comments.Add(Line);
                                State = PARSE_STATE.COMMENT;
                                continue;
                            }

                            if (Line.StartsWith("#") == true)
                            {
                                // Command
                                section.Comments.Add(Line);
                                State = PARSE_STATE.COMMENT;
                                continue;
                            }

                            if ((Line.Trim().StartsWith("[") == true) && (Line.Trim().EndsWith("]") == true))
                            {
                                // Next Section
                                State = PARSE_STATE.SECTION;
                                i = j - 1;
                                break;
                            }

                            if (string.IsNullOrEmpty(Line) == true)
                            {
                                continue;
                            }

                            if ((Line.Trim().StartsWith("\t") == true) || (Line.Trim().StartsWith(" ") == true))
                            {
                                Trace("Linea vuota : " + j);
                                section.Comments.Add(Line);
                                continue;
                            }

                            if (Line.Contains("=") == true)
                            {
                                State = PARSE_STATE.FIELD;
                                String[] parts = Line.Split('=');
                                section.Add(new Field(_fieldId++, parts[0].Trim(), this.Config));
                                String FieldValue = String.Empty;
                                switch (this.Config.MULTIVALUESEPARATOR)
                                {
                                    case MULTIVALUESEPARATOR.NEWLINE:
                                        FieldValue = parts[1].Trim();
                                        section.Last().Lines.Add(FieldValue);
                                        break;

                                    case MULTIVALUESEPARATOR.COMMA:
                                        {
                                            String[] arr = parts[1].Trim().Split(this.Config.ArrMultiValueSeparator, StringSplitOptions.None);
                                            section.Last().Lines.AddRange(arr);
                                        }
                                        break;

                                    case MULTIVALUESEPARATOR.PIPE:
                                        {
                                            String[] arr = parts[1].Trim().Split(this.Config.ArrMultiValueSeparator, StringSplitOptions.None);
                                            section.Last().Lines.AddRange(arr);
                                        }
                                        break;

                                    default:
                                        String message = $"Unespected multi value separator [{this.Config.MULTIVALUESEPARATOR}] at line {j+1} [{Line}]";
                                        Trace(message);
                                        _Errors.Add(message);
                                        break;
                                }

                                continue;
                            }

                            if (State == PARSE_STATE.FIELD)
                            {
                                if (this.Config.MULTIVALUESEPARATOR ==  MULTIVALUESEPARATOR.NEWLINE)
                                {
                                    section.Last().Lines.Add(Line);
                                }
                                else
                                {
                                    String message = $"Unespected string at line {j+1} [{Line}]";
                                    Trace(message);
                                    _Errors.Add(message);
                                }
                            }
                            else
                            {
                                String message = $"Unespected string at line {j+1} [{Line}]";
                                Trace(message);
                                _Errors.Add(message);
                            }
                        }
                        Sections.Add(section);
                    }
                }
                ReturnValue = true;
            }
            catch (Exception e)
            {
                this._Exceptions.Add(e.Message);
                ReturnValue = false;
            }

            return ReturnValue;
        }

        /// <summary>
        /// Write ini file on disk
        /// </summary>
        /// <param name="fi"></param>
        /// <param name="overWrite"></param>
        /// <returns></returns>
        public Boolean Write(FileInfo fi, Boolean overWrite = true)
        {
            Boolean ReturnValue = false;

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < this.Comments.Count(); i++)
            {
                sb.AppendLine(this.Comments[i]);
            }

            sb.Append(this.Sections.Write());


            if (((fi.Exists == true) && (overWrite == true)) || (fi.Exists == false))
            {
                File.WriteAllText(fi.FullName, sb.ToString());
                ReturnValue = true;
            }

            return ReturnValue;

        }
    }
}