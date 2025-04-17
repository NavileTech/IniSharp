using IniSharpNet;
using Newtonsoft.Json;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace IniSharpBox
{
    public partial class IniSharp
    {
        /// <summary>
        /// Define tabulation for json custom formatting
        /// </summary>
        public const int TAB = 4;

        /// <summary>
        /// Return a serialized json custom formatted string
        /// </summary>
        /// <returns></returns>
        public string ToJson()
        {
            string ReturnValue;
            int ident = 0;
            string comma;
            StringBuilder sb = new();

            sb.AppendLine("{"); // Strat of file

            for (int iSection = 0; iSection < Body.Count; iSection++)
            {
                Section section = Body[iSection];
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
                            sb.AppendLine($"{Helpers.Space(ident*TAB)}\"{field.Name}\": {{"); // Start list of line
                            string line;
                            for (int iLine = 0; iLine < field.Lines.Count; iLine++)
                            {
                                line = field.Lines[iLine];
                                ident++;
                                {
                                    comma = Helpers.StringIfLess(iLine, field.Lines.Count - 1, ",", string.Empty);
                                    sb.AppendLine($"{Helpers.Space(ident*TAB)}\"{iLine}\": \"{line}\"{comma}");
                                }
                                ident--;
                            }
                        }

                        sb.AppendLine($"{Helpers.Space(ident*TAB)}}}"); // End list of line
                        ident--;
                    }

                    comma = Helpers.StringIfLess(iField, section.Fields.Count - 1, ",", string.Empty);
                    sb.AppendLine($"{Helpers.Space(ident*TAB)}}}{comma}"); // End field
                    ident--;
                }

                comma = Helpers.StringIfLess(iSection, Body.Count - 1, ",", string.Empty);
                sb.AppendLine($"{Helpers.Space(ident*TAB)}]{comma}");// End list of field of this section
                ident--;
            }

            sb.AppendLine($"}}"); // End of file

            ReturnValue = sb.ToString();
            return ReturnValue;
        }

        /// <summary>
        /// Return a serialized json Newtonsoft formatted string
        /// </summary>
        /// <returns></returns>
        public string ToJsonSerialize()
        {
            return JsonConvert.SerializeObject(this.Body);
        }

        /// <summary>
        /// Return true if deserialization of a serialized json custom formatted string succeded, otherwise false.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public bool FromJson(string text)
        {
            bool ReturnValue;
            try
            {
                Dictionary<string, List<Dictionary<string, Dictionary<string, string>>>> data = JsonConvert.DeserializeObject<Dictionary<string, List<Dictionary<string, Dictionary<string, string>>>>>(text);

                foreach (KeyValuePair<string, List<Dictionary<string, Dictionary<string, string>>>> section in data)
                {
                    //Debug.WriteLine($"[{section.Key}]");
                    Section sectionIni = new(0, section.Key, this.Config);
                    foreach (var fields in section.Value)
                    {
                        foreach (KeyValuePair<string, Dictionary<string, string>> field in fields)
                        {
                            //Debug.Write($"{field.Key} = ");
                            Field fieldIni = new(0, field.Key, this.Config);
                            int counter = 0;
                            foreach (KeyValuePair<string, string> fieldvalue in field.Value)
                            {
                                if (counter == field.Value.Count - 1)
                                {
                                    //Debug.WriteLine($"\"{fieldvalue.Value}\"");
                                }
                                else
                                {
                                    //Debug.Write($"\"{fieldvalue.Value}\"|");
                                    counter++;
                                }
                                fieldIni.Add(fieldvalue.Value);
                            }
                            sectionIni.Add(fieldIni);
                        }
                    }
                    this.Body.Add(sectionIni);
                }

                ReturnValue = true;
            }
            catch (Exception ex)
            {
                _Exceptions.Add(ex.Message + "\n" + ex.StackTrace);
                ReturnValue = false;
            }

            return ReturnValue;
        }

        /// <summary>
        /// Return true if deserialization of a serialized json Newtonsoft formatted string succeded, otherwise false.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public bool FromJsonDeserialize(string text)
        {
            bool ReturnValue = false;
            try
            {
                this.Body = JsonConvert.DeserializeObject<Sections>(text);
                ReturnValue = true;
            }
            catch (Exception ex)
            {
                _Exceptions.Add(ex.Message);
            }

            return ReturnValue;
        }

        /// <summary>
        /// Return a serialized xml formatted string
        /// </summary>
        /// <returns></returns>
        public string ToXml()
        {
            string ReturnValue;

            try
            {
                XmlSerializer xmlserializer = new(typeof(Sections));
                StringWriter stringWriter = new();
                XmlWriter writer = XmlWriter.Create(stringWriter);

                xmlserializer.Serialize(writer, this.Body);

                ReturnValue = stringWriter.ToString();
            }
            catch (Exception ex)
            {
                _Exceptions.Add(ex.Message + "\n" + ex.StackTrace);
                ReturnValue = string.Empty;
            }
            return ReturnValue;
        }

        /// <summary>
        /// Return true if xml deserialization of a serialized xml string succeded, otherwise false.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public bool FromXml(string text)
        {
            bool ReturnValue;
            try
            {
                var deserializer = new XmlSerializer(typeof(Sections));
                using (TextReader reader = new StringReader(text))
                {
                    this.Body = (Sections)deserializer.Deserialize(reader);
                }
                ReturnValue = true;
            }
            catch (Exception ex)
            {
                _Exceptions.Add(ex.Message + "\n" + ex.StackTrace);
                ReturnValue = false;
            }

            return ReturnValue;
        }
    }
}