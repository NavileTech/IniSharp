﻿namespace IniSharpBox
{
    public partial class IniSharp
    {
        /// <summary>
        /// Return value if exist , otherwise null
        /// </summary>
        /// <param name="section"></param>
        /// <param name="field"></param>
        /// <param name="indexvalue"></param>
        /// <returns></returns>
        public String GetValue(int section, int field, int indexvalue)
        {
            String ReturnValue = String.Empty;

            if (this.Check(section, field, indexvalue) == 0)
            {
                ReturnValue = this[section][field][indexvalue];
            }

            return ReturnValue;
        }

        /// <summary>
        /// Return value if exist , otherwise null
        /// </summary>
        /// <param name="section"></param>
        /// <param name="field"></param>
        /// <param name="indexvalue"></param>
        /// <returns></returns>
        public String GetValue(int section, String field, int indexvalue)
        {
            String ReturnValue = String.Empty;

            if (this.Check(section, field, indexvalue) == 0)
            {
                ReturnValue = this[section][field][indexvalue];
            }

            return ReturnValue;
        }

        /// <summary>
        /// Return value if exist , otherwise null
        /// </summary>
        /// <param name="section"></param>
        /// <param name="field"></param>
        /// <param name="indexvalue"></param>
        /// <returns></returns>
        public String GetValue(String section, int field, int indexvalue)
        {
            String ReturnValue = String.Empty;

            if (this.Check(section, field, indexvalue) == 0)
            {
                ReturnValue = this[section][field][indexvalue];
            }

            return ReturnValue;
        }

        /// <summary>
        /// Return value if exist , otherwise null
        /// </summary>
        /// <param name="section"></param>
        /// <param name="field"></param>
        /// <param name="indexvalue"></param>
        /// <returns></returns>
        public String GetValue(String section, String field, int indexvalue)
        {
            String ReturnValue = String.Empty;

            if (this.Check(section, field, indexvalue) == 0)
            {
                ReturnValue = this[section][field][indexvalue];
            }

            return ReturnValue;
        }

        /// <summary>
        /// Return value if exist , otherwise null
        /// </summary>
        /// <param name="section"></param>
        /// <param name="field"></param>
        /// <param name="indexvalue"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public Boolean SetValue(int section, int field, int indexvalue, String value)
        {
            Boolean ReturnValue = false;

            if (this.Check(section, field, indexvalue) == 0)
            {
                this[section][field][indexvalue] = value;
                ReturnValue = true;
            }

            return ReturnValue;
        }

        /// <summary>
        /// Return value if exist , otherwise null
        /// </summary>
        /// <param name="section"></param>
        /// <param name="field"></param>
        /// <param name="indexvalue"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public Boolean SetValue(int section, String field, int indexvalue, String value)
        {
            Boolean ReturnValue = false;

            if (this.Check(section, field, indexvalue) == 0)
            {
                this[section][field][indexvalue] = value;
                ReturnValue = true;
            }

            return ReturnValue;
        }

        /// <summary>
        /// Return value if exist , otherwise null
        /// </summary>
        /// <param name="section"></param>
        /// <param name="field"></param>
        /// <param name="indexvalue"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public Boolean SetValue(String section, int field, int indexvalue, String value)
        {
            Boolean ReturnValue = false;

            if (this.Check(section, field, indexvalue) == 0)
            {
                this[section][field][indexvalue] = value;
                ReturnValue = true;
            }

            return ReturnValue;
        }

        /// <summary>
        /// Return value if exist , otherwise null
        /// </summary>
        /// <param name="section"></param>
        /// <param name="field"></param>
        /// <param name="indexvalue"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public Boolean SetValue(String section, String field, int indexvalue, String value)
        {
            Boolean ReturnValue = false;

            if (this.Check(section, field, indexvalue) == 0)
            {
                this[section][field][indexvalue] = value;
                ReturnValue = true;
            }

            return ReturnValue;
        }

        /// <summary>
        /// Return status of get/set operation
        /// -2 : section do not exist
        /// -1 : section exist , field do not exit
        /// 0  : section , field and index value exist
        /// +1 : section , field exist but indexvalue eccede by 1 of current Lines count
        /// +2 : section , field exist but indexvalue eccede by more than 1 of current Lines count
        /// </summary>
        /// <param name="section"></param>
        /// <param name="field"></param>
        /// <param name="indexvalue"></param>
        /// <returns></returns>
        public int Check(int section, int field, int indexvalue)
        {
            int ReturnValue = int.MinValue;
            if (this.Body.Contains(section) == true)
            {
                if (this.Body[section].Fields.Contains(field) == true)
                {
                    if (this.Body[section].Fields[field].Lines.Count > indexvalue)
                    {
                        ReturnValue = 0;
                    }
                    else
                    {
                        if (this.Body[section].Fields[field].Lines.Count == indexvalue)
                        {
                            ReturnValue = 1;
                        }
                        else
                        {
                            ReturnValue = 2;
                        }
                    }
                }
                else
                {
                    ReturnValue = -1;
                }
            }
            else
            {
                ReturnValue = -2;
            }

            return ReturnValue;
        }

        /// <summary>
        /// Return status of get/set operation
        /// -2 : section do not exist
        /// -1 : section exist , field do not exit
        /// 0  : section , field and index value exist
        /// +1 : section , field exist but indexvalue eccede by 1 of current Lines count
        /// +2 : section , field exist but indexvalue eccede by more than 1 of current Lines count
        /// </summary>
        /// <param name="section"></param>
        /// <param name="field"></param>
        /// <param name="indexvalue"></param>
        /// <returns></returns>
        public int Check(int section, String field, int indexvalue)
        {
            int ReturnValue = int.MinValue;
            if (this.Body.Contains(section) == true)
            {
                if (this.Body[section].Fields.Contains(field) == true)
                {
                    if (this.Body[section].Fields[field].Lines.Count > indexvalue)
                    {
                        ReturnValue = 0;
                    }
                    else
                    {
                        if (this.Body[section].Fields[field].Lines.Count == indexvalue)
                        {
                            ReturnValue = 1;
                        }
                        else
                        {
                            ReturnValue = 2;
                        }
                    }
                }
                else
                {
                    ReturnValue = -1;
                }
            }
            else
            {
                ReturnValue = -2;
            }

            return ReturnValue;
        }

        /// <summary>
        /// Return status of get/set operation
        /// -2 : section do not exist
        /// -1 : section exist , field do not exit
        /// 0  : section , field and index value exist
        /// +1 : section , field exist but indexvalue eccede by 1 of current Lines count
        /// +2 : section , field exist but indexvalue eccede by more than 1 of current Lines count
        /// </summary>
        /// <param name="section"></param>
        /// <param name="field"></param>
        /// <param name="indexvalue"></param>
        /// <returns></returns>
        public int Check(String section, int field, int indexvalue)
        {
            int ReturnValue = int.MinValue;
            if (this.Body.Contains(section) == true)
            {
                if (this.Body[section].Fields.Contains(field) == true)
                {
                    if (this.Body[section].Fields[field].Lines.Count > indexvalue)
                    {
                        ReturnValue = 0;
                    }
                    else
                    {
                        if (this.Body[section].Fields[field].Lines.Count == indexvalue)
                        {
                            ReturnValue = 1;
                        }
                        else
                        {
                            ReturnValue = 2;
                        }
                    }
                }
                else
                {
                    ReturnValue = -1;
                }
            }
            else
            {
                ReturnValue = -2;
            }

            return ReturnValue;
        }

        /// <summary>
        /// Return status of get/set operation
        /// -2 : section do not exist
        /// -1 : section exist , field do not exit
        /// 0  : section , field and index value exist
        /// +1 : section , field exist but indexvalue eccede by 1 of current Lines count
        /// +2 : section , field exist but indexvalue eccede by more than 1 of current Lines count
        /// </summary>
        /// <param name="section"></param>
        /// <param name="field"></param>
        /// <param name="indexvalue"></param>
        /// <returns></returns>
        public int Check(String section, String field, int indexvalue)
        {
            int ReturnValue = int.MinValue;
            if (this.Body.Contains(section) == true)
            {
                if (this.Body[section].Fields.Contains(field) == true)
                {
                    if (this.Body[section].Fields[field].Lines.Count > indexvalue)
                    {
                        ReturnValue = 0;
                    }
                    else
                    {
                        if (this.Body[section].Fields[field].Lines.Count == indexvalue)
                        {
                            ReturnValue = 1;
                        }
                        else
                        {
                            ReturnValue = 2;
                        }
                    }
                }
                else
                {
                    ReturnValue = -1;
                }
            }
            else
            {
                ReturnValue = -2;
            }

            return ReturnValue;
        }

        /// <summary>
        /// Return true if an item with name == Name exists and removing process succeed, otherwise false
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool Remove(string name)
        {
            bool ReturnValue = false;
            int index = Body.GetIndexByName(name);
            if (index >= 0)
            {
                ReturnValue = Body.Remove(index);
            }

            return ReturnValue;
        }

        /// <summary>
        /// Return true if an item with index pass as argument exists and removing process succeed, otherwise false
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool Remove(int index)
        {
            bool ReturnValue = false;

            if (index >= 0)
            {
                Body.Remove(index);
                ReturnValue = true;
            }

            return ReturnValue;
        }

        /// <summary>
        /// Return a value that show comparison status between 3 object
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <param name="third"></param>
        /// <returns></returns>
        public static byte Compare(IniSharp first, IniSharp second, IniSharp third)
        {
            byte ReturnValue = 0;
            if (first.Hash().SequenceEqual(second.Hash()) == false)
            {
                ReturnValue += 1;
            }

            if (first.Hash().SequenceEqual(third.Hash()) == false)
            {
                ReturnValue += 2;
            }

            if (second.Hash().SequenceEqual(third.Hash()) == false)
            {
                ReturnValue += 4;
            }

            return ReturnValue;
        }
    }
}