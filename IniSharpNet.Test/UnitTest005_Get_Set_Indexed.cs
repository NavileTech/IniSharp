using Microsoft.VisualStudio.TestPlatform.ObjectModel;

namespace IniSharpBox.Test
{
    [TestClass]
    public sealed class UnitTest005
    {
        private const string FileNameLocal = "Test003.ini";
        private const MULTIVALUESEPARATOR MULTIVALUESEPARATORLocal = MULTIVALUESEPARATOR.PIPE;

        [TestMethod]
        public void Load001()
        {
            Boolean expected = true;

            IniConfig config = new IniConfig();
            config.MULTIVALUESEPARATOR = MULTIVALUESEPARATORLocal;
            config.BYNAME = AccessorsStrategy.DINAMIC;
            config.BYINDEX = AccessorsStrategy.DINAMIC;

            String writeFile = "UnitTest005_Load101.ini";
            String newValue = "NuovoValore001";

            // ReadInput
            IniSharp iniSharpBegin = Commons.LoadWithFileName(FileNameLocal, config);

            //
            String valueFromFile1 = iniSharpBegin["SEZIONE_1"]["Campo2"][0];

            // Set
            iniSharpBegin["SEZIONE_1"]["Campo2"][0] = newValue;

            // WriteOutput
            iniSharpBegin.Write(Commons.GetOutputFile(writeFile));

            // ReadOutput
            IniSharp iniSharpEnd = Commons.LoadWithFileName(Commons.GetOutputFile(writeFile), config);

            // Get
            String valueFromFile2 = iniSharpBegin["SEZIONE_1"]["Campo2"][0];

            Boolean actual = String.Equals(newValue, valueFromFile2);

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

            const int E_SECTION = 0;
            const int E_FIELD = 0;
            const int E_VALUE = 0;

            //const int N_SECTION = 0;
            const int N_FIELD = 0;
            const int N_VALUE = 0;

            const int N_SECTION_1 = 5;
            const int N_FIELD_1 = 2;
            const int N_VALUE_1 = 1;

            const int N_SECTION_2 = 6;
            const int N_FIELD_2 = 2;
            const int N_VALUE_2 = 2;

            const int AS_STATIC = 0;
            const int AS_DYNAMIC = 1;

            const int AT_INDEX = 0;
            const int AT_NAME = 1;

            const int R_FALSE = 0;
            const int R_TRUE = 1;
            //                              Section         Field           Value           AccesorType AccessorStrategy        Result
            int[,] TestCase = new int[,] {  { E_SECTION  ,  E_FIELD   ,     E_VALUE   ,     AT_INDEX ,  AS_STATIC  ,            R_TRUE  },
                                            { E_SECTION  ,  E_FIELD   ,     N_VALUE_1 ,     AT_INDEX ,  AS_STATIC  ,            R_FALSE },
                                            { E_SECTION  ,  N_FIELD_1 ,     N_VALUE   ,     AT_INDEX ,  AS_STATIC  ,            R_FALSE },
                                            { N_SECTION_1,  N_FIELD   ,     N_VALUE   ,     AT_INDEX ,  AS_STATIC  ,            R_FALSE },
                                            { E_SECTION  ,  E_FIELD   ,     E_VALUE   ,     AT_INDEX ,  AS_DYNAMIC ,            R_TRUE  },
                                            { E_SECTION  ,  E_FIELD   ,     N_VALUE_1 ,     AT_INDEX ,  AS_DYNAMIC ,            R_TRUE },
                                            { E_SECTION  ,  N_FIELD_1 ,     N_VALUE   ,     AT_INDEX ,  AS_DYNAMIC ,            R_TRUE },
                                            { N_SECTION_1,  N_FIELD   ,     N_VALUE   ,     AT_INDEX ,  AS_DYNAMIC ,            R_TRUE },
                                            { E_SECTION  ,  E_FIELD   ,     N_VALUE_2 ,     AT_INDEX ,  AS_STATIC  ,            R_FALSE },
                                            { E_SECTION  ,  N_FIELD_2 ,     N_VALUE   ,     AT_INDEX ,  AS_STATIC  ,            R_FALSE },
                                            { N_SECTION_2,  N_FIELD   ,     N_VALUE   ,     AT_INDEX ,  AS_STATIC  ,            R_FALSE },
                                            { E_SECTION  ,  E_FIELD   ,     N_VALUE_2 ,     AT_INDEX ,  AS_DYNAMIC ,            R_FALSE },
                                            { E_SECTION  ,  N_FIELD_2 ,     N_VALUE   ,     AT_INDEX ,  AS_DYNAMIC ,            R_FALSE },
                                            { N_SECTION_2,  N_FIELD   ,     N_VALUE   ,     AT_INDEX ,  AS_DYNAMIC ,            R_FALSE },
                                            { E_SECTION  ,  E_FIELD   ,     E_VALUE   ,     AT_NAME  ,  AS_STATIC  ,            R_TRUE  },
                                            { E_SECTION  ,  E_FIELD   ,     N_VALUE_1 ,     AT_NAME  ,  AS_STATIC  ,            R_FALSE },
                                            { E_SECTION  ,  N_FIELD_1 ,     N_VALUE   ,     AT_NAME  ,  AS_STATIC  ,            R_FALSE },
                                            { N_SECTION_1,  N_FIELD_1 ,     N_VALUE   ,     AT_NAME  ,  AS_STATIC  ,            R_FALSE },
                                            { E_SECTION  ,  E_FIELD   ,     E_VALUE   ,     AT_NAME  ,  AS_DYNAMIC ,            R_TRUE  },
                                            { E_SECTION  ,  E_FIELD   ,     N_VALUE_1 ,     AT_NAME  ,  AS_DYNAMIC ,            R_TRUE  },
                                            { E_SECTION  ,  N_FIELD_1 ,     N_VALUE_1 ,     AT_NAME  ,  AS_DYNAMIC ,            R_TRUE  },
                                            { N_SECTION_1,  N_FIELD_1 ,     N_VALUE_1 ,     AT_NAME  ,  AS_DYNAMIC ,            R_TRUE  },
                                            { E_SECTION  ,  E_FIELD   ,     N_VALUE_2 ,     AT_NAME ,   AS_STATIC  ,            R_FALSE },
                                            { E_SECTION  ,  E_FIELD   ,     N_VALUE_2 ,     AT_NAME ,   AS_DYNAMIC ,            R_FALSE }
            };

            List<Boolean> Actuals = new List<Boolean>();
            String newValue = "NuovoValore001";
            Boolean actual = false;
            for (int iTestCase = 0; iTestCase < TestCase.GetLength(0); iTestCase++)
            {
                String writeFile = $"UnitTest005_Load002_{iTestCase + 1}.ini";

                Commons.DeleteOutputFile(writeFile);

                if (iTestCase != 18)
                {
                    //continue;
                }

                if (TestCase[iTestCase, 3] == AT_INDEX)
                {
                    config.BYNAME = AccessorsStrategy.NOT_INITIALIZE;

                    if (TestCase[iTestCase, 4] == AS_STATIC)
                    {
                        config.BYINDEX = AccessorsStrategy.STATIC;
                    }
                    else
                    {
                        continue;
                        //config.BYINDEX = AccessorsStatus.DINAMIC;
                    }

                    int SEZIONE_INDEX = TestCase[iTestCase, 0];
                    int FIELD_INDEX = TestCase[iTestCase, 1];
                    int VALUE_INDEX = TestCase[iTestCase, 2];
                    int RESULT = 0;
                    String valueFromFile1 = null;
                    String valueFromFile2 = null;
                    try
                    {
                        // ReadInput
                        IniSharp iniSharpBegin = Commons.LoadWithFileName(FileNameLocal, config);

                        //

                        if ((iniSharpBegin.Check(SEZIONE_INDEX, FIELD_INDEX, VALUE_INDEX) != 0) /*&& (config.BYINDEX == AccessorsStatus.STATIC)*/)
                        {
                            RESULT = 0;
                        }
                        else if ((iniSharpBegin.Check(SEZIONE_INDEX, FIELD_INDEX, VALUE_INDEX) == 2) && (config.BYINDEX == AccessorsStrategy.DINAMIC))
                        {
                            RESULT = 0;
                        }
                        else
                        {
                            if (iniSharpBegin.Check(SEZIONE_INDEX, FIELD_INDEX, VALUE_INDEX) != 0)
                            {
                                valueFromFile1 = null;
                            }
                            else
                            {
                                valueFromFile1 = iniSharpBegin[SEZIONE_INDEX][FIELD_INDEX][VALUE_INDEX];
                            }

                            // Set
                            iniSharpBegin[SEZIONE_INDEX][FIELD_INDEX][VALUE_INDEX] = newValue;

                            // WriteOutput

                            iniSharpBegin.Write(Commons.GetOutputFile(writeFile));

                            // ReadOutput
                            IniSharp iniSharpEnd = Commons.LoadWithFileName(Commons.GetOutputFile(writeFile), config);

                            // Get
                            valueFromFile2 = iniSharpEnd[SEZIONE_INDEX][FIELD_INDEX][VALUE_INDEX];
                            RESULT = 1;
                        }
                    }
                    catch (Exception ex)
                    {
                        RESULT = 0;
                    }

                    if (RESULT == 0)
                    {
                        Actuals.Add(RESULT == TestCase[iTestCase, 5]);
                    }
                    else
                    {
                        Actuals.Add(String.Equals(newValue, valueFromFile2) && !String.Equals(newValue, valueFromFile1) && (RESULT == TestCase[iTestCase, 5]));
                    }

                    Commons.DeleteOutputFile(writeFile);
                }
                else
                {
                    config.BYINDEX = AccessorsStrategy.NOT_INITIALIZE;

                    if (TestCase[iTestCase, 4] == AS_STATIC)
                    {
                        config.BYNAME = AccessorsStrategy.STATIC;
                    }
                    else
                    {
                        continue;
                        //config.BYNAME = AccessorsStatus.DINAMIC;
                    }

                    String SEZIONE_NAME = null;
                    String FIELD_NAME = null;
                    int VALUE_INDEX = TestCase[iTestCase, 2];
                    int RESULT = 0;
                    String valueFromFile1 = null;
                    String valueFromFile2 = null;

                    // SECTION
                    switch (TestCase[iTestCase, 0])
                    {
                        case E_SECTION:
                            SEZIONE_NAME = "SEZIONE_1";
                            break;

                        case N_SECTION_1:
                            SEZIONE_NAME = "SEZIONE_NEW";
                            break;
                    }

                    // FIELD
                    switch (TestCase[iTestCase, 1])
                    {
                        case E_FIELD:
                            FIELD_NAME = "Campo2";
                            break;

                        case N_FIELD_1:
                            FIELD_NAME = "Campo_NEW";
                            break;
                    }

                    try
                    {
                        // ReadInput
                        IniSharp iniSharpBegin = Commons.LoadWithFileName(FileNameLocal, config);
                        if ((iniSharpBegin.Check(SEZIONE_NAME, FIELD_NAME, VALUE_INDEX) != 0) /*&& (config.BYNAME == AccessorsStatus.STATIC)*/)
                        {
                            RESULT = 0;
                        }
                        else if ((iniSharpBegin.Check(SEZIONE_NAME, FIELD_NAME, VALUE_INDEX) == 2) && (config.BYNAME == AccessorsStrategy.DINAMIC))
                        {
                            RESULT = 0;
                        }
                        else
                        {
                            //

                            if (iniSharpBegin.Check(SEZIONE_NAME, FIELD_NAME, VALUE_INDEX) != 0)
                            {
                                valueFromFile1 = null;
                            }
                            else
                            {
                                valueFromFile1 = iniSharpBegin[SEZIONE_NAME][FIELD_NAME][VALUE_INDEX];
                            }

                            // Set
                            iniSharpBegin[SEZIONE_NAME][FIELD_NAME][VALUE_INDEX] = newValue;

                            // WriteOutput
                            iniSharpBegin.Write(Commons.GetOutputFile(writeFile));

                            // ReadOutput
                            IniSharp iniSharpEnd = Commons.LoadWithFileName(Commons.GetOutputFile(writeFile), config);

                            // Get
                            valueFromFile2 = iniSharpEnd[SEZIONE_NAME][FIELD_NAME][VALUE_INDEX];

                            RESULT = 1;

                            Commons.DeleteOutputFile(writeFile);
                        }
                    }
                    catch (Exception ex)
                    {
                        RESULT = 0;
                    }

                    if (RESULT == 0)
                    {
                        Actuals.Add(RESULT == TestCase[iTestCase, 5]);
                    }
                    else
                    {
                        Actuals.Add(String.Equals(newValue, valueFromFile2) && !String.Equals(newValue, valueFromFile1) && (RESULT == TestCase[iTestCase, 5]));
                    }
                }
            }

            actual = !Actuals.Any(x => x == false);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Load003()
        {
            Boolean expected = true;
            String newValue = "NuovoValore001";
            Boolean actual = false;
            IniConfig config = new IniConfig();

            String writeFile = $"UnitTest005_Load003_1.ini";

            Commons.DeleteOutputFile(writeFile);

            // ReadInput
            IniSharp iniSharpBegin = Commons.LoadWithFileName(FileNameLocal, config);

            // get old value
            String oldValue = iniSharpBegin.GetValue(0, 0, 0);

            // Set
            Boolean bSuccess = iniSharpBegin.SetValue(0, 0, 0, newValue);

            if (bSuccess == true)
            {
                // WriteOutput
                iniSharpBegin.Write(Commons.GetOutputFile(writeFile));

                // ReadOutput
                IniSharp iniSharpEnd = Commons.LoadWithFileName(Commons.GetOutputFile(writeFile), config);

                // get old value
                String newGetValue = iniSharpBegin.GetValue(0, 0, 0);

                actual = (String.Compare(newValue, newGetValue) == 0) && (!(String.Compare(oldValue, newValue) == 0));
            }
            else
            {
                actual = false;
            }

            Assert.AreEqual(expected, actual);

            Commons.DeleteOutputFile(writeFile);
        }

#if false

        [TestMethod]
        public void Load004()
        {
            IniSharp iniSharp = Commons.LoadWithFileName(FileNameLocal, MULTIVALUESEPARATORLocal);

            Boolean expected = true;
            Boolean actual = Commons.TestActual004(iniSharp);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Load101()
        {
            IniSharp iniSharp = Commons.LoadWithAllText(FileNameLocal, MULTIVALUESEPARATORLocal);
            Boolean expected = true;

            Boolean actual = Commons.TestActual001(iniSharp);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Load102()
        {
            IniSharp iniSharp = Commons.LoadWithAllText(FileNameLocal, MULTIVALUESEPARATORLocal);
            Boolean expected = true;

            Boolean actual = Commons.TestActual002(iniSharp);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Load103()
        {
            IniSharp iniSharp = Commons.LoadWithAllText(FileNameLocal, MULTIVALUESEPARATORLocal);
            Boolean expected = true;

            Boolean actual = Commons.TestActual003(iniSharp);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Load104()
        {
            IniSharp iniSharp = Commons.LoadWithAllText(FileNameLocal, MULTIVALUESEPARATORLocal);

            Boolean expected = true;
            Boolean actual = Commons.TestActual004(iniSharp);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Load201()
        {
            IniSharp iniSharp = Commons.LoadWithAllLines(FileNameLocal, MULTIVALUESEPARATORLocal);
            Boolean expected = true;

            Boolean actual = Commons.TestActual001(iniSharp);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Load202()
        {
            IniSharp iniSharp = Commons.LoadWithAllLines(FileNameLocal, MULTIVALUESEPARATORLocal);
            Boolean expected = true;

            Boolean actual = Commons.TestActual002(iniSharp);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Load203()
        {
            IniSharp iniSharp = Commons.LoadWithAllLines(FileNameLocal, MULTIVALUESEPARATORLocal);

            Boolean expected = true;

            Boolean actual = Commons.TestActual003(iniSharp);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Load204()
        {
            IniSharp iniSharp = Commons.LoadWithAllLines(FileNameLocal, MULTIVALUESEPARATORLocal);

            Boolean expected = true;
            Boolean actual = Commons.TestActual004(iniSharp);

            Assert.AreEqual(expected, actual);
        }
#endif
    }
}