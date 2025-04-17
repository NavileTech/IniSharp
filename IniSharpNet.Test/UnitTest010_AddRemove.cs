namespace IniSharpBox.Test
{
    [TestClass]
    public class UnitTest010_AddRemove
    {
        private const string FileName001 = "Test001.ini";
        private const string FileName002 = "Test002.ini";
        private const string FileName002_001 = "Test002_001.ini";
        private const string FileName002_002 = "Test002_002.ini";

        private const string FileName002_004 = "Test002_004.ini";
        private const string FileName002_005 = "Test002_005.ini";
        private const string FileName002_006 = "Test002_006.ini";
        private const string FileName002_007 = "Test002_007.ini";
        private const string FileName002_008 = "Test002_008.ini";
        private const string FileName002_009 = "Test002_009.ini";


        [TestMethod]
        public void Load004()
        {
            Boolean expected = true;
            List<bool> actuals = [];
            IniConfig iniConfig = new IniConfig();
            iniConfig.MULTIVALUESEPARATOR = MULTIVALUESEPARATOR.COMMA;
            IniSharp item = IniSharp.Load(Commons.GetInputFile(FileName002), iniConfig);

            string value1 = "pippo001";
            string value2 = "pippo002";
            Field field001 = new (0,"ADD_Field_001", iniConfig);
            field001.Add(value1);
            field001.Add(value2);


            Section section = new Section(0,"ADD_Section_001", iniConfig);
            section.Add(field001);

            item.Body.Add(section);

            Field field002 = new(0, "ADD_Field_001", iniConfig);
            field002.Add(value1);
            field002.Add(value2);

            item.Body["SEZIONE_3"].Add(field002);

            IniSharp expectedObject = IniSharp.Load(Commons.GetInputFile(FileName002_004), iniConfig);
            actuals.Add( IniSharp.ValidateEquals(item, expectedObject));

            item.Body["SEZIONE_3"]["ADD_Field_001"].Remove(value2);
            expectedObject = IniSharp.Load(Commons.GetInputFile(FileName002_005), iniConfig);
            actuals.Add(IniSharp.ValidateEquals(item, expectedObject));

            item.Body["SEZIONE_3"]["ADD_Field_001"].Remove(value1);
            expectedObject = IniSharp.Load(Commons.GetInputFile(FileName002_006), iniConfig);
            actuals.Add(IniSharp.ValidateEquals(item, expectedObject));

            item.Body["SEZIONE_3"].Fields.Remove("ADD_Field_001");
            expectedObject = IniSharp.Load(Commons.GetInputFile(FileName002_007), iniConfig);
            actuals.Add(IniSharp.ValidateEquals(item, expectedObject));

            item.Body.Remove("SEZIONE_3");
            expectedObject = IniSharp.Load(Commons.GetInputFile(FileName002_008), iniConfig);
            actuals.Add(IniSharp.ValidateEquals(item, expectedObject));


            item.Body["ADD_Section_001"]["ADD_Field_001"].Remove(value2);
            item.Body["ADD_Section_001"]["ADD_Field_001"].Remove(value1);
            item.Body["ADD_Section_001"].Fields.Remove("ADD_Field_001");
            item.Body.Remove("ADD_Section_001");
            expectedObject = IniSharp.Load(Commons.GetInputFile(FileName002_009), iniConfig);
            actuals.Add(IniSharp.ValidateEquals(item, expectedObject));

            Assert.AreEqual(expected, !actuals.Any(x => x == false));
        }
    }
}