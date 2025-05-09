﻿using Microsoft.ApplicationInsights.Metrics;

namespace IniSharpBox.Test
{
    [TestClass]
    public class UnitTest011_Load
    {
        private const string FileName001 = "Test001.ini";
        private const string FileName002 = "Test002.ini";
        private const string FileName002_001 = "Test002_001.ini";
        private const string FileName002_002 = "Test002_002.ini";

        [TestMethod]
        public void Load001()
        {
            Boolean expected = true;
            IniSharp first = IniSharp.Load(Commons.GetInputFile(FileName001), new IniConfig());
            IniSharp second = IniSharp.Load(Commons.GetInputFile(FileName001), new IniConfig());

            Boolean actual = IniSharp.AreEquals(first, second) && first.Success && second.Success;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Load002()
        {
            Boolean expected = true;
            IniSharp first = IniSharp.Load(Commons.GetInputFile(FileName001), new IniConfig());
            IniConfig iniConfig = new IniConfig();
            iniConfig.MULTIVALUESEPARATOR = MULTIVALUESEPARATOR.COMMA;
            IniSharp second = IniSharp.Load(Commons.GetInputFile(FileName002), iniConfig);

            Boolean actual = IniSharp.AreEquals(first, second) && first.Success && second.Success;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Load003()
        {
            Boolean expected = false;
            IniSharp first = IniSharp.Load(Commons.GetInputFile(FileName001), new IniConfig());

            IniSharp second = IniSharp.Load(Commons.GetInputFile(FileName001), new IniConfig());

            second.Body[0].Name = "XXXX";

            Boolean actual = IniSharp.AreEquals(first, second) && first.Success && second.Success;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Load004()
        {
            Boolean expected = false;
            IniSharp first = IniSharp.Load(Commons.GetInputFile(FileName001), new IniConfig());
            IniConfig iniConfig = new IniConfig();
            iniConfig.MULTIVALUESEPARATOR = MULTIVALUESEPARATOR.COMMA;
            IniSharp second = IniSharp.Load(Commons.GetInputFile(FileName002), iniConfig);

            second.Body[0].Name = "XXXX";

            Boolean actual = IniSharp.AreEquals(first, second) && first.Success && second.Success;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Load005()
        {
            Boolean expected = true;
            IniConfig iniConfig = new IniConfig();
            iniConfig.MULTIVALUESEPARATOR = MULTIVALUESEPARATOR.COMMA;
            IniSharp first = IniSharp.Load(Commons.GetInputFile(FileName002), iniConfig);

            IniSharp second = IniSharp.Load(Commons.GetInputFile(FileName002_001), iniConfig);

            Boolean actual = IniSharp.AreEquals(first, second) && first.Success && second.Success;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Load006()
        {
            Boolean expected = false;
            IniConfig iniConfig = new IniConfig();
            iniConfig.MULTIVALUESEPARATOR = MULTIVALUESEPARATOR.COMMA;
            IniSharp first = IniSharp.Load(Commons.GetInputFile(FileName002), iniConfig);

            IniSharp second = IniSharp.Load(Commons.GetInputFile(FileName002_002), iniConfig);

            Boolean actual = IniSharp.AreEquals(first, second) && first.Success && second.Success;

            Assert.AreEqual(expected, actual);
        }
    }
}