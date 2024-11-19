using GAAPICommon.Messages;
using Microsoft.Data.Sqlite;

namespace GAServiceCodes;

public class ServiceCodeDictionary : IServiceCodeDictionary
{
    private readonly string _connectionString = string.Empty;

    public string FileName { get; } = string.Empty;

    private void HandleLoadDB()
    {
        using FileStream fileStream = new(FileName, FileMode.Create);
        fileStream.Write(Properties.Resources.ServiceCodes, 0, Properties.Resources.ServiceCodes.Length);
    }

    public ServiceCodeDictionary()
    {
        FileName = Path.GetTempFileName();
        _connectionString = $"Data Source={FileName};Mode=ReadOnly";
        HandleLoadDB();
    }

    public ServiceCodeDefinitionDto? GetDefinition(int serviceCode)
    {
        using SqliteConnection connection = new(_connectionString);
        connection.Open();

        using SqliteCommand command = new("SELECT ServiceCode, Message, Description, Solution FROM ServiceCodes WHERE ServiceCode = @serviceCodeParam", connection);

        SqliteParameter parameter = new("@serviceCodeParam", SqliteType.Integer) { Value = serviceCode };
        command.Parameters.Add(parameter);

        using SqliteDataReader reader = command.ExecuteReader();
        while (reader.Read())
        {
            return new ServiceCodeDefinitionDto()
            {
                ServiceCode = reader.GetInt32(0),
                Message = reader.GetString(1),
                Description = reader.GetString(2),
                Solution = reader.GetString(3)
            };
        }

        return null;
    }
}