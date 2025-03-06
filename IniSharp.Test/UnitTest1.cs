using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace IniSharpBox.Test
{
    [TestClass]
    public class UnitTest1
    {

        private const string FileName001 = "Test001.ini";
        [TestMethod]
        public void Load001()
        {
            String fullPathFile = Directory.GetCurrentDirectory() + "\\..\\..\\Files\\" + FileName001;

            IniConfig config = new IniConfig();
            IniSharp iniSharp = new IniSharp(fullPathFile, config);
            Boolean expected = true;



            Boolean actual = iniSharp.Read();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Load002()
        {
            String fullPathFile = Directory.GetCurrentDirectory() + "\\..\\..\\Files\\" + FileName001;
            IniConfig config = new IniConfig();
            IniSharp iniSharp = new IniSharp(fullPathFile, config);
            Boolean expected = true;
            Boolean actual = false;
            actual = iniSharp.Read();

            if (actual == true)
            {
                actual = (iniSharp.Sections[0].Name == "SEZIONE_1") &&
                    (iniSharp.Sections[1].Name == "SEZIONE_2") &&
                    (iniSharp.Sections[2].Name == "SEZIONE_3") &&
                    (iniSharp.Sections[3].Name == "SEZIONE_4") &&
                    (iniSharp.Sections[4].Name == "SEZIONE_5");
            }

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Load003()
        {
            String fullPathFile = Directory.GetCurrentDirectory() + "\\..\\..\\Files\\" + FileName001;
            IniConfig config = new IniConfig();
            IniSharp iniSharp = new IniSharp(fullPathFile, config);
            Boolean expected = true;
            Boolean actual = false;

            actual = iniSharp.Read();

            if (actual == true)
            {
                actual = (iniSharp.Sections[0].Fields[0].Name == "campo001") &&
                                (iniSharp.Sections[0].Fields[1].Name == "Campo2") &&
                                (iniSharp.Sections[1].Fields[0].Name == "Campo2") &&
                                (iniSharp.Sections[1].Fields[1].Name == "campo4") &&
                                (iniSharp.Sections[2].Fields.Count == 0) &&
                                (iniSharp.Sections[3].Fields.Count == 0) &&
                                (iniSharp.Sections[4].Fields[0].Name == "campo6");
            }

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Load004()
        {
            String fullPathFile = Directory.GetCurrentDirectory() + "\\..\\..\\Files\\" + FileName001;
            IniConfig config = new IniConfig();
            IniSharp iniSharp = new IniSharp(fullPathFile, config);
            Boolean expected = true;
            Boolean actual = false;

            actual = iniSharp.Read();

            if (actual == true)
            {
                actual = (iniSharp.Sections[0].Fields[0].Lines[0] == "valore1") &&
                                (iniSharp.Sections[0].Fields[1].Lines[0] == "valore002") &&
                                (iniSharp.Sections[1].Fields[0].Lines[0] == "valore002") &&
                                (iniSharp.Sections[1].Fields[0].Lines[1] == "valoreacapo") &&
                                (iniSharp.Sections[1].Fields[1].Lines[0] == "") &&
                                (iniSharp.Sections[4].Fields[0].Lines[0] == "000");
            }

            Assert.AreEqual(expected, actual);
        }
    }
}
