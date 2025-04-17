using Newtonsoft.Json;
using System.Text;

namespace IniSharpBox
{
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
        [JsonIgnore]
        public Field this[int index]
        {
            get
            {
#pragma warning disable CS8603 // Possibile restituzione di riferimento Null.
                return Fields.AccessorGet(index, Config.BYINDEX);
#pragma warning restore CS8603 // Possibile restituzione di riferimento Null.
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
        [JsonIgnore]
        public Field this[string name]
        {
            get
            {
#pragma warning disable CS8603 // Possibile restituzione di riferimento Null.
                return Fields.AccessorGet(name, Config.BYNAME);
#pragma warning restore CS8603 // Possibile restituzione di riferimento Null.
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
            Comments = [];
            Fields = new(Config);
            Name = string.Empty;
        }

        /// <summary>
        /// Contructor
        /// </summary>
        public Section()
        {
            _Config = new();
            Comments = [];
            Fields = new(Config);
            Name = string.Empty;
        }

        /// <summary>
        /// Return last field
        /// </summary>
        /// <returns></returns>
        public Field Last()
        {
            //https://learn.microsoft.com/it-it/dotnet/csharp/tutorials/ranges-indexes
            return Fields[^1];// Operatore di indice
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
        public string ToText()
        {
            StringBuilder sb = new();

            sb.AppendLine($"[{Name}]");

            for (int i = 0; i < Comments.Count; i++)
            {
                sb.AppendLine(Comments[i]);
            }

            sb.Append(Fields.ToText());

            return sb.ToString();
        }

        /// <summary>
        /// Return sorted fields strings , comment are ignored
        /// </summary>
        /// <returns></returns>
        public string ToSortedText()
        {
            StringBuilder sb = new();

            sb.AppendLine($"[{Name}]");

            sb.Append(Fields.ToSortedText());

            return sb.ToString();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <param name="duplicate"></param>
        /// <returns></returns>
        public static Section Merge(Section first, Section second, ALLOWDUPLICATE duplicate)
        {
            Section ReturnValue = new(first.Config)
            {
                Name = first.Name,
                Fields = Fields.Merge(first.Fields, second.Fields, duplicate)
            };
            return ReturnValue;
        }
    }
}