namespace IniSharpBox.Test
{
    [TestClass]
    public class UnitTest008_Equals
    {
        private const string FileName001 = "Test001.ini";
        private const string FileName002 = "Test002.ini";
        private const string FileName002_001 = "Test002_001.ini";
        private const string FileName002_002 = "Test002_002.ini";

        [TestMethod]
        public void Load001()
        {
            Boolean expected = true;
            IniSharp first = Commons.LoadWithFileName(FileName001, new IniConfig());
            IniSharp second = Commons.LoadWithFileName(FileName001, new IniConfig());

            Boolean actual = IniSharp.AreEquals(first, second);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Load002()
        {
            Boolean expected = true;
            IniSharp first = Commons.LoadWithFileName(FileName001, new IniConfig());
            IniConfig iniConfig = new IniConfig();
            iniConfig.MULTIVALUESEPARATOR = MULTIVALUESEPARATOR.COMMA;
            IniSharp second = Commons.LoadWithFileName(FileName002, iniConfig);

            Boolean actual = IniSharp.AreEquals(first, second);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Load003()
        {
            Boolean expected = false;
            IniSharp first = Commons.LoadWithFileName(FileName001, new IniConfig());

            IniSharp second = Commons.LoadWithFileName(FileName001, new IniConfig());

            second.Body[0].Name = "XXXX";

            Boolean actual = IniSharp.AreEquals(first, second);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Load004()
        {
            Boolean expected = false;
            IniSharp first = Commons.LoadWithFileName(FileName001, new IniConfig());
            IniConfig iniConfig = new IniConfig();
            iniConfig.MULTIVALUESEPARATOR = MULTIVALUESEPARATOR.COMMA;
            IniSharp second = Commons.LoadWithFileName(FileName002, iniConfig);

            second.Body[0].Name = "XXXX";

            Boolean actual = IniSharp.AreEquals(first, second);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Load005()
        {
            Boolean expected = true;
            IniConfig iniConfig = new IniConfig();
            iniConfig.MULTIVALUESEPARATOR = MULTIVALUESEPARATOR.COMMA;
            IniSharp first = Commons.LoadWithFileName(FileName002, iniConfig);

            IniSharp second = Commons.LoadWithFileName(FileName002_001, iniConfig);

            Boolean actual = IniSharp.AreEquals(first, second);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Load006()
        {
            Boolean expected = false;
            IniConfig iniConfig = new IniConfig();
            iniConfig.MULTIVALUESEPARATOR = MULTIVALUESEPARATOR.COMMA;
            IniSharp first = Commons.LoadWithFileName(FileName002, iniConfig);

            IniSharp second = Commons.LoadWithFileName(FileName002_002, iniConfig);

            Boolean actual = IniSharp.AreEquals(first, second);

            Assert.AreEqual(expected, actual);
        }
    }
}