using System.Text;
using System.Xml.Serialization;

namespace IniSharpBox
{
    /// <summary>
    /// Class for manage a set of field in a section of a ini file
    /// </summary>
    public class Fields : IniItemList
    {
        /// <summary>
        /// List of fields
        /// </summary>
        public List<Field> Childs { get; set; }

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

        /// <summary>
        /// Returns a list of names of Field
        /// </summary>
        [XmlIgnore]
        public List<string> GetNames
        {
            get { return Childs.Select(x => x.Name).ToList(); }
        }

        private int GetIndexByName(string name)
        {
            return Childs.FindIndex(x => x.Name == name);
        }

        /// <summary>
        /// Return a field contained in Field list , otherwise return a new Field()
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Field GetByName(string name)
        {
            Field ReturnValue = Contains(name) ? Childs.Where(x => x.Name == name).First() : new Field(NetxId(), name, Config);

            return ReturnValue;
        }

        /// <summary>
        /// Return true if item is present in list , otherwise false
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Contains(Field item)
        {
            return Childs.Contains(item);
        }

        /// <summary>
        /// Return true if an item with Name == name is present in list , otherwise false
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool Contains(string name)
        {
            return Childs.Any(x => x.Name == name);
        }

        /// <summary>
        /// Return true if an item with index is present in list , otherwise false
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool Contains(int index)
        {
            return Childs.Count > index;
        }

        internal Field? AccessorGet(int index, AccessorsStrategy status)
        {
            Field? ReturnValue = null;
            if (Contains(index) == true)
            {
                ReturnValue = Childs[index];
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
                        if (Childs.Count == index)
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
                Childs[index] = value;
            }
            else
            {
                switch (status)
                {
                    case AccessorsStrategy.STATIC:
                        //throw new IndexOutOfRangeException();
                        break;

                    case AccessorsStrategy.DINAMIC:
                        if (Childs.Count == index)
                        {
                            Childs.Add(value);
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
                Childs[GetIndexByName(name)] = value;
            }
            else
            {
                switch (status)
                {
                    case AccessorsStrategy.STATIC:
                    //throw new IndexOutOfRangeException();
                    case AccessorsStrategy.DINAMIC:
                        Childs.Add(value);
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
        { get { return Childs.Count; } }

        /// <summary>
        /// Add item to Field list
        /// </summary>
        /// <param name="item"></param>
        public void Add(Field item)
        {
            Childs.Add(item);
        }

        /// <summary>
        /// Constructor (parameterless)
        /// </summary>
        public Fields()
        {
            Childs = new List<Field>();
            _Config = new IniConfig();
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public Fields(IniConfig config)
        {
            Childs = new List<Field>();
            _Config = config;
        }

        /// <summary>
        /// Return string used to write on file
        /// </summary>
        /// <returns></returns>
        public string ToText()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < Childs.Count; i++)
            {
                sb.Append(Childs[i].ToText());
            }

            return sb.ToString();
        }

        /// <summary>
        /// Return a sorted version ToText() without comments
        /// </summary>
        /// <returns></returns>
        public string ToSortedText()
        {
            StringBuilder sb = new StringBuilder();
            List<Field> fields = Childs.OrderBy(o => o.Name).ToList();

            for (int i = 0; i < fields.Count; i++)
            {
                sb.AppendLine(fields[i].ToSortedText());
            }

            return sb.ToString();
        }

        /// <summary>
        /// Return a merged Field from 2 input Field according to duplicate strategy
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <param name="duplicate"></param>
        /// <returns></returns>
        public static Fields Merge(Fields first, Fields second, ALLOWDUPLICATE duplicate)
        {
            Fields ReturnValue = new Fields(first.Config);

            if (duplicate > ALLOWDUPLICATE.NOT_SECTION_DO_FIELD)
            {
                throw new NotSupportedException();
            }

            for (int i = 0; i < first.Count; i++)
            {
                if (duplicate < ALLOWDUPLICATE.NOT_SECTION_DO_FIELD)
                {
                    bool contains = second.Contains(first[i].Name);
                    if (contains == true)
                    {
                        ReturnValue.Childs.Add(Field.Merge(first[i], second.GetByName(first[i].Name), duplicate));
                    }
                    else
                    {
                        ReturnValue.Childs.Add(first[i]);
                    }
                }
                else
                {
                    ReturnValue.Childs.Add(first[i]);
                }
            }

            for (int i = 0; i < second.Count; i++)
            {
                if (duplicate < ALLOWDUPLICATE.NOT_SECTION_DO_FIELD)
                {
                    bool contains = first.Contains(second[i].Name);
                    if (contains == true)
                    {
                        //
                    }
                    else
                    {
                        ReturnValue.Childs.Add(second[i]);
                    }
                }
                else
                {
                    ReturnValue.Childs.Add(second[i]);
                }
            }
            return ReturnValue;
        }

        /// <summary>
        /// Return true if an item with name == Name exists and removing process succeed, otherwise false
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool Remove(string name)
        {
            bool ReturnValue = false;
            int index = GetIndexByName(name);
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
                Childs.RemoveAt(index);
                ReturnValue = true;
            }

            return ReturnValue;
        }
    }
}