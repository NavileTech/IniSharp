using IniSharpBox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}