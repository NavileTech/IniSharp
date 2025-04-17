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
        /// <param name="firstConfig"></param>
        /// <param name="secondConfig"></param>
        /// <param name="duplicate"></param>
        /// <returns></returns>
        public static IniSharp Merge(FileInfo first, FileInfo second, IniConfig firstConfig, IniConfig secondConfig, ALLOWDUPLICATE duplicate)
        {
            IniSharp ReturnValue = new(firstConfig)
            {
                Body = Sections.Merge(IniSharp.Load(first, firstConfig).Body, IniSharp.Load(second, secondConfig).Body, duplicate)
            };

            return ReturnValue;
        }

        /// <summary>
        /// Return a merged IniSharp object from 2 IniSharp object provide as argument with duplicate option for every level of ini file (section, field, values).
        /// Return object has config preference of first argument.
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <param name="firstConfig"></param>
        /// <param name="secondConfig"></param>
        /// <param name="duplicate"></param>
        /// <returns></returns>
        public static IniSharp Merge(FileInfo first, string second, IniConfig firstConfig, IniConfig secondConfig, ALLOWDUPLICATE duplicate)
        {
            IniSharp ReturnValue = new(first)
            {
                Body = Sections.Merge(IniSharp.Load(first, firstConfig).Body, IniSharp.Load(second, secondConfig).Body, duplicate)
            };

            return ReturnValue;
        }

        /// <summary>
        /// Return a merged IniSharp object from 2 IniSharp object provide as argument with duplicate option for every level of ini file (section, field, values).
        /// Return object has config preference of first argument.
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <param name="firstConfig"></param>
        /// <param name="duplicate"></param>
        /// <returns></returns>
        public static IniSharp Merge(FileInfo first, IniSharp second, IniConfig firstConfig, ALLOWDUPLICATE duplicate)
        {
            IniSharp ReturnValue = new(firstConfig)
            {
                Body = Sections.Merge(IniSharp.Load(first, firstConfig).Body, second.Body, duplicate)
            };

            return ReturnValue;
        }

        /// <summary>
        /// Return a merged IniSharp object from 2 IniSharp object provide as argument with duplicate option for every level of ini file (section, field, values).
        /// Return object has config preference of first argument.
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <param name="firstConfig"></param>
        /// <param name="secondConfig"></param>
        /// <param name="duplicate"></param>
        /// <returns></returns>
        public static IniSharp Merge(string first, FileInfo second, IniConfig firstConfig, IniConfig secondConfig, ALLOWDUPLICATE duplicate)
        {
            IniSharp ReturnValue = new(firstConfig)
            {
                Body = Sections.Merge(IniSharp.Load(first, firstConfig).Body, IniSharp.Load(second, secondConfig).Body, duplicate)
            };

            return ReturnValue;
        }

        /// <summary>
        /// Return a merged IniSharp object from 2 IniSharp object provide as argument with duplicate option for every level of ini file (section, field, values).
        /// Return object has config preference of first argument.
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <param name="firstConfig"></param>
        /// <param name="secondConfig"></param>
        /// <param name="duplicate"></param>
        /// <returns></returns>
        public static IniSharp Merge(string first, string second, IniConfig firstConfig, IniConfig secondConfig, ALLOWDUPLICATE duplicate)
        {
            IniSharp ReturnValue = new(first)
            {
                Body = Sections.Merge(IniSharp.Load(first, firstConfig).Body, IniSharp.Load(second, secondConfig).Body, duplicate)
            };

            return ReturnValue;
        }

        /// <summary>
        /// Return a merged IniSharp object from 2 IniSharp object provide as argument with duplicate option for every level of ini file (section, field, values).
        /// Return object has config preference of first argument.
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <param name="firstConfig"></param>
        /// <param name="duplicate"></param>
        /// <returns></returns>
        public static IniSharp Merge(string first, IniSharp second, IniConfig firstConfig, ALLOWDUPLICATE duplicate)
        {
            IniSharp ReturnValue = new(firstConfig)
            {
                Body = Sections.Merge(IniSharp.Load(first, firstConfig).Body, second.Body, duplicate)
            };

            return ReturnValue;
        }

        /// <summary>
        /// Return a merged IniSharp object from 2 IniSharp object provide as argument with duplicate option for every level of ini file (section, field, values).
        /// Return object has config preference of first argument.
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <param name="secondConfig"></param>
        /// <param name="duplicate"></param>
        /// <returns></returns>
        public static IniSharp Merge(IniSharp first, FileInfo second, IniConfig secondConfig, ALLOWDUPLICATE duplicate)
        {
            IniSharp ReturnValue = new(first.Config)
            {
                Body = Sections.Merge(first.Body, IniSharp.Load(second, secondConfig).Body, duplicate)
            };

            return ReturnValue;
        }

        /// <summary>
        /// Return a merged IniSharp object from 2 IniSharp object provide as argument with duplicate option for every level of ini file (section, field, values).
        /// Return object has config preference of first argument.
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <param name="secondConfig"></param>
        /// <param name="duplicate"></param>
        /// <returns></returns>
        public static IniSharp Merge(IniSharp first, string second, IniConfig secondConfig, ALLOWDUPLICATE duplicate)
        {
            IniSharp ReturnValue = new(first.Config)
            {
                Body = Sections.Merge(first.Body, IniSharp.Load(second, secondConfig).Body, duplicate)
            };

            return ReturnValue;
        }

        /// <summary>
        /// Return a merged IniSharp object from 2 IniSharp object provide as argument with duplicate option for every level of ini file (section, field, values).
        /// Return object has config preference of first argument.
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <param name="duplicate"></param>
        /// <returns></returns>
        public static IniSharp Merge(IniSharp first, IniSharp second, ALLOWDUPLICATE duplicate)
        {
            IniSharp ReturnValue = new(first.Config)
            {
                Body = Sections.Merge(first.Body, second.Body, duplicate)
            };

            return ReturnValue;
        }

        /// <summary>
        /// Return a merged IniSharp object from external IniSharp object and this object the first is provide as argument with duplicate option for every level of ini file (section, field, values)
        /// Return object has config preference of this object.
        /// </summary>
        /// <param name="other"></param>
        /// <param name="duplicate"></param>
        /// <returns></returns>
        public IniSharp Merge(IniSharp other, ALLOWDUPLICATE duplicate)
        {
            return IniSharp.Merge(this, other, duplicate);
        }

        /// <summary>
        /// Return a merged IniSharp object from external IniSharp object and this object the first is provide as argument with duplicate option for every level of ini file (section, field, values)
        /// Return object has config preference of this object.
        /// </summary>
        /// <param name="other"></param>
        /// <param name="config"></param>
        /// <param name="duplicate"></param>
        /// <returns></returns>
        public IniSharp Merge(string other, IniConfig config, ALLOWDUPLICATE duplicate)
        {
            return IniSharp.Merge(this, other, config, duplicate);
        }

        /// <summary>
        /// Return a merged IniSharp object from external IniSharp object and this object the first is provide as argument with duplicate option for every level of ini file (section, field, values)
        /// Return object has config preference of this object.
        /// </summary>
        /// <param name="other"></param>
        /// <param name="config"></param>
        /// <param name="duplicate"></param>
        /// <returns></returns>
        public IniSharp Merge(FileInfo other, IniConfig config, ALLOWDUPLICATE duplicate)
        {
            return IniSharp.Merge(this, other, config, duplicate);
        }

        /// <summary>
        /// Import inside this object a merged IniSharp object from external IniSharp object and this object the first is provide as argument with duplicate option for every level of ini file (section, field, values)
        /// Imported object has config preference of this object.
        /// </summary>
        /// <param name="other"></param>
        /// <param name="duplicate"></param>
        public void Import(IniSharp other, ALLOWDUPLICATE duplicate)
        {
            this.Body = IniSharp.Merge(this, other, duplicate).Body;
        }

        /// <summary>
        /// Import inside this object a merged IniSharp object from external IniSharp object and this object the first is provide as argument with duplicate option for every level of ini file (section, field, values)
        /// Imported object has config preference of this object.
        /// </summary>
        /// <param name="other"></param>
        /// <param name="config"></param>
        /// <param name="duplicate"></param>
        public void Import(FileInfo other, IniConfig config, ALLOWDUPLICATE duplicate)
        {
            this.Body = IniSharp.Merge(this, other, config, duplicate).Body;
        }

        /// <summary>
        /// Import inside this object a merged IniSharp object from external IniSharp object and this object the first is provide as argument with duplicate option for every level of ini file (section, field, values)
        /// Imported object has config preference of this object.
        /// </summary>
        /// <param name="other"></param>
        /// <param name="config"></param>
        /// <param name="duplicate"></param>
        public void Import(string other, IniConfig config, ALLOWDUPLICATE duplicate)
        {
            this.Body = IniSharp.Merge(this, other, config, duplicate).Body;
        }
    }
}