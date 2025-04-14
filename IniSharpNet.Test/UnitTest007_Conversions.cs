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
        public void ToJson_001()
        {
            IniSharp iniSharp = Commons.LoadWithFileName(FileName001, new IniConfig());
            Boolean expected = true;
            string textjson = iniSharp.ToJson();
            Debug.WriteLine(textjson);
            Boolean actual = textjson.Length > 0;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FromJson_001()
        {
            IniSharp iniSharp = Commons.LoadWithFileName(FileName001, new IniConfig());
            Boolean expected = true;
            string textjson = iniSharp.ToJson();
            Debug.WriteLine(textjson);

            IniSharp deserialize = new IniSharp();
            deserialize.FromJson(textjson);

            Boolean actual = IniSharp.AreEquals( iniSharp,deserialize);

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void ToJsonSerialize_001()
        {
            IniSharp iniSharp = Commons.LoadWithFileName(FileName001, new IniConfig());
            Boolean expected = true;
            string textjson = iniSharp.ToJsonSerialize();
            Debug.WriteLine(textjson);
            Boolean actual = textjson.Length > 0;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToJsonSerializeDeserialize_001()
        {
            IniSharp iniSharp = Commons.LoadWithFileName(FileName001, new IniConfig());
            Boolean expected = true;
            string textjson = iniSharp.ToJsonSerialize();
            Debug.WriteLine(textjson);
            IniSharp deserialize = new IniSharp();
            deserialize.FromJsonDeserialize(textjson);
            Boolean actual = IniSharp.AreEquals(iniSharp, deserialize);
            Debug.WriteLine("##########################################");
            Debug.WriteLine(iniSharp.ToText());
            Debug.WriteLine("##########################################");
            Debug.WriteLine(deserialize.ToText());

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void ToXml_001()
        {
            IniSharp iniSharp = Commons.LoadWithFileName(FileName001, new IniConfig());
            Boolean expected = true;
            string textxml = iniSharp.ToXml();
            Debug.WriteLine(textxml);

            IniSharp deserialize = new IniSharp();
            deserialize.FromXml(textxml);
            Boolean actual = IniSharp.AreEquals(iniSharp, deserialize);

            Assert.AreEqual(expected, actual);
        }
    }
}