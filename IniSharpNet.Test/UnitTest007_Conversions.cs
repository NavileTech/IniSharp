using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using IniSharpBox;
using System.Diagnostics;

namespace IniSharpBox.Test
{
    [TestClass]
    public class UnitTest007
    {
        private const string FileName001 = "Test001.ini";

        [TestMethod]
        public void Load001()
        {
            IniSharp iniSharp = Commons.LoadWithFileName(FileName001, new IniConfig());
            Boolean expected = true;
            string textjson = iniSharp.ToJson();
            Debug.WriteLine(textjson);
            Boolean actual = textjson.Length > 0;

            Assert.AreEqual(expected, actual);
        }

    }
}