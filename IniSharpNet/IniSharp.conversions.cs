using IniSharpNet;
using System.Security.Principal;
using System.Text;
using System.Xml.Schema;

namespace IniSharpBox
{
    public partial class IniSharp
    {
        public const int TAB = 4;
        public string ToJson()
        {
            string ReturnValue = String.Empty;
            int ident = 0;
            string comma = String.Empty;
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("{"); // Strat of file

            for (int iSection = 0; iSection < Sections.Count; iSection++)
            {
                Section section = Sections[iSection];
                ident++;
                sb.AppendLine($"{Helpers.Space(ident*TAB)}\"{section.Name}\": ["); // Start list of field of this section

                for (int iField = 0; iField < section.Fields.Count; iField++)
                {
                    ident++;
                    {                
                        sb.AppendLine($"{Helpers.Space(ident*TAB)}{{"); // Start field

                        Field field = section.Fields[iField];
                        ident++;
                        {
                            sb.AppendLine($"{Helpers.Space(ident*TAB)}\"{field.Name}\": ["); // Start list of line
                            string line = string.Empty;
                            for (int iLine = 0; iLine < field.Lines.Count; iLine++)
                            {
                                line = field.Lines[iLine];
                                ident++;
                                {
                                    comma = Helpers.StringIfLess(iLine, field.Lines.Count - 1 ,",",string.Empty);
                                    sb.AppendLine($"{Helpers.Space(ident*TAB)}\"{iLine}\": \"{line}\"{comma}");
                                }                          
                                ident--;
                            }
                        }
                        ident--;

                        sb.AppendLine($"{Helpers.Space(ident*TAB)}]"); // End list of line
                    }
                    ident--;

                    comma = Helpers.StringIfLess(iField, section.Fields.Count - 1, ",", string.Empty);
                    sb.AppendLine($"{Helpers.Space(ident*TAB)}}}{comma}"); // End field

                }
                ident--;

                comma = Helpers.StringIfLess(iSection, Sections.Count - 1, ",", string.Empty);
                sb.AppendLine($"{Helpers.Space(ident*TAB)}]{comma}");// End list of field of this section
            }


            sb.AppendLine($"}}"); // End of file

            ReturnValue = sb.ToString();
            return ReturnValue;
        }

        public bool FromJson(string text)
        {
            return false;
        }

        public string ToXml()
        {
            return string.Empty;
        }

        public bool FromXml(string text)
        {
            return false;
        }
    }
}