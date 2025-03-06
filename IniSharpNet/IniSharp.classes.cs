using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Collections.Specialized.BitVector32;
using static System.Net.Mime.MediaTypeNames;

namespace IniSharpBox
{
    /// <summary>
    /// Class devoted to store all configuration argument for parsing ini file
    /// </summary>
    public class IniConfig
    {

        /// <summary>
        /// Constructor
        /// </summary>
        public IniConfig()
        {
            MULTIVALUESEPARATOR = MULTIVALUESEPARATOR.NEWLINE;
            BYINDEX = AccessorsStrategy.STATIC;
            BYNAME = AccessorsStrategy.STATIC;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="mULTIVALUESEPARATOR"></param>
        /// <param name="indexstatus"></param>
        /// <param name="namestatus"></param>
        public IniConfig(MULTIVALUESEPARATOR mULTIVALUESEPARATOR, AccessorsStrategy indexstatus, AccessorsStrategy namestatus) : this()
        {
            MULTIVALUESEPARATOR = mULTIVALUESEPARATOR;
            BYINDEX = indexstatus; ;
            BYNAME = namestatus;
        }

        /// <summary>
        /// Protected filed for separator of field values
        /// </summary>
        protected MULTIVALUESEPARATOR _MULTIVALUESEPARATOR = MULTIVALUESEPARATOR.NEWLINE;

        /// <summary>
        /// Return separator enum of field values
        /// </summary>
        public MULTIVALUESEPARATOR MULTIVALUESEPARATOR
        {
            get { return _MULTIVALUESEPARATOR; }
            set
            {
                _ArrMultiValueSeparator = new string[] { "\r\n", "\r", "\n" };
                switch (value)
                {
                    case MULTIVALUESEPARATOR.NEWLINE:
                        _ArrMultiValueSeparator = new string[] { "\r\n", "\r", "\n" };
                        break;

                    case MULTIVALUESEPARATOR.COMMA:
                        _ArrMultiValueSeparator = new string[] { "," };
                        break;

                    case MULTIVALUESEPARATOR.PIPE:
                        _ArrMultiValueSeparator = new string[] { "|" };
                        break;

                    default:
                        _ArrMultiValueSeparator = new string[] { "\r\n", "\r", "\n" };
                        break;
                }

                _MULTIVALUESEPARATOR = value;
            }
        }

        /// <summary>
        /// Protected field for array of char of separator of field values
        /// </summary>
        protected string[] _ArrMultiValueSeparator = new string[] { "\r\n", "\r", "\n" };


        /// <summary>
        /// Return array of char of separator of field values
        /// </summary>
        public string[] ArrMultiValueSeparator
        {
            get { return _ArrMultiValueSeparator; }
        }


        private AccessorsStrategy _BYINDEX = AccessorsStrategy.STATIC;

        /// <summary>
        /// Return strategy for accessor property
        /// </summary>
        public AccessorsStrategy BYINDEX
        {
            get { return _BYINDEX; }
            set { _BYINDEX = value; }
        }

        private AccessorsStrategy _BYNAME = AccessorsStrategy.STATIC;
        /// <summary>
        /// Return strategy for accessor property
        /// </summary>
        public AccessorsStrategy BYNAME
        {
            get { return _BYNAME; }
            set { _BYNAME = value; }
        }
    }

    /// <summary>
    /// Base class for core business application IniSharp
    /// </summary>
    public abstract class IniBase
    {

        private int _ID = -1;
        /// <summary>
        /// Unique identifier for section or field
        /// </summary>
        protected int ID { get { return _ID; } set { _ID = value; } }

        /// <summary>
        /// Return next id used for initialize list item in IniSharp like Section and Field
        /// </summary>
        /// <returns></returns>
        public int NetxId()
        {
            return _ID++;
        }


        /// <summary>
        /// Protected field for configuration class 
        /// </summary>
        protected IniConfig _Config = new IniConfig();
        /// <summary>
        /// Return configuration set of arguments
        /// </summary>
        public IniConfig Config
        {
            get { return _Config;  }
            //set;
        }

    }

    /// <summary>
    /// Abstact class for single item 
    /// </summary>
    public abstract class IniItem : IniBase
    {

        /// <summary>
        /// Contains comment after declation of Section or Field
        /// </summary>
        public List<string> Comments { get; set; } = [];

        /// <summary>
        /// Name of section or field
        /// </summary>
        public string Name { get; set; } = String.Empty;

        /// <summary>
        /// Protected field for inizialization of object status
        /// </summary>
        protected bool _Initialize = false;

        /// <summary>
        /// State of inizialization of object
        /// </summary>
        public bool Initialize
        {
            get { return _Initialize; }
        }
    }

    /// <summary>
    /// Abstract class for list of items
    /// </summary>
    public abstract class IniItemList : IniItem
    {


        /// <summary>
        /// Return true if item is present in list , otherwise false
        /// </summary>
        /// <param name="container"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        /// 
        public bool Contains(List<IniItem> container, IniItem item)
        {
            return container.Contains(item);
        }

        /// <summary>
        /// Return true if an item with Name == name is present in list , otherwise false
        /// </summary>
        /// <param name="container"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool Contains(List<IniItem> container, string name)
        {
            return container.Any(x => x.Name == name);
        }

        /// <summary>
        /// Return true if an item with index is present in list , otherwise false
        /// </summary>
        /// <param name="container"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool Contains(List<IniItem> container, int index)
        {
            return container.Count > index;
        }

    }

    /// <summary>
    /// Class for manage field in a ini file
    /// </summary>
    public class Field : IniItem
    {
        /// <summary>
        /// Lines of a multiline field
        /// </summary>
        public List<string> Lines { get; set; }

        private string GetIfExist(int index)
        {
            return Lines.Count >  index ? Lines[index] : string.Empty;
        }

        /// <summary>
        /// Default value of the field , first element (return Lines[0])
        /// </summary>
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
            if (Lines.Count() > index)
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
            if (Lines.Count() > index)
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
            if(config == null)
            {
                _Config = new IniConfig();
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
            Comments = new List<string>();
            Lines = new List<string>();
            _Config = new IniConfig();
        }

        /// <summary>
        /// Return field name/value + comments
        /// </summary>
        /// <returns></returns>
        public string Write()
        {
            StringBuilder sb = new StringBuilder();

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
    }

    /// <summary>
    /// Class for manage a set of field in a section of a ini file
    /// </summary>
    public class Fields : IniItemList
    {
        /// <summary>
        /// List of fields
        /// </summary>
        public List<Field> Field { get; set; }
#if false
        internal Field GetIfExist(int index)
        {
            return Field.Count >  index ? Field[index] : new Field(NetxId(), Config);
        }

        internal Field GetIfExist(string name)
        {
            if (Contains(name) == true)
            {
                return Field[GetIndexByName(name)];
            }
            else
            {
                return new Field(NetxId(), name, Config);
            }
        }
#endif
        private int GetIndexByName(string name)
        {
            return Field.FindIndex(x => x.Name == name);
        }

        /// <summary>
        /// Return a field contained in Field list , otherwise return a new Field()
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Field GetByName(string name)
        {
            Field ReturnValue = Contains(name) ? Field.Where(x => x.Name == name).First() : new Field(NetxId(), name, Config);

            return ReturnValue;
        }

        /// <summary>
        /// Return true if item is present in list , otherwise false
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Contains(Field item)
        {
            return Field.Contains(item);
        }

        /// <summary>
        /// Return true if an item with Name == name is present in list , otherwise false
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool Contains(string name)
        {
            return Field.Any(x => x.Name == name);
        }

        /// <summary>
        /// Return true if an item with index is present in list , otherwise false
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool Contains(int index)
        {
            return Field.Count > index;
        }

        internal Field? AccessorGet(int index, AccessorsStrategy status)
        {
            Field? ReturnValue = null;
            if (Contains(index) == true)
            {
                ReturnValue = Field[index];
            }
            else
            {
                switch (status)
                {
                    case AccessorsStrategy.STATIC:
                        ReturnValue = null;
                        break;
                    case AccessorsStrategy.DINAMIC:
                        ReturnValue = null;
                        if (Field.Count == index)
                        {
                            //ReturnValue = new Field(this.NetxId(), this.Config);
                            //this.Field.Add(ReturnValue);
                        }
                        else
                        {
                            //throw new IndexOutOfRangeException();
                        }
                        break;
                }
            }
            return ReturnValue;
        }

        internal void AccessorSet(Field value, int index, AccessorsStrategy status)
        {
            if (Contains(index) == true)
            {
                Field[index] = value;
            }
            else
            {
                switch (status)
                {
                    case AccessorsStrategy.STATIC:
                        //throw new IndexOutOfRangeException();
                        break;
                    case AccessorsStrategy.DINAMIC:
                        if (Field.Count == index)
                        {
                            Field.Add(value);
                        }
                        else
                        {
                            //throw new IndexOutOfRangeException();
                        }

                        break;
                }
            }
        }

        internal Field? AccessorGet(string name, AccessorsStrategy status)
        {
            Field? ReturnValue = null;
            if (Contains(name) == true)
            {
                ReturnValue = GetByName(name);
            }
            else
            {
                switch (status)
                {
                    case AccessorsStrategy.STATIC:
                        ReturnValue = null;
                        break;
                    case AccessorsStrategy.DINAMIC:
                        ReturnValue = null;
                        //ReturnValue = new Field(this.NetxId(), name, this.Config);
                        //this.Field.Add(ReturnValue);
                        break;
                }
            }
            return ReturnValue;
        }

        internal void AccessorSet(Field value, string name, AccessorsStrategy status)
        {
            if (Contains(name) == true)
            {
                Field[GetIndexByName(name)] = value;
            }
            else
            {
                switch (status)
                {
                    case AccessorsStrategy.STATIC:
                    //throw new IndexOutOfRangeException();
                    case AccessorsStrategy.DINAMIC:
                        Field.Add(value);
                        break;
                }
            }
        }

        /// <summary>
        /// Indexer declaration 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Field this[int index]
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
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Field this[string name]
        {
            get
            {
                return AccessorGet(name, Config.BYNAME);
            }
            set
            {
                AccessorSet(value, name, Config.BYNAME);
            }
        }



        /// <summary>
        /// Return number of element of Field list
        /// </summary>
        public int Count
        { get { return Field.Count; } }

        /// <summary>
        /// Add item to Field list
        /// </summary>
        /// <param name="item"></param>
        public void Add(Field item)
        {
            Field.Add(item);
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public Fields(IniConfig config)
        {
            Field = new List<Field>();
            _Config = config;
        }

        /// <summary>
        /// Return string used to write on file
        /// </summary>
        /// <returns></returns>
        public string Write()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < Field.Count(); i++)
            {
                sb.Append(Field[i].Write());
            }

            return sb.ToString();
        }
    }

    /// <summary>
    /// Class for manage section of ini file
    /// </summary>
    public class Section : IniItem
    {
        /// <summary>
        /// Property for retrive fields
        /// </summary>
        public Fields Fields { get; set; }

        /// <summary>
        /// Indexer declaration 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Field this[int index]
        {
            get
            {
                return Fields.AccessorGet(index, Config.BYINDEX);
            }
            set
            {
                Fields.AccessorSet(value, index, Config.BYINDEX);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Field this[string name]
        {
            get
            {
                return Fields.AccessorGet(name, Config.BYNAME);
            }
            set
            {
                Fields.AccessorSet(value, name, Config.BYNAME);
            }
        }

        /// <summary>
        /// Contructor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="config"></param>
        public Section(int id, IniConfig? config) : this(config)
        {
            ID = id;
            Name = $"{ID}";
            _Initialize = true;
        }

        /// <summary>
        /// Contructor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="config"></param>
        public Section(int id, string name, IniConfig? config) : this(config)
        {
            ID = id;
            Name = name;
            _Initialize = true;
        }

        /// <summary>
        /// Contructor
        /// </summary>
        public Section(IniConfig? config) 
        {

            if (config == null)
            {
                _Config = new IniConfig();
            }
            else
            {
                _Config = config;
            }
            Comments = new List<string>();
            Fields = new Fields(Config);
            Name = string.Empty;
        }

        /// <summary>
        /// Return last field  
        /// </summary>
        /// <returns></returns>
        public Field Last()
        {
            return Fields[Fields.Count - 1];
        }

        /// <summary>
        /// Add new field
        /// </summary>
        /// <param name="item"></param>
        public void Add(Field item)
        {
            Fields.Add(item);
        }


        /// <summary>
        /// Return fields strings
        /// </summary>
        /// <returns></returns>
        public string Write()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"[{Name}]");

            for (int i = 0; i < Comments.Count(); i++)
            {
                sb.AppendLine(Comments[i]);
            }

            sb.Append(Fields.Write());

            return sb.ToString();
        }
    }

    /// <summary>
    /// Class for manage list of section of ini file
    /// </summary>
    public class Sections : IniItemList
    {
        /// <summary>
        /// List of section
        /// </summary>
        public List<Section> Section { get; set; }

        internal Section GetIfExist(int index)
        {
            return Section.Count >  index ? Section[index] : new Section(NetxId(), $"{ID}", Config);
        }

        internal Section GetIfExist(string name)
        {
            if (Contains(name) == true)
            {
                return Section[GetIndexByName(name)];
            }
            else
            {
                return new Section(Section.Count, name, Config);
            }
        }

        internal int GetIndexByName(string name)
        {
            return Section.FindIndex(x => x.Name == name);
        }

        internal Section? AccessorGet(int index, AccessorsStrategy status)
        {
            Section? ReturnValue = null;
            if (Contains(index) == true)
            {
                ReturnValue = Section[index];
            }
            else
            {
                switch (status)
                {
                    case AccessorsStrategy.STATIC:
                        ReturnValue = null;
                        break;
                    case AccessorsStrategy.DINAMIC:
                        ReturnValue = null;
                        if (Section.Count == index)
                        {
                            //ReturnValue = new Section(this.NetxId(), this.Config);
                            //this.Section.Add(ReturnValue);
                        }
                        else
                        {
                            //throw new IndexOutOfRangeException();
                        }
                        break;
                }
            }
            return ReturnValue;
        }

        internal void AccessorSet(Section value, int index, AccessorsStrategy status)
        {
            if (Contains(index) == true)
            {
                Section[index] = value;
            }
            else
            {
                switch (status)
                {
                    case AccessorsStrategy.STATIC:
                        //throw new IndexOutOfRangeException();
                        break;
                    case AccessorsStrategy.DINAMIC:
                        if (Section.Count == index)
                        {
                            Section.Add(value);
                        }
                        else
                        {
                            //throw new IndexOutOfRangeException();
                        }

                        break;
                }
            }
        }

        internal Section? AccessorGet(string name, AccessorsStrategy status)
        {
            Section? ReturnValue = null;
            if (Contains(name) == true)
            {
                ReturnValue = GetByName(name);
            }
            else
            {
                switch (status)
                {
                    case AccessorsStrategy.STATIC:
                        ReturnValue = null;
                        break;
                    case AccessorsStrategy.DINAMIC:
                        ReturnValue = null;
                        //ReturnValue = new Section(this.NetxId(),name,this.Config);
                        //this.Section.Add(ReturnValue);
                        break;
                }
            }
            return ReturnValue;
        }

        internal void AccessorSet(Section value, string name, AccessorsStrategy status)
        {
            if (Contains(name) == true)
            {
                Section[GetIndexByName(name)] = value;
            }
            else
            {
                switch (status)
                {
                    case AccessorsStrategy.STATIC:
                    //throw new IndexOutOfRangeException();
                    case AccessorsStrategy.DINAMIC:
                        Section.Add(value);
                        break;
                }
            }
        }

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
                return AccessorGet(index, Config.BYINDEX);
            }
            set
            {
                AccessorSet(value, index, Config.BYINDEX);
            }
        }

        /// <summary>
        /// Indexer declaration
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Section this[string name]
        {
            get
            {
                return AccessorGet(name, Config.BYNAME);
            }
            set
            {
                AccessorSet(value, name, Config.BYNAME);
            }
        }

        /// <summary>
        /// Return number of item
        /// </summary>
        public int Count
        { get { return Section.Count; } }

        /// <summary>
        /// Contructor
        /// </summary>
        public Sections(IniConfig config)
        {
            Section = new List<Section>();
            _Config = config;
        }

        /// <summary>
        /// Return section by name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Section GetByName(string name)
        {
            Section ReturnValue = Section.Where(x => x.Name == name).First();

            return ReturnValue;
        }

        /// <summary>
        /// Add a new section
        /// </summary>
        /// <param name="item"></param>
        public void Add(Section item)
        {
            Section.Add(item);
        }

        /// <summary>
        /// Add a new empty section with name 
        /// </summary>
        /// <param name="name"></param>
        public void Add(string name)
        {
            Section section = new Section(NetxId(), name, Config);
            Section.Add(section);
        }

        /// <summary>
        /// Cleal list of section
        /// </summary>
        public void Clear()
        {
            Section.Clear();
        }


        /// <summary>
        /// Return true if item is present in list , otherwise false
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Contains(Section item)
        {
            return Section.Contains(item);
        }

        /// <summary>
        /// Return true if an item with Name == name is present in list , otherwise false
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool Contains(string name)
        {
            return Section.Any(x => x.Name == name);
        }

        /// <summary>
        /// Return true if an item with index is present in list , otherwise false
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool Contains(int index)
        {
            return Section.Count > index;
        }


        /// <summary>
        /// Return Sections stirngs
        /// </summary>
        /// <returns></returns>
        public string Write()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < Section.Count(); i++)
            {
                sb.Append(Section[i].Write());
            }

            return sb.ToString();
        }
    }

}
