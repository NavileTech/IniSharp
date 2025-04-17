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

    /// <summary>
    /// Duplicate\Merge strategy used by Merge methods
    /// </summary>
    public enum ALLOWDUPLICATE
    {
        /// <summary>
        /// If two section with same Name merge them in one and follow next strategy , otherwise duplicate the sections
        /// If two field   with same Name (in two section with same Name) merge them in one and follow next strategy , otherwise duplicate the fields
        /// If two field-value   with same value (in two section with same Name containig two field with same Name ) merge them in one (pick first)
        /// </summary>
        NOT_SECTION_NOT_FIELD_NOT_VALUE = 1,

        /// <summary>
        /// If two section with same Name merge them in one and follow next strategy , otherwise duplicate the sections
        /// If two field   with same Name (in two section with same Name) merge them in one and follow next strategy , otherwise duplicate the fields
        /// If two field-value   with same value (in two section with same Name containig two field with same Name ) duplicate them  (first then second)
        /// </summary>
        NOT_SECTION_NOT_FIELD_DO_VALUE = 2,

        /// <summary>
        /// If two section with same Name merge them in one and follow next strategy , otherwise duplicate the sections
        /// If two field   with same Name (in two section with same Name) duplicate them writing in order (first then second)
        /// </summary>
        NOT_SECTION_DO_FIELD = 4,

        /// <summary>
        /// If two section with same Name duplicate them writing in order
        /// </summary>
        DO_SECTION = 8,
    }
}