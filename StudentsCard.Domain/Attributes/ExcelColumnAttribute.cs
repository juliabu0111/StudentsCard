namespace StudentsCard.Domain.Attributes
{
    public class ExcelColumnAttribute : Attribute
    {
        public string Column { get; set; }

        public ExcelColumnAttribute(string column)
        {
            Column = column;
        }
    }
}