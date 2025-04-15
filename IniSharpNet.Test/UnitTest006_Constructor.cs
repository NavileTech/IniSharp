using IniSharpNet;

namespace IniSharpBox.Test
{
    [TestClass]
    public class UnitTest006
    {
        private const string FileName001 = "Test001.ini";

        private List<Boolean> TestReadMethods(IniSharp ini, String filename)
        {
            List<Boolean> Actuals = new List<Boolean>();
            for (int iReadMethod = 0; iReadMethod < 3; iReadMethod++)
            {
                switch (iReadMethod)
                {
                    case 0:
                        ini.Read();
                        Actuals.Add(ini.HasException);
                        break;

                    case 1:
                        ini.Read(Commons.GetInputText(filename));
                        Actuals.Add(ini.HasException);
                        break;

                    case 2:
                        ini.Read(Commons.GetInputLines(filename));
                        Actuals.Add(ini.HasException);
                        break;
                }
            }

            return Actuals;
        }

        /// <summary>
        /// Scopo di questo test è individuare le eccezioni nelle funzioni di read
        /// </summary>
        [TestMethod]
        public void Constructor001()
        {
            Dictionary<String, MULTIVALUESEPARATOR> files = new Dictionary<string, MULTIVALUESEPARATOR>();

            files["Test001.ini"] = MULTIVALUESEPARATOR.NEWLINE;
            files["Test002.ini"] = MULTIVALUESEPARATOR.COMMA;
            files["Test003.ini"] = MULTIVALUESEPARATOR.PIPE;

            List<Boolean> Actuals = new List<Boolean>();
            IniSharp iniShaptTest = new IniSharp();
            foreach (KeyValuePair<String, MULTIVALUESEPARATOR> item in files)
            {
                String filename = item.Key;
                MULTIVALUESEPARATOR mvsExpected = item.Value;
                for (int iMVS = 0; iMVS < Helpers.MULTIVALUESEPARATORs.Count; iMVS++)
                {
                    MULTIVALUESEPARATOR mvsActual = Helpers.MULTIVALUESEPARATORs[iMVS];

                    for (int iContructionMethod = 0; iContructionMethod < 6; iContructionMethod++)
                    {
                        switch (iContructionMethod)
                        {
                            case 0:
                                iniShaptTest = new IniSharp();
                                Actuals.AddRange(TestReadMethods(iniShaptTest, filename));
                                break;

                            case 1:
                                iniShaptTest = new IniSharp(new FileInfo(filename));
                                Actuals.AddRange(TestReadMethods(iniShaptTest, filename));
                                break;

                            case 2:
                                iniShaptTest = new IniSharp(new IniConfig());
                                Actuals.AddRange(TestReadMethods(iniShaptTest, filename));
                                break;

                            case 3:
                                iniShaptTest = new IniSharp(filename);
                                Actuals.AddRange(TestReadMethods(iniShaptTest, filename));
                                break;

                            case 4:
                                iniShaptTest = new IniSharp(new FileInfo(filename), new IniConfig());
                                Actuals.AddRange(TestReadMethods(iniShaptTest, filename));
                                break;

                            case 5:
                                iniShaptTest = new IniSharp(filename, new IniConfig());
                                Actuals.AddRange(TestReadMethods(iniShaptTest, filename));
                                break;
                        }
                    }
                }
            }
            // For all file
            // For all Multivalueseparator
            // For all constructor method
            // For all read text method

            Boolean expected = true;

            // There is at least one exception
            Boolean actual = !Actuals.Any(x => x == true);

            Assert.AreEqual(expected, actual);
        }

#if false
        [TestMethod]
        public void Load001()
        {
            IniSharp iniSharp = Commons.LoadWithFileName(FileName001,new IniConfig());
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
            IniSharp iniSharp = Commons.LoadWithFileName(FileName001 , new IniConfig());

            Boolean expected = true;
            Boolean actual = (iniSharp.Sections.Section[0].Fields[0].DefaultValue == "valore1");

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

#endif
    }
}