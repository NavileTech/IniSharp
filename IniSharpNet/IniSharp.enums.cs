namespace IniSharpBox
{
    /// <summary>
    /// Strategy for accessor property of indexer property used in parsing file
    /// </summary>
    public enum AccessorsStrategy
    {
        /// <summary>
        /// Do not allow to add item in field values
        /// </summary>
        STATIC,

        /// <summary>
        /// Allow to add one value in Field at index == i+1 if i is actual max index of Field values
        /// Valid only for BYINDEX accessor
        /// </summary>
        DINAMIC,

        /// <summary>
        /// Strategy is not defined
        /// </summary>
        NOT_INITIALIZE = int.MinValue
    }

    /// <summary>
    /// Parsing errors
    /// </summary>
    public enum ERROR
    {
        /// <summary>
        /// Parsing is not yet start
        /// </summary>
        NOT_EXECUTE = -1,

        /// <summary>
        /// No error is detected
        /// </summary>
        NO_ERROR = 0,
    }

    /// <summary>
    /// State used during parsing of ini file
    /// </summary>
    public enum PARSE_STATE
    {
        /// <summary>
        /// At start of file
        /// </summary>
        INIT = 0,

        /// <summary>
        /// A Section is detected
        /// </summary>
        SECTION = 1,

        /// <summary>
        /// A Field is detected
        /// </summary>
        FIELD = 2,

        /// <summary>
        /// A comment is detected
        /// </summary>
        COMMENT = 3,

        /// <summary>
        /// an empty line is detected
        /// </summary>
        EMPTY_LINE = 4
    }

    /// <summary>
    /// Definition of separator of multi value Field for parsing ini file
    /// </summary>
    public enum MULTIVALUESEPARATOR
    {
        /// <summary>
        /// Use  "\r\n", "\r", "\n" as multi value separator
        /// </summary>
        NEWLINE = 0,

        /// <summary>
        /// Use "," as multi value separator
        /// </summary>
        COMMA = 1,

        /// <summary>
        /// Use "|" as multi value separator
        /// </summary>
        PIPE = 2,
    }
}