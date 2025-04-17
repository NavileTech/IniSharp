using Newtonsoft.Json;

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
        [JsonIgnore]
        public MULTIVALUESEPARATOR MULTIVALUESEPARATOR
        {
            get { return _MULTIVALUESEPARATOR; }
            set
            {
                _ArrMultiValueSeparator = ["\r\n", "\r", "\n"];
                switch (value)
                {
                    case MULTIVALUESEPARATOR.NEWLINE:
                        _ArrMultiValueSeparator = ["\r\n", "\r", "\n"];
                        break;

                    case MULTIVALUESEPARATOR.COMMA:
                        _ArrMultiValueSeparator = [","];
                        break;

                    case MULTIVALUESEPARATOR.PIPE:
                        _ArrMultiValueSeparator = ["|"];
                        break;

                    default:
                        _ArrMultiValueSeparator = ["\r\n", "\r", "\n"];
                        break;
                }

                _MULTIVALUESEPARATOR = value;
            }
        }

        /// <summary>
        /// Protected field for array of char of separator of field values
        /// </summary>
        protected string[] _ArrMultiValueSeparator = ["\r\n", "\r", "\n"];

        /// <summary>
        /// Return array of char of separator of field values
        /// </summary>
        [JsonIgnore]
        public string[] ArrMultiValueSeparator
        {
            get { return _ArrMultiValueSeparator; }
        }

        private AccessorsStrategy _BYINDEX = AccessorsStrategy.STATIC;

        /// <summary>
        /// Return strategy for accessor property
        /// </summary>
        [JsonIgnore]
        public AccessorsStrategy BYINDEX
        {
            get { return _BYINDEX; }
            set { _BYINDEX = value; }
        }

        private AccessorsStrategy _BYNAME = AccessorsStrategy.STATIC;

        /// <summary>
        /// Return strategy for accessor property
        /// </summary>
        [JsonIgnore]
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
        protected int ID
        { get { return _ID; } set { _ID = value; } }

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
        protected IniConfig _Config = new();

        /// <summary>
        /// Return configuration set of arguments
        /// </summary>
        [JsonIgnore]
        public IniConfig Config
        {
            get { return _Config; }
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
        [JsonIgnore]
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
        [JsonIgnore]
        public bool Initialize
        {
            get { return _Initialize; }
        }
    }

    /// <summary>
    /// Interface define methods for remove items
    /// </summary>
    public interface IIniItemRemove
    {
        /// <summary>
        /// Return true if an item with name == Name exists and removing process succeed, otherwise false
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public abstract bool Remove(string name);

        /// <summary>
        /// Return true if an item with index pass as argument exists and removing process succeed, otherwise false
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public abstract bool Remove(int index);
    }

    /// <summary>
    /// Abstract class for list of items
    /// </summary>
    public abstract class IniItemList : IniItem
    {
#if false
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
#endif
    }
}