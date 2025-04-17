using System.Diagnostics;

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
        /// Return true if are equals according to ToSortedText() + both has Success == true + both has ToSortedText().Length > 0 , otherwise false.
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public static bool ValidateEquals(IniSharp first, IniSharp second)
        {
            bool ReturnValue;
            MULTIVALUESEPARATOR oldValue = second.Config.MULTIVALUESEPARATOR;

            second.Config.MULTIVALUESEPARATOR = first.Config.MULTIVALUESEPARATOR;

            string firstText = first.ToSortedText();
            string secondText = second.ToSortedText();
            second.Config.MULTIVALUESEPARATOR = oldValue;

            List<bool> bools = [];
            bool areEquals = firstText == secondText;
            bools.Add(areEquals);

#if true
            if(areEquals == false)
            {
                Debug.WriteLine("################# first ##################");
                Debug.WriteLine(firstText);
                Debug.WriteLine("################# second ##################");
                Debug.WriteLine(secondText);
            }
#endif


            bools.Add(firstText.Length > 0);
            bools.Add(secondText.Length > 0);
            bools.Add(first.Success == true);
            bools.Add(second.Success == true);

            ReturnValue = !bools.Any(x => x == false);

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