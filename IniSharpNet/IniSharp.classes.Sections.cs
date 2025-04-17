using System.Text;
using System.Xml.Serialization;

#pragma warning disable IDE0130 // La parola chiave namespace non corrisponde alla struttura di cartelle

namespace IniSharpBox
#pragma warning restore IDE0130 // La parola chiave namespace non corrisponde alla struttura di cartelle
{
    /// <summary>
    /// Class for manage list of section of ini file
    /// </summary>
    public class Sections : IniItemList
    {
        /// <summary>
        /// List of section
        /// </summary>
        public List<Section> Childs { get; set; }

        /// <summary>
        /// Return list of Name of section
        /// </summary>
        [XmlIgnore]
        public List<string> GetNames
        {
#pragma warning disable IDE0305 // Semplifica l'inizializzazione della raccolta
            get { return Childs.Select(x => x.Name).ToList(); }
#pragma warning restore IDE0305 // Semplifica l'inizializzazione della raccolta
        }

        internal int GetIndexByName(string name)
        {
            return Childs.FindIndex(x => x.Name == name);
        }

        internal Section? AccessorGet(int index, AccessorsStrategy status)
        {
            Section? ReturnValue = null;
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
        /// https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/indexers/using-indexers
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Section this[int index]
        {
            get
            {
#pragma warning disable CS8603 // Possibile restituzione di riferimento Null.
                return AccessorGet(index, Config.BYINDEX);
#pragma warning restore CS8603 // Possibile restituzione di riferimento Null.
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
#pragma warning disable CS8603 // Possibile restituzione di riferimento Null.
                return AccessorGet(name, Config.BYNAME);
#pragma warning restore CS8603 // Possibile restituzione di riferimento Null.
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
        { get { return Childs.Count; } }

        /// <summary>
        /// Contructor
        /// </summary>
        public Sections(IniConfig config)
        {
            Childs = [];
            _Config = config;
        }

        /// <summary>
        /// Contructor
        /// </summary>
        public Sections()
        {
            Childs = [];
            _Config = new IniConfig();
        }

        /// <summary>
        /// Return section by name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Section GetByName(string name)
        {
            Section ReturnValue = Childs.Where(x => x.Name == name).First();

            return ReturnValue;
        }

        /// <summary>
        /// Add a new section
        /// </summary>
        /// <param name="item"></param>
        public void Add(Section item)
        {
            Childs.Add(item);
        }

        /// <summary>
        /// Add a new empty section with name
        /// </summary>
        /// <param name="name"></param>
        public void Add(string name)
        {
            Section section = new(NetxId(), name, Config);
            Childs.Add(section);
        }

        /// <summary>
        /// Cleal list of section
        /// </summary>
        public void Clear()
        {
            Childs.Clear();
        }

        /// <summary>
        /// Return true if item is present in list , otherwise false
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Contains(Section item)
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

        /// <summary>
        /// Return Sections stirngs
        /// </summary>
        /// <returns></returns>
        public string ToText()
        {
            StringBuilder sb = new();

            for (int i = 0; i < Childs.Count; i++)
            {
                sb.Append(Childs[i].ToText());
            }

            return sb.ToString();
        }

        /// <summary>
        /// Return Sections stirngs
        /// </summary>
        /// <returns></returns>
        public string ToSortedText()
        {
            StringBuilder sb = new();

#pragma warning disable IDE0305 // Semplifica l'inizializzazione della raccolta
            List<Section> sections = Childs.OrderBy(o => o.Name).ToList();
#pragma warning restore IDE0305 // Semplifica l'inizializzazione della raccolta

            for (int i = 0; i < sections.Count; i++)
            {
                sb.Append(sections[i].ToSortedText());
            }

            return sb.ToString();
        }

        /// <summary>
        /// Return a merged Sections from 2 input Sections according to duplicate startegy
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <param name="duplicate"></param>
        /// <returns></returns>
        public static Sections Merge(Sections first, Sections second, ALLOWDUPLICATE duplicate)
        {
            Sections ReturnValue = new(first.Config);

            for (int i = 0; i < first.Count; i++)
            {
                if (duplicate < ALLOWDUPLICATE.DO_SECTION)
                {
                    bool contains = second.Contains(first[i].Name);
                    if (contains == true)
                    {
                        ReturnValue.Childs.Add(Section.Merge(first[i], second.GetByName(first[i].Name), duplicate));
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
                if (duplicate < ALLOWDUPLICATE.DO_SECTION)
                {
                    bool contains = first.Contains(second[i].Name);
                    if (contains == true)
                    {
                        //ReturnValue.Childs.Add(Section.Merge(second[i], first.GetByName(second[i].Name)));
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