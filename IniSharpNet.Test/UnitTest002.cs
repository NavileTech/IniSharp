namespace IniSharpBox.Test
{
    [TestClass]
    public sealed class UnitTest002
    {
        private const string FileNameLocal = "Test002.ini";
        private const MULTIVALUESEPARATOR MULTIVALUESEPARATORLocal = MULTIVALUESEPARATOR.COMMA;

        [TestMethod]
        public void Load001()
        {
            Boolean expected = true;

            IniConfig config = new IniConfig();
            config.MULTIVALUESEPARATOR = MULTIVALUESEPARATORLocal;
            config.BYNAME = AccessorsStrategy.DINAMIC;
            config.BYINDEX = AccessorsStrategy.DINAMIC;

            IniSharp iniSharp = Commons.LoadWithFileName(FileNameLocal, config);

            Boolean actual = Commons.TestActual001(iniSharp);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Load002()
        {
            IniConfig config = new IniConfig();
            config.MULTIVALUESEPARATOR = MULTIVALUESEPARATORLocal;
            config.BYNAME = AccessorsStrategy.DINAMIC;
            config.BYINDEX = AccessorsStrategy.DINAMIC;

            IniSharp iniSharp = Commons.LoadWithFileName(FileNameLocal, config);
            Boolean expected = true;

            Boolean actual = Commons.TestActual002(iniSharp);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Load003()
        {
            IniConfig config = new IniConfig();
            config.MULTIVALUESEPARATOR = MULTIVALUESEPARATORLocal;
            config.BYNAME = AccessorsStrategy.DINAMIC;
            config.BYINDEX = AccessorsStrategy.DINAMIC;

            IniSharp iniSharp = Commons.LoadWithFileName(FileNameLocal, config);
            Boolean expected = true;

            Boolean actual = Commons.TestActual003(iniSharp);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Load004()
        {
            IniConfig config = new IniConfig();
            config.MULTIVALUESEPARATOR = MULTIVALUESEPARATORLocal;
            config.BYNAME = AccessorsStrategy.DINAMIC;
            config.BYINDEX = AccessorsStrategy.DINAMIC;

            IniSharp iniSharp = Commons.LoadWithFileName(FileNameLocal, config);

            Boolean expected = true;
            Boolean actual = Commons.TestActual004(iniSharp);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Load101()
        {
            IniConfig config = new IniConfig();
            config.MULTIVALUESEPARATOR = MULTIVALUESEPARATORLocal;
            config.BYNAME = AccessorsStrategy.DINAMIC;
            config.BYINDEX = AccessorsStrategy.DINAMIC;

            IniSharp iniSharp = Commons.LoadWithAllText(FileNameLocal, config);
            Boolean expected = true;

            Boolean actual = Commons.TestActual001(iniSharp);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Load102()
        {
            IniConfig config = new IniConfig();
            config.MULTIVALUESEPARATOR = MULTIVALUESEPARATORLocal;
            config.BYNAME = AccessorsStrategy.DINAMIC;
            config.BYINDEX = AccessorsStrategy.DINAMIC;

            IniSharp iniSharp = Commons.LoadWithAllText(FileNameLocal, config);
            Boolean expected = true;

            Boolean actual = Commons.TestActual002(iniSharp);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Load103()
        {
            IniConfig config = new IniConfig();
            config.MULTIVALUESEPARATOR = MULTIVALUESEPARATORLocal;
            config.BYNAME = AccessorsStrategy.DINAMIC;
            config.BYINDEX = AccessorsStrategy.DINAMIC;

            IniSharp iniSharp = Commons.LoadWithAllText(FileNameLocal, config);
            Boolean expected = true;

            Boolean actual = Commons.TestActual003(iniSharp);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Load104()
        {
            IniConfig config = new IniConfig();
            config.MULTIVALUESEPARATOR = MULTIVALUESEPARATORLocal;
            //config.BYNAME = AccessorsStatus.DINAMIC;
            config.BYINDEX = AccessorsStrategy.DINAMIC;

            IniSharp iniSharp = Commons.LoadWithAllText(FileNameLocal, config);

            Boolean expected = true;
            Boolean actual = Commons.TestActual004(iniSharp);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Load201()
        {
            IniConfig config = new IniConfig();
            config.MULTIVALUESEPARATOR = MULTIVALUESEPARATORLocal;
            config.BYNAME = AccessorsStrategy.DINAMIC;
            config.BYINDEX = AccessorsStrategy.DINAMIC;

            IniSharp iniSharp = Commons.LoadWithAllLines(FileNameLocal, config);
            Boolean expected = true;

            Boolean actual = Commons.TestActual001(iniSharp);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Load202()
        {
            IniConfig config = new IniConfig();
            config.MULTIVALUESEPARATOR = MULTIVALUESEPARATORLocal;
            config.BYNAME = AccessorsStrategy.DINAMIC;
            config.BYINDEX = AccessorsStrategy.DINAMIC;

            IniSharp iniSharp = Commons.LoadWithAllLines(FileNameLocal, config);
            Boolean expected = true;

            Boolean actual = Commons.TestActual002(iniSharp);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Load203()
        {
            IniConfig config = new IniConfig();
            config.MULTIVALUESEPARATOR = MULTIVALUESEPARATORLocal;
            config.BYNAME = AccessorsStrategy.DINAMIC;
            config.BYINDEX = AccessorsStrategy.DINAMIC;

            IniSharp iniSharp = Commons.LoadWithAllLines(FileNameLocal, config);
            Boolean expected = true;

            Boolean actual = Commons.TestActual003(iniSharp);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Load204()
        {
            IniConfig config = new IniConfig();
            config.MULTIVALUESEPARATOR = MULTIVALUESEPARATORLocal;
            //config.BYNAME = AccessorsStatus.DINAMIC;
            config.BYINDEX = AccessorsStrategy.DINAMIC;

            IniSharp iniSharp = Commons.LoadWithAllLines(FileNameLocal, config);

            Boolean expected = true;
            Boolean actual = Commons.TestActual004(iniSharp);

            Assert.AreEqual(expected, actual);
        }
    }
}