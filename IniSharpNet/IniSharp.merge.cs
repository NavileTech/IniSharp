namespace IniSharpBox
{
    public partial class IniSharp
    {
        /// <summary>
        /// Return a merged IniSharp object from 2 IniSharp object provide as argument with duplicate option for every level of ini file (section, field, values).
        /// Return object has config preference of first argument.
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <param name="duplicateSection"></param>
        /// <param name="duplicateField"></param>
        /// <param name="duplicateValue"></param>
        /// <returns></returns>
        public static IniSharp Merge(IniSharp first, IniSharp second, bool duplicateSection, bool duplicateField, bool duplicateValue)
        {
            IniSharp ReturnValue = new(first.Config)
            {
                Body = Sections.Merge(first.Body, second.Body, duplicateSection, duplicateField, duplicateValue)
            };

            return ReturnValue;
        }

        /// <summary>
        /// Return a merged IniSharp object from external IniSharp object and this object the first is provide as argument with duplicate option for every level of ini file (section, field, values)
        /// Return object has config preference of this object.
        /// </summary>
        /// <param name="other"></param>
        /// <param name="duplicateSection"></param>
        /// <param name="duplicateField"></param>
        /// <param name="duplicateValue"></param>
        /// <returns></returns>
        public IniSharp Merge(IniSharp other, bool duplicateSection, bool duplicateField, bool duplicateValue)
        {
            return IniSharp.Merge(this, other, duplicateSection, duplicateField, duplicateValue);
        }

        /// <summary>
        /// Import inside this object a merged IniSharp object from external IniSharp object and this object the first is provide as argument with duplicate option for every level of ini file (section, field, values)
        /// Imported object has config preference of this object.
        /// </summary>
        /// <param name="other"></param>
        /// <param name="duplicateSection"></param>
        /// <param name="duplicateField"></param>
        /// <param name="duplicateValue"></param>
        public void Import(IniSharp other, bool duplicateSection, bool duplicateField, bool duplicateValue)
        {
            this.Body = IniSharp.Merge(this, other, duplicateSection, duplicateField, duplicateValue).Body;
        }
    }
}