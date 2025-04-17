namespace IniSharpBox
{
    /// <summary>
    /// Class for manage ini file
    /// </summary>
    public partial class IniSharp : IniItemList
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public IniSharp()
        {
            Body = new Sections();
            this.Constructor(null, new IniConfig());
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="config"></param>
        public IniSharp(String filename, IniConfig config) : this()
        {
            this.Constructor(new FileInfo(filename), config);
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="filename"></param>
        public IniSharp(String filename) : this()
        {
            this.Constructor(new FileInfo(filename), new IniConfig());
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="config"></param>
        public IniSharp(FileInfo filename, IniConfig config) : this()
        {
            this.Constructor(filename, config);
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="filename"></param>
        public IniSharp(FileInfo filename) : this()
        {
            this.Constructor(filename, new IniConfig());
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="config"></param>
        public IniSharp(IniConfig config) : this()
        {
            this.Constructor(null, config);
        }

        /// <summary>
        /// Inner construct of class
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="config"></param>
        private void Constructor(FileInfo? filename, IniConfig? config)
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

            this.Comments = [];

            if (config == null)
            {
                _Config = new IniConfig();
            }
            else
            {
                _Config = config;
            }

            this.Body = new Sections(this.Config);
        }
    }
}