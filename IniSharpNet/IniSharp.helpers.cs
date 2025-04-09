using IniSharpBox;
using static System.Collections.Specialized.BitVector32;

namespace IniSharpNet
{
    /// <summary>
    /// Helper class contains functions that help in assisting the library.
    /// </summary>
    public static class Helpers
    {
        /// <summary>
        /// Return a list of multi value separator enum
        /// </summary>
        public static List<MULTIVALUESEPARATOR> MULTIVALUESEPARATORs
        {
            get { return new List<MULTIVALUESEPARATOR>() { MULTIVALUESEPARATOR.NEWLINE, MULTIVALUESEPARATOR.COMMA, MULTIVALUESEPARATOR.PIPE }; }
        }

        public static string Space(int number)
        {
            return new String(' ', number);
        }

        public static string StringIfLess(int index , int breakeven , string iftrue , string iffalse)
        {
            return index < breakeven ? iftrue : iffalse;
        }
    }
}