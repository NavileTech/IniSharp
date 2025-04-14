using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using IniSharpBox;
using System.Diagnostics;

namespace IniSharpBox.Test
{
    [TestClass]
    public class UnitTest008_Merge
    {
        private const string FileName002 = "Test002.ini";
        private const string FileName002_002 = "Test002_003.ini";

        [TestMethod]
        public void Load001()
        {
            // Ispezione visiva
            Boolean expected = true;
            IniConfig iniConfig = new IniConfig();
            iniConfig.MULTIVALUESEPARATOR = MULTIVALUESEPARATOR.COMMA;
            IniSharp first = Commons.LoadWithFileName(FileName002, iniConfig);
            IniSharp second = Commons.LoadWithFileName(FileName002_002, iniConfig);

            IniSharp merged = IniSharp.Merge(first,second,false,false,false);
            Debug.WriteLine("############# FIRST #############");
            Debug.WriteLine(first.ToText());

            Debug.WriteLine("############# SECOND #############");
            Debug.WriteLine(second.ToText());

            Debug.WriteLine("############# MERGED #############");
            Debug.WriteLine(merged.ToText());

            bool actual = merged.ToText().Length > 0;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Load002()
        {
            Boolean expected = true;
            IniConfig iniConfig = new IniConfig();
            iniConfig.MULTIVALUESEPARATOR = MULTIVALUESEPARATOR.COMMA;
            IniSharp first = Commons.LoadWithFileName(FileName002, iniConfig);
            IniSharp second = Commons.LoadWithFileName(FileName002_002, iniConfig);

            IniSharp merged = IniSharp.Merge(first, second, false, false, false);
            Debug.WriteLine("############# FIRST #############");
            Debug.WriteLine(first.ToText());

            Debug.WriteLine("############# SECOND #############");
            Debug.WriteLine(second.ToText());

            IniSharp third =  first.Merge(second, false, false, false);
            Debug.WriteLine("############# THIRD #############");
            Debug.WriteLine(third.ToText());

            Debug.WriteLine("############# MERGED #############");
            Debug.WriteLine(merged.ToText());

            bool actual = IniSharp.AreEquals(third, merged);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Load003()
        {
            Boolean expected = true;
            IniConfig iniConfig = new IniConfig();
            iniConfig.MULTIVALUESEPARATOR = MULTIVALUESEPARATOR.COMMA;
            IniSharp first = Commons.LoadWithFileName(FileName002, iniConfig);
            IniSharp second = Commons.LoadWithFileName(FileName002_002, iniConfig);

            IniSharp merged = IniSharp.Merge(first, second, false, false, false);
            Debug.WriteLine("############# FIRST #############");
            Debug.WriteLine(first.ToText());

            Debug.WriteLine("############# SECOND #############");
            Debug.WriteLine(second.ToText());

            first.Import(second, false, false, false);
            Debug.WriteLine("############# FIRST AFTER MERGE (IMPORT) #############");
            Debug.WriteLine(first.ToText());

            Debug.WriteLine("############# MERGED #############");
            Debug.WriteLine(merged.ToText());

            bool actual = IniSharp.AreEquals(first, merged);

            Assert.AreEqual(expected, actual);
        }

    }
}