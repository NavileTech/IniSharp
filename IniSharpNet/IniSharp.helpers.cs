using IniSharpBox;
using System.Text;

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
            get { return [MULTIVALUESEPARATOR.NEWLINE, MULTIVALUESEPARATOR.COMMA, MULTIVALUESEPARATOR.PIPE]; }
        }

        /// <summary>
        /// Return a string with number space as argument
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static string Space(int number)
        {
            return new String(' ', number);
        }

        /// <summary>
        /// Return iftrue string if breakeaven is less then reference, otherwise return iffalse
        /// </summary>
        /// <param name="reference"></param>
        /// <param name="breakeven"></param>
        /// <param name="iftrue"></param>
        /// <param name="iffalse"></param>
        /// <returns></returns>
        public static string StringIfLess(int reference, int breakeven, string iftrue, string iffalse)
        {
            return reference < breakeven ? iftrue : iffalse;
        }

        /// <summary>
        /// Return a StringBuilder object loaded with AppendLine method using string from a list of string as argument
        /// </summary>
        /// <param name="elements"></param>
        /// <returns></returns>
        public static StringBuilder ListOfStringToStringBuilderAppendLine(List<String> elements)
        {
            StringBuilder ReturnValue = new();

            foreach (String element in elements)
            {
                ReturnValue.AppendLine(element);
            }
            return ReturnValue;
        }

        /// <summary>
        /// Write on file fi a text , if file exist and overWrite is true then text is overwritten and return true ,
        /// if file exist and overWrite is false then no text is written ,
        /// </summary>
        /// <param name="fi"></param>
        /// <param name="text"></param>
        /// <param name="overWrite"></param>
        /// <returns></returns>
        public static bool WriteToFile(FileInfo fi, string text, Boolean overWrite = true)
        {
            Boolean ReturnValue = false;

            if (((fi.Exists == true) && (overWrite == true)) || (fi.Exists == false))
            {
                File.WriteAllText(fi.FullName, text);
                ReturnValue = true;
            }

            return ReturnValue;
        }
    }
}