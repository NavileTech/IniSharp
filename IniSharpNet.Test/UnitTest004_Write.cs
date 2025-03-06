using System.Xml.Linq;


namespace IniSharpBox.Test
{
    [TestClass]
    public sealed class UnitTest004
    {

        private const string FileNameLocal = "Test003.ini";
        private const MULTIVALUESEPARATOR MULTIVALUESEPARATORLocal = MULTIVALUESEPARATOR.PIPE;
        [TestMethod]
        public void Load001()
        {
            Boolean expected = true;

            IniConfig config = new IniConfig();
            config.MULTIVALUESEPARATOR = MULTIVALUESEPARATORLocal;

            IniSharp iniSharpBegin = Commons.LoadWithFileName(FileNameLocal, config);

            String newValue = "NuovoValore001";

            iniSharpBegin["SEZIONE_1"]["Campo2"].DefaultValue =  newValue;
            String writeFile = "UnitTest004_Load001.ini";
            iniSharpBegin.Write(Commons.GetOutputFile(writeFile));

            IniSharp iniSharpEnd = Commons.LoadWithFileName(Commons.GetOutputFile(writeFile), config);

            Boolean actual = (iniSharpEnd["SEZIONE_1"]["Campo2"].DefaultValue ==  newValue);

            Assert.AreEqual(expected, actual);

            Commons.DeleteOutputFile(writeFile);
        }

        [TestMethod]
        public void Load002()
        {
            Boolean expected = true;

            IniConfig config = new IniConfig();
            config.MULTIVALUESEPARATOR = MULTIVALUESEPARATORLocal;
            config.BYNAME = AccessorsStrategy.DINAMIC;
            config.BYINDEX = AccessorsStrategy.DINAMIC;

            IniSharp iniSharpBegin = Commons.LoadWithFileName(FileNameLocal, config);

            String newValue = "NuovoValore001";

            iniSharpBegin["SEZIONE_1"]["Campo2"][0] =  newValue + "_A";
            iniSharpBegin["SEZIONE_1"]["Campo2"][1] =  newValue + "_B";
            iniSharpBegin["SEZIONE_1"]["Campo2"][2] =  newValue + "_C";
            iniSharpBegin["SEZIONE_1"]["Campo2"][3] =  newValue + "_D";
            String writeFile = "UnitTest004_Load002.ini";
            iniSharpBegin.Write(Commons.GetOutputFile(writeFile));

            IniSharp iniSharpEnd = Commons.LoadWithFileName(Commons.GetOutputFile(writeFile), config);

            Boolean actual = ( (iniSharpEnd["SEZIONE_1"]["Campo2"][0] ==  newValue + "_A") &&
                               (iniSharpEnd["SEZIONE_1"]["Campo2"][1] ==  newValue + "_B") &&
                               (iniSharpEnd["SEZIONE_1"]["Campo2"][2] ==  newValue + "_C") &&
                               (iniSharpEnd["SEZIONE_1"]["Campo2"][3] ==  newValue + "_D") ) ;

            Assert.AreEqual(expected, actual);

            Commons.DeleteOutputFile(writeFile);
        }
#if false
        [TestMethod]
        public void Load003()
        {
            Boolean expected = true;

            IniConfig config = new IniConfig();
            config.MULTIVALUESEPARATOR = MULTIVALUESEPARATORLocal;
            config.BYNAME = AccessorsStatus.DINAMIC;
            config.BYINDEX = AccessorsStatus.DINAMIC;

            IniSharp iniSharpBegin = Commons.LoadWithFileName(FileNameLocal, config);

            String newValue = "NuovoValore001";

            iniSharpBegin["SEZIONE_1"]["CampoNonEsistente"][0] =  newValue + "_A";
            iniSharpBegin["SEZIONE_1"]["CampoNonEsistente"][1] =  newValue + "_B";
            iniSharpBegin["SEZIONE_1"]["CampoNonEsistente"][2] =  newValue + "_C";
            iniSharpBegin["SEZIONE_1"]["CampoNonEsistente"][3] =  newValue + "_D";
            String writeFile = "UnitTest004_Load003.ini";
            iniSharpBegin.Write(Commons.GetOutputFile(writeFile));

            IniSharp iniSharpEnd = Commons.LoadWithFileName(Commons.GetOutputFile(writeFile), config);

            Boolean actual = ((iniSharpEnd["SEZIONE_1"]["CampoNonEsistente"][0] ==  newValue + "_A") &&
                               (iniSharpEnd["SEZIONE_1"]["CampoNonEsistente"][1] ==  newValue + "_B") &&
                               (iniSharpEnd["SEZIONE_1"]["CampoNonEsistente"][2] ==  newValue + "_C") &&
                               (iniSharpEnd["SEZIONE_1"]["CampoNonEsistente"][3] ==  newValue + "_D"));

            Assert.AreEqual(expected, actual);

            Commons.DeleteOutputFile(writeFile);
        }


        [TestMethod]
        public void Load004()
        {
            /*
             *  Section Field   Value
             *  E       E       E
            */
            Boolean expected = true;

            IniConfig config = new IniConfig();
            config.MULTIVALUESEPARATOR = MULTIVALUESEPARATORLocal;
            config.BYNAME = AccessorsStatus.DINAMIC;
            config.BYINDEX = AccessorsStatus.DINAMIC;

            IniSharp iniSharpBegin = Commons.LoadWithFileName(FileNameLocal, config);

            String newValue = "NuovoValore001";

            iniSharpBegin["SEZIONE_NonEsistente"]["CampoNonEsistente"][0] =  newValue + "_A";
            iniSharpBegin["SEZIONE_NonEsistente"]["CampoNonEsistente"][1] =  newValue + "_B";
            iniSharpBegin["SEZIONE_NonEsistente"]["CampoNonEsistente"][2] =  newValue + "_C";
            iniSharpBegin["SEZIONE_NonEsistente"]["CampoNonEsistente"][3] =  newValue + "_D";
            String writeFile = "UnitTest004_Load004.ini";
            iniSharpBegin.Write(Commons.GetOutputFile(writeFile));

            IniSharp iniSharpEnd = Commons.LoadWithFileName(Commons.GetOutputFile(writeFile), config);

            Boolean actual = ((iniSharpEnd["SEZIONE_NonEsistente"]["CampoNonEsistente"][0] ==  newValue + "_A") &&
                               (iniSharpEnd["SEZIONE_NonEsistente"]["CampoNonEsistente"][1] ==  newValue + "_B") &&
                               (iniSharpEnd["SEZIONE_NonEsistente"]["CampoNonEsistente"][2] ==  newValue + "_C") &&
                               (iniSharpEnd["SEZIONE_NonEsistente"]["CampoNonEsistente"][3] ==  newValue + "_D"));

            Assert.AreEqual(expected, actual);

            Commons.DeleteOutputFile(writeFile);
        }
#endif

        [TestMethod]
        public void Load101()
        {
            Boolean expected = true;
            IniConfig config = new IniConfig();
            config.MULTIVALUESEPARATOR = MULTIVALUESEPARATORLocal;
            config.BYNAME = AccessorsStrategy.DINAMIC;
            config.BYINDEX = AccessorsStrategy.DINAMIC;

            IniSharp iniSharpBegin = Commons.LoadWithFileName(FileNameLocal, config);

            String newValue = "NuovoValore001";

            String oldValue1 = iniSharpBegin["SEZIONE_1"]["Campo2"][0];
            iniSharpBegin["SEZIONE_1"]["Campo2"][1] =  newValue + "_B";
            String writeFile = "UnitTest004_Load101.ini";
            iniSharpBegin.Write(Commons.GetOutputFile(writeFile));

            IniSharp iniSharpEnd = Commons.LoadWithFileName(Commons.GetOutputFile(writeFile), config);

            Boolean actual = ( (iniSharpEnd["SEZIONE_1"]["Campo2"][0] ==  oldValue1) &&
                               (iniSharpEnd["SEZIONE_1"]["Campo2"][1] ==  newValue + "_B"));

            Assert.AreEqual(expected, actual);

            Commons.DeleteOutputFile(writeFile);
        }

#if false
        [TestMethod]
        public void Load102()
        {
            IniSharp iniSharp = Commons.LoadWithAllText(FileNameLocal, MULTIVALUESEPARATORLocal);
            iniSharp.MultiValueSeparator = MULTIVALUESEPARATORLocal;
            Boolean expected = true;

            Boolean actual = Commons.TestActual002(iniSharp);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Load103()
        {
            IniSharp iniSharp = Commons.LoadWithAllText(FileNameLocal, MULTIVALUESEPARATORLocal);
            iniSharp.MultiValueSeparator = MULTIVALUESEPARATORLocal;
            Boolean expected = true;

            Boolean actual = Commons.TestActual003(iniSharp);

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Load104()
        {
            IniSharp iniSharp = Commons.LoadWithAllText(FileNameLocal, MULTIVALUESEPARATORLocal);
            iniSharp.MultiValueSeparator = MULTIVALUESEPARATORLocal;

            Boolean expected = true;
            Boolean actual = Commons.TestActual004(iniSharp);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Load201()
        {
            IniSharp iniSharp = Commons.LoadWithAllLines(FileNameLocal, MULTIVALUESEPARATORLocal);
            iniSharp.MultiValueSeparator = MULTIVALUESEPARATORLocal;
            Boolean expected = true;

            Boolean actual = Commons.TestActual001(iniSharp);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Load202()
        {
            IniSharp iniSharp = Commons.LoadWithAllLines(FileNameLocal, MULTIVALUESEPARATORLocal);
            iniSharp.MultiValueSeparator = MULTIVALUESEPARATORLocal;
            Boolean expected = true;

            Boolean actual = Commons.TestActual002(iniSharp);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Load203()
        {
            IniSharp iniSharp = Commons.LoadWithAllLines(FileNameLocal, MULTIVALUESEPARATORLocal);
            iniSharp.MultiValueSeparator = MULTIVALUESEPARATORLocal;
            Boolean expected = true;

            Boolean actual = Commons.TestActual003(iniSharp);

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Load204()
        {
            IniSharp iniSharp = Commons.LoadWithAllLines(FileNameLocal, MULTIVALUESEPARATORLocal);
            iniSharp.MultiValueSeparator = MULTIVALUESEPARATORLocal;

            Boolean expected = true;
            Boolean actual = Commons.TestActual004(iniSharp);

            Assert.AreEqual(expected, actual);
        }

#endif
    }
}
