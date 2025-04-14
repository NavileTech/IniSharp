namespace IniSharpBox
{
    public partial class IniSharp
    {
        public static IniSharp Merge(IniSharp first, IniSharp second, bool duplicateSection, bool duplicateField, bool duplicateValue)
        {
            IniSharp ReturnValue = new IniSharp(first.Config);

            ReturnValue.Body = Sections.Merge(first.Body, second.Body, duplicateSection, duplicateField, duplicateValue);
            return ReturnValue;
        }

        public IniSharp Merge(IniSharp other, bool duplicateSection, bool duplicateField, bool duplicateValue)
        {
            return IniSharp.Merge(this, other, duplicateSection, duplicateField, duplicateValue);
        }

        public void Import(IniSharp other, bool duplicateSection, bool duplicateField, bool duplicateValue)
        {
            this.Body = IniSharp.Merge(this, other, duplicateSection, duplicateField, duplicateValue).Body;
        }
    }
}