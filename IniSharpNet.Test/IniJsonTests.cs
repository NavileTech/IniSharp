using Newtonsoft.Json.Linq;
using IniSharpNet.Conversion;
using System.Collections;

namespace IniSharpBox.Test
{
    [TestClass]
    public class IniJsonTests
    {
        private static string iniInput =
@"; ------ PQube 3 from Powerside.
; ------ www.powerside.com
; ------ PQube 3 Version 3.8
rootKey=R00tVal
;----------------------------------------------------
[PQube_Information] ; End of section comment
;----------------------------------------------------
; ------ Assign a unique identifier for your PQube 3
PQube_ID=""(PQube_ID not set)"" ; End of value comment

; ------ Describe the place where your PQube 3 is installed
Location_Name=""(location not set)""

; ------ Optional additional information about your PQube 3
Note_1=""(note not set)""
Note_2=""(note not set)""
[NewSection]
; New section
NewKey=NewValue";

        private static string iniInput002 =
@"; ------ PQube 3 from Powerside.
; ------ www.powerside.com
; ------ PQube 3 Version 3.8
[FIRST_SECTION]
rootKey=R00tVal
;----------------------------------------------------
; End of section comment
[PQube_Information] 
;----------------------------------------------------
; ------ Assign a unique identifier for your PQube 3
; End of value comment
PQube_ID=""(PQube_ID not set)"" 

; ------ Describe the place where your PQube 3 is installed
Location_Name=""(location not set)""

; ------ Optional additional information about your PQube 3
Note_1=""(note not set)""
Note_2=""(note not set)""
[NewSection]
; New section
NewKey=NewValue";

        private static string jsonInput =
          @"{
              ""@c1"": ""; ------ PQube 3 from Powerside."",
              ""@c2"": ""; ------ www.powerside.com"",
              ""@c3"": ""; ------ PQube 3 Version 3.8"",
              ""rootKey"": ""R00tVal"",
              ""@c4"": "";----------------------------------------------------"",
              ""@c5eol"": ""; End of section comment"",
              ""PQube_Information"": {
                ""@c1"": "";----------------------------------------------------"",
                ""@c2"": ""; ------ Assign a unique identifier for your PQube 3"",
                ""@c3eol"": ""; End of value comment"",
                ""PQube_ID"": ""\""(PQube_ID not set)\"""",
                ""@c4"": """",
                ""@c5"": ""; ------ Describe the place where your PQube 3 is installed"",
                ""Location_Name"": ""\""(location not set)\"""",
                ""@c6"": """",
                ""@c7"": ""; ------ Optional additional information about your PQube 3"",
                ""Note_1"": ""\""(note not set)\"""",
                ""Note_2"": ""\""(note not set)\""""
              },
              ""NewSection"": {
                ""@c1"": ""; New section"",
                ""NewKey"": ""NewValue""
              }
            }";
        [TestMethod]
        public void TestReadIni()
        {

            Boolean expected = true;
            Boolean actual = false;


            IniSharp ini = new IniSharp();

            if(ini.Read(iniInput002) == true)
            {
                if (ini["PQube_Information"].Fields["PQube_ID"].DefaultValue == "\"(PQube_ID not set)\"")
                {
                    actual = true;
                }
            }

            Assert.AreEqual(expected, actual);
        }


         [TestMethod]
        public void TestIni2Json()
        {
            string json = IniJsonInterop.GetIniAsJson(iniInput, true, true);
            Console.WriteLine(json);
            Assert.IsTrue(JToken.DeepEquals(JToken.Parse(json), JToken.Parse(jsonInput)));
        }

        [TestMethod]
        public void TestJson2Ini()
        {
            string ini = IniJsonInterop.GetJsonAsIni(jsonInput, true);
            Console.WriteLine(ini);

            string[] getLines(string value)
            {
                return value.Split(new[] { "\r\n", "\n" }, StringSplitOptions.None).Select(line => line.Trim()).ToArray();
            }

            string[] sourceLines = getLines(ini);
            string[] targetLines = getLines(iniInput + "\r\n");

            Assert.IsTrue(sourceLines.CompareTo(targetLines) == 0);
        }
    }

    internal static class CompareExtensions
    {
        public static int CompareTo<TSource>(this TSource[] array1, TSource[] array2, bool orderIsImportant = true) =>
            array1.CompareTo(array2, Comparer<TSource>.Default, orderIsImportant);

        private static int CompareTo(this Array array1, Array array2, IComparer comparer, bool orderIsImportant = true)
        {
            if (comparer is null)
                throw new ArgumentNullException("comparer");

            if (array1 is null && array2 is null)
                return 0;

            if (array1 is null)
                return -1;

            if (array2 is null)
                return 1;

            if (array1.Rank != 1 || array2.Rank != 1)
                throw new ArgumentException("Cannot compare multidimensional arrays");

            if (array1.Length != array2.Length)
                return array1.Length.CompareTo(array2.Length);

            if (!orderIsImportant)
            {
                array1 = array1.Cast<object>().ToArray();
                array2 = array2.Cast<object>().ToArray();
                Array.Sort(array1, comparer);
                Array.Sort(array2, comparer);
            }

            int result = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                result = comparer.Compare(array1.GetValue(i), array2.GetValue(i));

                if (result != 0)
                    break;
            }

            return result;
        }
    }
}
