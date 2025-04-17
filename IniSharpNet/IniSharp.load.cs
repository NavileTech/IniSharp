namespace IniSharpBox
{
    public partial class IniSharp
    {
        /// <summary>
        /// Return an IniSharp object
        /// </summary>
        /// <param name="fi"></param>
        /// <param name="config"></param>
        /// <returns></returns>
        public static IniSharp Load(FileInfo fi, IniConfig config)
        {
            IniSharp ini = new(fi, config);
            ini.Read();
            return ini;
        }

        /// <summary>
        /// Return an IniSharp object passing a text of ini file as argument
        /// </summary>
        /// <param name="text"></param>
        /// <param name="config"></param>
        /// <returns></returns>
        public static IniSharp Load(string text, IniConfig config)
        {
            IniSharp ini = new(config);
            ini.Read(text);
            return ini;
        }
    }
}