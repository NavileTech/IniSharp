namespace IniSharpBox
{
    public partial class IniSharp
    {
        /// <summary>
        /// Return true if are equals according to ToSortedText(), otherwise false.
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public static bool AreEquals(IniSharp first, IniSharp second)
        {
            bool ReturnValue;
            MULTIVALUESEPARATOR oldValue = second.Config.MULTIVALUESEPARATOR;

            second.Config.MULTIVALUESEPARATOR = first.Config.MULTIVALUESEPARATOR;

            ReturnValue = (first.ToSortedText() == second.ToSortedText());

            second.Config.MULTIVALUESEPARATOR = oldValue;

            return ReturnValue;
        }

        /// <summary>
        ///Return true if external object is equal
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(IniSharp other)
        {
            return IniSharp.AreEquals(this, other);
        }
    }
}