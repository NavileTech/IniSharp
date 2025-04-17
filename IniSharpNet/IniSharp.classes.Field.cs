using Newtonsoft.Json;
using System.Text;
using System.Xml.Serialization;

namespace IniSharpBox
{
    /// <summary>
    /// Class for manage field in a ini file
    /// </summary>
    public class Field : IniItem, IIniItemRemove
    {
        /// <summary>
        /// Lines of a multiline field
        /// </summary>
        public List<string> Lines { get; set; }

        private string GetIfExist(int index)
        {
            return Lines.Count > index ? Lines[index] : string.Empty;
        }

        private int GetIndexByValue(string value)
        {
            return Lines.FindIndex(x => x == value);
        }

        /// <summary>
        /// Default value of the field , first element (return Lines[0])
        /// </summary>
        [JsonIgnore]
        [XmlIgnore]
        public string DefaultValue
        {
            get
            {
                return GetIfExist(0);
            }
            set
            {
                Lines.Clear();
                Replace(value);
            }
        }

        /// <summary>
        /// Clear and write string in field
        /// </summary>
        /// <param name="line"></param>
        public void Replace(string line)
        {
            Replace(new string[] { line });
        }

        /// <summary>
        /// Clear and write a list of string in field
        /// </summary>
        /// <param name="lines"></param>
        public void Replace(List<string> lines)
        {
            Replace(lines.ToArray());
        }

        /// <summary>
        /// Clear and write an array of string in field
        /// </summary>
        /// <param name="lines"></param>
        public void Replace(string[] lines)
        {
            Lines.Clear();
            Add(lines);
        }

        /// <summary>
        /// Write a list of string in field
        /// </summary>
        /// <param name="lines"></param>
        public void Add(List<string> lines)
        {
            Add(lines.ToArray());
        }

        /// <summary>
        /// Write an array of string in field
        /// </summary>
        /// <param name="lines"></param>
        public void Add(string[] lines)
        {
            foreach (string line in lines) { Add(line); }
        }

        /// <summary>
        /// Write string in field
        /// </summary>
        /// <param name="line"></param>
        public void Add(string line)
        {
            Lines.Add(line);
        }

        /// <summary>
        /// Get of indexer property
        /// </summary>
        /// <param name="index"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        internal string AccessorGet(int index, AccessorsStrategy status)
        {
            string ReturnValue = String.Empty;
            if (Lines.Count > index)
            {
                ReturnValue = Lines[index];
            }
            else
            {
                switch (status)
                {
                    case AccessorsStrategy.STATIC:
                        ReturnValue = String.Empty;
                        break;

                    case AccessorsStrategy.DINAMIC:
                        ReturnValue = String.Empty;
                        break;
                }
            }
            return ReturnValue;
        }

        /// <summary>
        /// Set accessor of indexer property
        /// </summary>
        /// <param name="value"></param>
        /// <param name="index"></param>
        /// <param name="status"></param>
        internal void AccessorSet(string value, int index, AccessorsStrategy status)
        {
            if (Lines.Count > index)
            {
                Lines[index] = value;
            }
            else
            {
                switch (status)
                {
                    case AccessorsStrategy.STATIC:
                        //throw new IndexOutOfRangeException();
                        break;

                    case AccessorsStrategy.DINAMIC:
                        if (Lines.Count == index)
                        {
                            Lines.Add(value);
                        }
                        else
                        {
                            //throw new IndexOutOfRangeException();
                        }

                        break;
                }
            }
        }

        /// <summary>
        /// Indexer declaration
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        [JsonIgnore]
        public string this[int index]
        {
            get
            {
                return AccessorGet(index, Config.BYINDEX);
            }
            set
            {
                AccessorSet(value, index, Config.BYINDEX);
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="config"></param>
        public Field(int id, IniConfig? config) : this(config)
        {
            _Initialize = true;
            ID = id;
            Name = $"{ID}";
        }

#if false
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="mULTIVALUESEPARATOR"></param>
        public Field(String name, MULTIVALUESEPARATOR mULTIVALUESEPARATOR = MULTIVALUESEPARATOR.NEWLINE) : this(mULTIVALUESEPARATOR)
        {
            _Initialize = true;
            Name = name;
        }
#endif

        /// <summary>
        ///
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="config"></param>
        public Field(int id, string name, IniConfig? config) : this(config)
        {
            _Initialize = true;
            ID = id;
            Name = name;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public Field(IniConfig? config) : this()
        {
            if (config == null)
            {
                _Config = new();
            }
            else
            {
                _Config = config;
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public Field()
        {
            Comments = [];
            Lines = [];
            _Config = new();
        }

        /// <summary>
        /// Return field name/value + comments
        /// </summary>
        /// <returns></returns>
        public string ToText()
        {
            StringBuilder sb = new();

            for (int i = 0; i < Comments.Count; i++)
            {
                sb.AppendLine(Comments[i]);
            }

            if (Lines.Count > 1)
            {
                sb.Append($"{Name}={Lines[0]}");
                switch (Config.MULTIVALUESEPARATOR)
                {
                    case MULTIVALUESEPARATOR.NEWLINE:

                        for (int i = 1; i < Lines.Count; i++)
                        {
                            sb.AppendLine($"{Lines[i]}");
                        }
                        break;

                    case MULTIVALUESEPARATOR.COMMA:
                        for (int i = 1; i < Lines.Count; i++)
                        {
                            sb.Append($",{Lines[i]}");
                        }
                        sb.AppendLine();
                        break;

                    case MULTIVALUESEPARATOR.PIPE:
                        for (int i = 1; i < Lines.Count; i++)
                        {
                            sb.Append($"|{Lines[i]}");
                        }
                        sb.AppendLine();
                        break;

                    default:
                        for (int i = 1; i < Lines.Count; i++)
                        {
                            sb.AppendLine($"{Lines[i]}");
                        }
                        break;
                }
            }
            else
            {
                sb.AppendLine($"{Name}={Lines[0]}");
            }

            return sb.ToString();
        }

        /// <summary>
        /// Return sorted field name/value
        /// </summary>
        /// <returns></returns>
        public string ToSortedText()
        {
            StringBuilder sb = new();

            List<String> sorted = [.. Lines];

            sorted.Sort();

            if (sorted.Count > 1)
            {
                sb.Append($"{Name}={Lines[0]}");
                switch (Config.MULTIVALUESEPARATOR)
                {
                    case MULTIVALUESEPARATOR.NEWLINE:

                        for (int i = 1; i < sorted.Count; i++)
                        {
                            sb.AppendLine($"{sorted[i]}");
                        }
                        break;

                    case MULTIVALUESEPARATOR.COMMA:
                        for (int i = 1; i < sorted.Count; i++)
                        {
                            sb.Append($",{sorted[i]}");
                        }
                        sb.AppendLine();
                        break;

                    case MULTIVALUESEPARATOR.PIPE:
                        for (int i = 1; i < sorted.Count; i++)
                        {
                            sb.Append($"|{sorted[i]}");
                        }
                        sb.AppendLine();
                        break;

                    default:
                        for (int i = 1; i < sorted.Count; i++)
                        {
                            sb.AppendLine($"{sorted[i]}");
                        }
                        break;
                }
            }
            else
            {
                sb.AppendLine($"{Name}=");
            }

            return sb.ToString();
        }

        /// <summary>
        /// Return a Field as merged from 2 Field.
        /// If duplicateValue is true allow multiple instance of value, otherwise do not allow duplicate instance.
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <param name="duplicate"></param>
        /// <returns></returns>
        public static Field Merge(Field first, Field second, ALLOWDUPLICATE duplicate)
        {
            Field ReturnValue = new(first.Config);

            if (duplicate > ALLOWDUPLICATE.NOT_SECTION_NOT_FIELD_DO_VALUE)
            {
                throw new NotSupportedException();
            }

            ReturnValue.Name = first.Name;
            for (int i = 0; i < first.Lines.Count; i++)
            {
                if (ReturnValue.Lines.Contains(first.Lines[i]) == false)
                {
                    ReturnValue.Add(first.Lines[i]);
                }
                else
                {
                    if (duplicate == ALLOWDUPLICATE.NOT_SECTION_NOT_FIELD_DO_VALUE)
                    {
                        ReturnValue.Add(first.Lines[i]);
                    }
                }
            }

            for (int j = 0; j < second.Lines.Count; j++)
            {
                if (ReturnValue.Lines.Contains(second.Lines[j]) == false)
                {
                    ReturnValue.Add(second.Lines[j]);
                }
                else
                {
                    if (duplicate == ALLOWDUPLICATE.NOT_SECTION_NOT_FIELD_DO_VALUE)
                    {
                        ReturnValue.Add(second.Lines[j]);
                    }
                }
            }

            return ReturnValue;
        }

        /// <summary>
        /// Return true if an item with value exists and removing process succeed, otherwise false
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool Remove(string value)
        {
            bool ReturnValue = false;
            int index = GetIndexByValue(value);
            if (index >= 0)
            {
                ReturnValue = Remove(index);
            }

            return ReturnValue;
        }

        /// <summary>
        /// Return true if an item with index pass as argument exists and removing process succeed, otherwise false
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool Remove(int index)
        {
            bool ReturnValue = false;

            if (index >= 0)
            {
                Lines.RemoveAt(index);
                ReturnValue = true;
            }

            return ReturnValue;
        }
    }
}