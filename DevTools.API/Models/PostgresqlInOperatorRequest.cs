namespace DevTools.API.Models;

public class PostgresqlInOperatorRequest
{
    public required string ColumnName { get; set; }
    public required List<string> Values { get; set; }
    public required string ValueType { get; set; }
}
