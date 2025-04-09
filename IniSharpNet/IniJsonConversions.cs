using Newtonsoft.Json.Linq;
using System.Text;
using System.Web;

namespace IniSharpNet
{
    namespace Conversion
    {
        /// <summary>
        /// Defines interoperability functions for INI and JSON.
        /// Thanks to J. Ritchie Carroll (ritchiecarroll : https://gist.github.com/ritchiecarroll )
        ///
        /// https://gist.github.com/ritchiecarroll/42909ef62e8597c58ee2301fd2a05e3c
        /// </summary>
        public static class IniJsonInterop
        {
            /// <summary>
            /// Performs JavaScript encoding on given string.
            /// </summary>
            /// <param name="value">The string to be encoded.</param>
            public static string JavaScriptEncode(this string text)
            {
                return HttpUtility.JavaScriptStringEncode(text ?? string.Empty);
            }

            /// <summary>
            /// Gets INI as JSON.
            /// </summary>
            /// <param name="value">INI source.</param>
            /// <param name="indented"><c>true</c> to indent result JSON; otherwise, <c>false</c>.</param>
            /// <param name="preserveComments"><c>true</c> to preserve comments; otherwise, <c>false</c>.</param>
            /// <returns>Converted JSON.</returns>
            public static string GetIniAsJson(string value, bool indented, bool preserveComments)
            {
                StringBuilder json = new();
                string[] lines = value.Split(new[] { "\r\n", "\n" }, StringSplitOptions.None).Select(line => line.Trim()).ToArray();
                string section = null;
                int kvpIndex = 0, commentIndex = 0;

                void addComment(string comment, bool eol = false)
                {
                    if (!preserveComments)
                        return;

                    json.Append($"{(kvpIndex > 0 ? "," : "")}\"@c{++commentIndex}{(eol ? "eol" : "")}\":\"{comment.Trim().JavaScriptEncode()}\"");
                    kvpIndex++;
                }

                string removeTrailingComment(string line)
                {
                    // Remove any trailing comment from section line
                    int index = line.IndexOf(";", StringComparison.Ordinal);

                    if (index > -1)
                    {
                        addComment(line.Substring(index), true);
                        line = line.Substring(0, index).Trim();
                    }

                    return line;
                }

                json.Append("{");

                for (int i = 0; i < lines.Length; i++)
                {
                    string line = lines[i];

                    if (string.IsNullOrWhiteSpace(line) || line.StartsWith(";"))
                    {
                        addComment(line);
                    }
                    else if (line.StartsWith("["))
                    {
                        line = removeTrailingComment(line);

                        if (line.EndsWith("]"))
                        {
                            if (section is not null)
                                json.Append("},");
                            else if (commentIndex > 0)
                                json.Append(",");

                            section = line.Substring(1, line.Length - 2).Trim();
                            json.Append($"\"{section.JavaScriptEncode()}\":{{");
                            kvpIndex = commentIndex = 0;
                        }
                        else
                        {
                            throw new InvalidOperationException($"INI section has an invalid format: \"{lines[i]}\"");
                        }
                    }
                    else
                    {
                        line = removeTrailingComment(line);

                        string[] kvp = line.Split('=');

                        if (kvp.Length != 2)
                            throw new InvalidOperationException($"INI key-value entry has an invalid format: \"{lines[i]}\"");

                        json.Append($"{(kvpIndex > 0 ? "," : "")}\"{kvp[0].Trim().JavaScriptEncode()}\":\"{kvp[1].Trim().JavaScriptEncode()}\"");
                        kvpIndex++;
                    }
                }

                if (section is not null)
                    json.Append("}");

                json.Append("}");

                return indented ?
                    JToken.Parse(json.ToString()).ToString(Newtonsoft.Json.Formatting.Indented) :
                    json.ToString();
            }

            /// <summary>
            /// Gets JSON as INI.
            /// </summary>
            /// <param name="value">JSON source.</param>
            /// <param name="restoreComments"><c>true</c> to restore comments; otherwise, <c>false</c>.</param>
            /// <returns>Converted INI.</returns>
            public static string GetJsonAsIni(string value, bool restoreComments)
            {
                StringBuilder ini = new();
                JObject json = JObject.Parse(value);
                string eolComment = string.Empty;

                void writeProperty(JProperty property)
                {
                    if (property is null)
                        return;

                    if (property.Name.StartsWith("@c"))
                    {
                        if (restoreComments)
                        {
                            if (property.Name.EndsWith("eol"))
                                eolComment = $" {property.Value}";
                            else
                                ini.AppendLine(property.Value.ToString());
                        }
                    }
                    else
                    {
                        ini.AppendLine($"{property.Name}={property.Value}{eolComment}");
                        eolComment = string.Empty;
                    }
                }

                foreach (JProperty property in json.Properties())
                {
                    if (property.Value.HasValues)
                    {
                        ini.AppendLine($"[{property.Name}]{eolComment}");
                        eolComment = string.Empty;

                        foreach (JToken kvp in property.Value)
                            writeProperty(kvp as JProperty);
                    }
                    else
                    {
                        writeProperty(property);
                    }
                }

                return ini.ToString();
            }
        }
    }
}