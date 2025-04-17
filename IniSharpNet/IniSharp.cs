using IniSharpNet;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;

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
        [JsonIgnore]
        public Boolean EnableDebug { get; set; }

        /// <summary>
        /// Return true if an error occur during file parsing ,otherwise false (negate of Success)
        /// </summary>
        [JsonIgnore]
        public Boolean Error
        { get { return (_Errors.Count > 0); } }

        /// <summary>
        /// Return true if parsing susseed , otherwise false  (negate of Error)
        /// </summary>
        [JsonIgnore]
        public Boolean Success
        { get { return (!Error || (!HasException)); } }

        /// <summary>
        /// List of verbose error
        /// </summary>
        private readonly List<String> _Errors = [];

        /// <summary>
        /// Return list of verbose error
        /// </summary>
        [JsonIgnore]
        public List<String> Errors
        { get { return _Errors; } }

        /// <summary>
        /// Return true if an exception occur during file parsing , otherwise false
        /// </summary>
        [JsonIgnore]
        public Boolean HasException
        { get { return (_Exceptions.Count > 0); } }

        /// <summary>
        /// List of verbose Exceptions
        /// </summary>
        private readonly List<String> _Exceptions = [];

        /// <summary>
        /// Return list of verbose error
        /// </summary>
        [JsonIgnore]
        public List<String> Exceptions
        { get { return _Exceptions; } }

        /// <summary>
        /// List of section of ini file
        /// </summary>
        public Sections Body { get; set; }

        /// <summary>
        /// Indexer declaration
        /// https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/indexers/using-indexers
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        [JsonIgnore]
        public Section this[int index]
        {
            get
            {
#pragma warning disable CS8603 // Possibile restituzione di riferimento Null.
                return Body.AccessorGet(index, Config.BYINDEX);
#pragma warning restore CS8603 // Possibile restituzione di riferimento Null.
            }
            set
            {
                Body.AccessorSet(value, index, Config.BYINDEX);
            }
        }

        /// <summary>
        /// Indexer declaration
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [JsonIgnore]
        public Section this[String name]
        {
            get
            {
#pragma warning disable CS8603 // Possibile restituzione di riferimento Null.
                return this.Body.AccessorGet(name, this.Config.BYNAME);
#pragma warning restore CS8603 // Possibile restituzione di riferimento Null.
            }
            set
            {
                this.Body.AccessorSet(value, name, this.Config.BYNAME);
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
        /// Parse a ini file passed as string
        /// Ex : File.ReadAllText
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public Boolean Read(String text)
        {
            this._inifile = null;

            String[] lines = text.Split(["\r\n", "\r", "\n"], StringSplitOptions.None);
            return BaseRead(lines);
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
            return BaseRead(lines);
        }

        /// <summary>
        /// Parse a ini file , filename is passed by constructor
        /// </summary>
        /// <returns></returns>
        public Boolean Read()
        {
            Boolean ReturnValue;
            try
            {
                if (this._inifile != null)
                {
                    if (String.IsNullOrEmpty(this._inifile.FullName) == false)
                    {
                        if (this._inifile.Exists == true)
                        {
                            String[] lines = File.ReadAllLines(this._inifile.FullName);
                            ReturnValue = this.BaseRead(lines);
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
        private Boolean BaseRead(String[] lines)
        {
            Boolean ReturnValue;

            try
            {
                Body = new Sections(Config);
                _fieldId = 0;

                State = PARSE_STATE.INIT;
                for (int i = 0; i < lines.Length; i++)
                {
                    String Line = lines[i];

                    if (Line.StartsWith('#') || Line.StartsWith(';'))
                    {
                        // Comment
                        continue;
                    }

                    if ((Line.Trim().StartsWith('[') == true) && (Line.Trim().EndsWith(']') == true))
                    {
                        String sectionName = Line.Replace("]", "").Replace("[", "").Trim();
                        Section section = new(Body.Count + 1, sectionName, this.Config);
                        _fieldId = 0;
                        for (int j = i+1; j < lines.Length; j++)
                        {
                            Line = lines[j];

                            if (Line.StartsWith(';') == true)
                            {
                                // Comment
                                section.Comments.Add(Line);
                                State = PARSE_STATE.COMMENT;
                                continue;
                            }

                            if (Line.StartsWith('#') == true)
                            {
                                // Comment
                                section.Comments.Add(Line);
                                State = PARSE_STATE.COMMENT;
                                continue;
                            }

                            if ((Line.Trim().StartsWith('[') == true) && (Line.Trim().EndsWith(']') == true))
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

                            if ((Line.Trim().StartsWith('\t') == true) || (Line.Trim().StartsWith(' ') == true))
                            {
                                Trace("Linea vuota : " + j);
                                section.Comments.Add(Line);
                                continue;
                            }

                            if (Line.Contains('=') == true)
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
                                            for (int iLine = 0; iLine < arr.Length; iLine++)
                                            {
                                                section.Last().Lines.Add(arr[iLine].Trim());
                                            }
                                        }
                                        break;

                                    case MULTIVALUESEPARATOR.PIPE:
                                        {
                                            String[] arr = parts[1].Trim().Split(this.Config.ArrMultiValueSeparator, StringSplitOptions.None);
                                            for (int iLine = 0; iLine < arr.Length; iLine++)
                                            {
                                                section.Last().Lines.Add(arr[iLine].Trim());
                                            }
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
                        Body.Add(section);
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
        /// Return a formatted ini file string
        /// </summary>
        /// <returns></returns>
        public string ToText()
        {
            StringBuilder ReturnValue = new();

            for (int i = 0; i < this.Comments.Count; i++)
            {
                ReturnValue.AppendLine(this.Comments[i]);
            }

            ReturnValue.Append(this.Body.ToText());

            return ReturnValue.ToString();
        }

        /// <summary>
        /// Returns a formatted sorted, by item name, ini file string
        /// </summary>
        /// <returns></returns>
        public string ToSortedText()
        {
            StringBuilder ReturnValue = new();

            ReturnValue.Append(this.Body.ToSortedText());

            return ReturnValue.ToString();
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

            StringBuilder sb = new();

            for (int i = 0; i < this.Comments.Count; i++)
            {
                sb.AppendLine(this.Comments[i]);
            }

            sb.Append(this.Body.ToText());

            string text = sb.ToString();

            Helpers.WriteToFile(fi, text, overWrite);

            return ReturnValue;
        }

        /// <summary>
        /// Write a sorted ini file on disk
        /// </summary>
        /// <param name="fi"></param>
        /// <param name="overWrite"></param>
        /// <returns></returns>
        public Boolean SortedWrite(FileInfo fi, Boolean overWrite = true)
        {
            Boolean ReturnValue = false;

            StringBuilder sb = new();

            sb.Append(this.Body.ToSortedText());

            string text = sb.ToString();

            Helpers.WriteToFile(fi, text, overWrite);

            return ReturnValue;
        }

        /// <summary>
        /// Return an array get by computation of the SHA256 hash for an array achived from sorted text of ini file
        /// https://learn.microsoft.com/en-us/dotnet/api/system.security.cryptography.hashalgorithm?view=net-9.0
        /// </summary>
        /// <returns></returns>
        public byte[] Hash()
        {
            return SHA256.HashData(Encoding.ASCII.GetBytes(ToSortedText()));
        }
    }
}