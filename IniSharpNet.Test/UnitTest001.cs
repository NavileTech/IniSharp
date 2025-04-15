namespace IniSharpBox.Test
{
    [TestClass]
    public class UnitTest001
    {
        private const string FileName001 = "Test001.ini";

        [TestMethod]
        public void Load001()
        {
            IniSharp iniSharp = Commons.LoadWithFileName(FileName001, new IniConfig());
            Boolean expected = true;

            Boolean actual = Commons.TestActual001(iniSharp);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Load002()
        {
            IniSharp iniSharp = Commons.LoadWithFileName(FileName001, new IniConfig());
            Boolean expected = true;

            Boolean actual = Commons.TestActual002(iniSharp);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Load003()
        {
            IniSharp iniSharp = Commons.LoadWithFileName(FileName001, new IniConfig());
            Boolean expected = true;

            Boolean actual = Commons.TestActual003(iniSharp);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Load004()
        {
            IniSharp iniSharp = Commons.LoadWithFileName(FileName001, new IniConfig());

            Boolean expected = true;
            Boolean actual = Commons.TestActual004(iniSharp);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Load005()
        {
            IniSharp iniSharp = Commons.LoadWithFileName(FileName001, new IniConfig());

            Boolean expected = true;
            Boolean actual = (iniSharp.Body.Childs[0].Fields[0].DefaultValue == "valore1");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Load006()
        {
            IniSharp iniSharp = Commons.LoadWithFileName(FileName001, new IniConfig());

            Boolean expected = true;

            Boolean actual = (iniSharp[0][0][0] == "valore1");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Load007()
        {
            IniSharp iniSharp = Commons.LoadWithFileName(FileName001, new IniConfig());

            Boolean expected = true;

            Boolean actual = (iniSharp["SEZIONE_1"]["campo001"][0] == "valore1");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Load008()
        {
            IniSharp iniSharp = Commons.LoadWithFileName(FileName001, new IniConfig());

            Boolean expected = true;

            String newValue = "ThisIsANewValue";

            Boolean actual1 = (iniSharp["SEZIONE_1"]["campo001"][0] == "valore1");

            iniSharp["SEZIONE_1"]["campo001"][0] = newValue;

            Boolean actual2 = (iniSharp["SEZIONE_1"]["campo001"][0] == newValue);

            Boolean actual = actual1 && actual2;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Load101()
        {
            IniSharp iniSharp = Commons.LoadWithAllText(FileName001, new IniConfig());
            Boolean expected = true;

            Boolean actual = Commons.TestActual001(iniSharp);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Load102()
        {
            IniSharp iniSharp = Commons.LoadWithAllText(FileName001, new IniConfig());
            Boolean expected = true;

            Boolean actual = Commons.TestActual002(iniSharp);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Load103()
        {
            IniSharp iniSharp = Commons.LoadWithAllText(FileName001, new IniConfig());
            Boolean expected = true;

            Boolean actual = Commons.TestActual003(iniSharp);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Load104()
        {
            IniSharp iniSharp = Commons.LoadWithAllText(FileName001, new IniConfig());

            Boolean expected = true;
            Boolean actual = Commons.TestActual004(iniSharp);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Load201()
        {
            IniSharp iniSharp = Commons.LoadWithAllLines(FileName001, new IniConfig());
            Boolean expected = true;

            Boolean actual = Commons.TestActual001(iniSharp);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Load202()
        {
            IniSharp iniSharp = Commons.LoadWithAllLines(FileName001, new IniConfig());
            Boolean expected = true;

            Boolean actual = Commons.TestActual002(iniSharp);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Load203()
        {
            IniSharp iniSharp = Commons.LoadWithAllLines(FileName001, new IniConfig());
            Boolean expected = true;

            Boolean actual = Commons.TestActual003(iniSharp);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Load204()
        {
            IniSharp iniSharp = Commons.LoadWithAllLines(FileName001, new IniConfig());

            Boolean expected = true;
            Boolean actual = Commons.TestActual004(iniSharp);

            Assert.AreEqual(expected, actual);
        }
    }
}