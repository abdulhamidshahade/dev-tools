namespace DevTools.API.Services;

public interface IPostgresqlInOperatorService
{
    string BuildInOperator(string columnName, List<string> values, string valueType);
}
