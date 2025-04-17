using System.Collections.Generic;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

namespace IniSharpBox.Test
{
    [TestClass]
    public class UnitTest008_Merge
    {
        private const string FileName002 = "Test002.ini";
        private const string FileName002_002 = "Test002_003.ini";

        private const string FileName004_First = "Test004_Merge_First.ini";
        private const string FileName004_Second = "Test004_Merge_Second.ini";

        private const string FileName004_Merged1 = "Test004_Merge_Merged1.ini";
        private const string FileName004_Merged2 = "Test004_Merge_Merged2.ini";
        private const string FileName004_Merged3 = "Test004_Merge_Merged3.ini";
        private const string FileName004_Merged4 = "Test004_Merge_Merged4.ini";

        [TestMethod]
        public void Load001()
        {
            // Ispezione visiva
            Boolean expected = true;
            IniConfig iniConfig = new IniConfig();
            iniConfig.MULTIVALUESEPARATOR = MULTIVALUESEPARATOR.COMMA;
            IniSharp first = Commons.LoadWithFileName(FileName002, iniConfig);
            IniSharp second = Commons.LoadWithFileName(FileName002_002, iniConfig);

            IniSharp merged = IniSharp.Merge(first, second, ALLOWDUPLICATE.NOT_SECTION_NOT_FIELD_NOT_VALUE);
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

            IniSharp merged = IniSharp.Merge(first, second, ALLOWDUPLICATE.NOT_SECTION_NOT_FIELD_NOT_VALUE);
            Debug.WriteLine("############# FIRST #############");
            Debug.WriteLine(first.ToText());

            Debug.WriteLine("############# SECOND #############");
            Debug.WriteLine(second.ToText());

            IniSharp third = first.Merge(second, ALLOWDUPLICATE.NOT_SECTION_NOT_FIELD_NOT_VALUE);
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

            IniSharp merged = IniSharp.Merge(first, second, ALLOWDUPLICATE.NOT_SECTION_NOT_FIELD_NOT_VALUE);
            Debug.WriteLine("############# FIRST #############");
            Debug.WriteLine(first.ToText());

            Debug.WriteLine("############# SECOND #############");
            Debug.WriteLine(second.ToText());

            first.Import(second, ALLOWDUPLICATE.NOT_SECTION_NOT_FIELD_NOT_VALUE);
            Debug.WriteLine("############# FIRST AFTER MERGE (IMPORT) #############");
            Debug.WriteLine(first.ToText());

            Debug.WriteLine("############# MERGED #############");
            Debug.WriteLine(merged.ToText());

            bool actual = IniSharp.AreEquals(first, merged);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Load004_Multi()
        {
            Boolean expected = true;
            List<bool> actuals = [];
            IniConfig iniConfig = new IniConfig();
            iniConfig.MULTIVALUESEPARATOR = MULTIVALUESEPARATOR.COMMA;


            IniSharp firstObject = Commons.LoadWithFileName(FileName004_First, iniConfig);
            IniSharp secondObject = Commons.LoadWithFileName(FileName004_Second, iniConfig);

            FileInfo firstFi = Commons.GetInputFile(FileName004_First);
            FileInfo secondFi = Commons.GetInputFile(FileName004_Second);

            string firstText = Commons.GetInputText(FileName004_First);
            string secondText = Commons.GetInputText(FileName004_Second);


            {
                ALLOWDUPLICATE duplicateStartegy = ALLOWDUPLICATE.DO_SECTION;
                IniSharp expectedObject = Commons.LoadWithFileName(FileName004_Merged1, iniConfig);
                IniSharp merged = null;
                IniSharp firstImportObject = null;
                for (int iCase = 0; iCase < 15; iCase++)
                {
                    switch (iCase)
                    {
                        case 0:
                            merged = IniSharp.Merge(firstObject, secondObject, duplicateStartegy);
                            break;
                        case 1:
                            merged = IniSharp.Merge(firstObject, secondFi, iniConfig, duplicateStartegy);
                            break;
                        case 2:
                            merged = IniSharp.Merge(firstObject, secondText, iniConfig, duplicateStartegy);
                            break;

                        case 3:
                            merged = IniSharp.Merge(firstFi, secondObject, iniConfig, duplicateStartegy);
                            break;
                        case 4:
                            merged = IniSharp.Merge(firstFi, secondFi, iniConfig, iniConfig, duplicateStartegy);
                            break;
                        case 5:
                            merged = IniSharp.Merge(firstFi, secondText, iniConfig, iniConfig, duplicateStartegy);
                            break;

                        case 6:
                            merged = IniSharp.Merge(firstText, secondObject, iniConfig, duplicateStartegy);
                            break;
                        case 7:
                            merged = IniSharp.Merge(firstText, secondFi, iniConfig, iniConfig, duplicateStartegy);
                            break;
                        case 8:
                            merged = IniSharp.Merge(firstText, secondText, iniConfig, iniConfig, duplicateStartegy);
                            break;

                        case 9:
                            merged = firstObject.Merge(secondObject, duplicateStartegy);
                            break;
                        case 10:
                            merged = firstObject.Merge(secondFi, iniConfig, duplicateStartegy);
                            break;
                        case 11:
                            merged = firstObject.Merge(secondText, iniConfig, duplicateStartegy);
                            break;
                        case 12:
                            {
                                firstImportObject = Commons.LoadWithFileName(FileName004_First, iniConfig);
                                firstImportObject.Import(secondObject, duplicateStartegy);
                            }
                            break;
                        case 13:
                            {
                                firstImportObject = Commons.LoadWithFileName(FileName004_First, iniConfig);
                                firstImportObject.Import(secondFi, iniConfig, duplicateStartegy);
                            }
                            break;
                        case 14:
                            {
                                firstImportObject = Commons.LoadWithFileName(FileName004_First, iniConfig);
                                firstImportObject.Import(secondText, iniConfig, duplicateStartegy);
                            }

                            break;

                    }
                    bool controlValue;
                    bool actual;
                    if (iCase < 12)
                    {
                        controlValue = (IniSharp.Compare(firstObject, secondObject, merged) == 7);
                        actual = IniSharp.AreEquals(merged, expectedObject) && controlValue;
                    }
                    else
                    {
                        controlValue = (IniSharp.Compare(firstObject, secondObject, firstImportObject) == 7);
                        actual = IniSharp.AreEquals(firstImportObject, expectedObject) && controlValue;
                    }

                    actuals.Add(actual);
                }
            }

            {
                ALLOWDUPLICATE duplicateStartegy = ALLOWDUPLICATE.NOT_SECTION_DO_FIELD;
                IniSharp expectedObject = Commons.LoadWithFileName(FileName004_Merged2, iniConfig);
                IniSharp merged = null;
                IniSharp firstImportObject = null;
                for (int iCase = 0; iCase < 15; iCase++)
                {
                    switch (iCase)
                    {
                        case 0:
                            merged = IniSharp.Merge(firstObject, secondObject, duplicateStartegy);
                            break;
                        case 1:
                            merged = IniSharp.Merge(firstObject, secondFi, iniConfig, duplicateStartegy);
                            break;
                        case 2:
                            merged = IniSharp.Merge(firstObject, secondText, iniConfig, duplicateStartegy);
                            break;

                        case 3:
                            merged = IniSharp.Merge(firstFi, secondObject, iniConfig, duplicateStartegy);
                            break;
                        case 4:
                            merged = IniSharp.Merge(firstFi, secondFi, iniConfig, iniConfig, duplicateStartegy);
                            break;
                        case 5:
                            merged = IniSharp.Merge(firstFi, secondText, iniConfig, iniConfig, duplicateStartegy);
                            break;

                        case 6:
                            merged = IniSharp.Merge(firstText, secondObject, iniConfig, duplicateStartegy);
                            break;
                        case 7:
                            merged = IniSharp.Merge(firstText, secondFi, iniConfig, iniConfig, duplicateStartegy);
                            break;
                        case 8:
                            merged = IniSharp.Merge(firstText, secondText, iniConfig, iniConfig, duplicateStartegy);
                            break;

                        case 9:
                            merged = firstObject.Merge(secondObject, duplicateStartegy);
                            break;
                        case 10:
                            merged = firstObject.Merge(secondFi, iniConfig, duplicateStartegy);
                            break;
                        case 11:
                            merged = firstObject.Merge(secondText, iniConfig, duplicateStartegy);
                            break;

                        case 12:
                            {
                                firstImportObject = Commons.LoadWithFileName(FileName004_First, iniConfig);
                                firstImportObject.Import(secondObject, duplicateStartegy);
                            }
                            break;
                        case 13:
                            {
                                firstImportObject = Commons.LoadWithFileName(FileName004_First, iniConfig);
                                firstImportObject.Import(secondFi, iniConfig, duplicateStartegy);
                            }
                            break;
                        case 14:
                            {
                                firstImportObject = Commons.LoadWithFileName(FileName004_First, iniConfig);
                                firstImportObject.Import(secondText, iniConfig, duplicateStartegy);
                            }
                           
                            break;

                    }
                    bool controlValue;
                    bool actual;
                    if (iCase < 12)
                    {
                        controlValue = (IniSharp.Compare(firstObject, secondObject, merged) == 7);
                        actual = IniSharp.AreEquals(merged, expectedObject) && controlValue;
                    }
                    else
                    {
                        controlValue = (IniSharp.Compare(firstObject, secondObject, firstImportObject) == 7);
                        actual = IniSharp.AreEquals(firstImportObject, expectedObject) && controlValue;
                    }

                    actuals.Add(actual);
                }
            }

            {
                ALLOWDUPLICATE duplicateStartegy = ALLOWDUPLICATE.NOT_SECTION_NOT_FIELD_DO_VALUE;
                IniSharp expectedObject = Commons.LoadWithFileName(FileName004_Merged3, iniConfig);
                IniSharp merged = null;
                IniSharp firstImportObject = null;
                for (int iCase = 0; iCase < 15; iCase++)
                {
                    switch (iCase)
                    {
                        case 0:
                            merged = IniSharp.Merge(firstObject, secondObject, duplicateStartegy);
                            break;
                        case 1:
                            merged = IniSharp.Merge(firstObject, secondFi, iniConfig, duplicateStartegy);
                            break;
                        case 2:
                            merged = IniSharp.Merge(firstObject, secondText, iniConfig, duplicateStartegy);
                            break;

                        case 3:
                            merged = IniSharp.Merge(firstFi, secondObject, iniConfig, duplicateStartegy);
                            break;
                        case 4:
                            merged = IniSharp.Merge(firstFi, secondFi, iniConfig, iniConfig, duplicateStartegy);
                            break;
                        case 5:
                            merged = IniSharp.Merge(firstFi, secondText, iniConfig, iniConfig, duplicateStartegy);
                            break;

                        case 6:
                            merged = IniSharp.Merge(firstText, secondObject, iniConfig, duplicateStartegy);
                            break;
                        case 7:
                            merged = IniSharp.Merge(firstText, secondFi, iniConfig, iniConfig, duplicateStartegy);
                            break;
                        case 8:
                            merged = IniSharp.Merge(firstText, secondText, iniConfig, iniConfig, duplicateStartegy);
                            break;

                        case 9:
                            merged = firstObject.Merge(secondObject, duplicateStartegy);
                            break;
                        case 10:
                            merged = firstObject.Merge(secondFi, iniConfig, duplicateStartegy);
                            break;
                        case 11:
                            merged = firstObject.Merge(secondText, iniConfig, duplicateStartegy);
                            break;

                        case 12:
                            {
                                firstImportObject = Commons.LoadWithFileName(FileName004_First, iniConfig);
                                firstImportObject.Import(secondObject, duplicateStartegy);
                            }
                            break;
                        case 13:
                            {
                                firstImportObject = Commons.LoadWithFileName(FileName004_First, iniConfig);
                                firstImportObject.Import(secondFi, iniConfig, duplicateStartegy);
                            }
                            break;
                        case 14:
                            {
                                firstImportObject = Commons.LoadWithFileName(FileName004_First, iniConfig);
                                firstImportObject.Import(secondText, iniConfig, duplicateStartegy);
                            }

                            break;

                    }
                    bool controlValue;
                    bool actual;
                    if (iCase < 12)
                    {
                        controlValue = (IniSharp.Compare(firstObject, secondObject, merged) == 7);
                        actual = IniSharp.AreEquals(merged, expectedObject) && controlValue;
                    }
                    else
                    {
                        controlValue = (IniSharp.Compare(firstObject, secondObject, firstImportObject) == 7);
                        actual = IniSharp.AreEquals(firstImportObject, expectedObject) && controlValue;
                    }

                    actuals.Add(actual);
                }
            }

            {
                ALLOWDUPLICATE duplicateStartegy = ALLOWDUPLICATE.NOT_SECTION_NOT_FIELD_NOT_VALUE;
                IniSharp expectedObject = Commons.LoadWithFileName(FileName004_Merged4, iniConfig);
                IniSharp merged = null;
                IniSharp firstImportObject = null;
                for (int iCase = 0; iCase < 15; iCase++)
                {
                    switch (iCase)
                    {
                        case 0:
                            merged = IniSharp.Merge(firstObject, secondObject, duplicateStartegy);
                            break;
                        case 1:
                            merged = IniSharp.Merge(firstObject, secondFi, iniConfig, duplicateStartegy);
                            break;
                        case 2:
                            merged = IniSharp.Merge(firstObject, secondText, iniConfig, duplicateStartegy);
                            break;

                        case 3:
                            merged = IniSharp.Merge(firstFi, secondObject, iniConfig, duplicateStartegy);
                            break;
                        case 4:
                            merged = IniSharp.Merge(firstFi, secondFi, iniConfig, iniConfig, duplicateStartegy);
                            break;
                        case 5:
                            merged = IniSharp.Merge(firstFi, secondText, iniConfig, iniConfig, duplicateStartegy);
                            break;

                        case 6:
                            merged = IniSharp.Merge(firstText, secondObject, iniConfig, duplicateStartegy);
                            break;
                        case 7:
                            merged = IniSharp.Merge(firstText, secondFi, iniConfig, iniConfig, duplicateStartegy);
                            break;
                        case 8:
                            merged = IniSharp.Merge(firstText, secondText, iniConfig, iniConfig, duplicateStartegy);
                            break;

                        case 9:
                            merged = firstObject.Merge(secondObject, duplicateStartegy);
                            break;
                        case 10:
                            merged = firstObject.Merge(secondFi, iniConfig, duplicateStartegy);
                            break;
                        case 11:
                            merged = firstObject.Merge(secondText, iniConfig, duplicateStartegy);
                            break;

                        case 12:
                            {
                                firstImportObject = Commons.LoadWithFileName(FileName004_First, iniConfig);
                                firstImportObject.Import(secondObject, duplicateStartegy);
                            }
                            break;
                        case 13:
                            {
                                firstImportObject = Commons.LoadWithFileName(FileName004_First, iniConfig);
                                firstImportObject.Import(secondFi, iniConfig, duplicateStartegy);
                            }
                            break;
                        case 14:
                            {
                                firstImportObject = Commons.LoadWithFileName(FileName004_First, iniConfig);
                                firstImportObject.Import(secondText, iniConfig, duplicateStartegy);
                            }

                            break;

                    }
                    bool controlValue;
                    bool actual;
                    if (iCase < 12)
                    {
                        controlValue = (IniSharp.Compare(firstObject, secondObject, merged) == 7);
                        actual = IniSharp.AreEquals(merged, expectedObject) && controlValue;
                    }
                    else
                    {
                        controlValue = (IniSharp.Compare(firstObject, secondObject, firstImportObject) == 7);
                        actual = IniSharp.AreEquals(firstImportObject, expectedObject) && controlValue;
                    }

                    actuals.Add(actual);
                }
            }



            Assert.AreEqual(expected, !actuals.Any(x => x == false) );
        }
    }
}