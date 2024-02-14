using GAAPICommon.Core.Dtos;
using GAServiceCodes.Architecture;
using System.Data.SQLite;

namespace GAServiceCodes;

public class ServiceCodeDictionary : IServiceCodeDictionary
{
    public string FileName { get; } = string.Empty;

    private string connectionString { get; } = string.Empty;

    private void HandleLoadDB()
    {
        using FileStream fileStream = new(FileName, FileMode.Create);
        fileStream.Write(Properties.Resources.ServiceCodes, 0, Properties.Resources.ServiceCodes.Length);
    }

    public ServiceCodeDictionary()
    {
        FileName = Path.GetTempFileName();
        connectionString = $"Data Source={FileName};Version=3;Read Only=True;";

        HandleLoadDB();
    }

    public ServiceCodeDefinitionDto? GetDefinition(int serviceCode)
    {
        using SQLiteConnection connection = new(connectionString);
        connection.Open();

        using SQLiteCommand command = new(connection);
        command.CommandText = "SELECT ServiceCode, Message, Description, Solution FROM ServiceCodes WHERE ServiceCode = @serviceCodeParam";

        SQLiteParameter parameter = new("@serviceCodeParam", System.Data.DbType.Int32) { Value = serviceCode };
        command.Parameters.Add(parameter);

        using SQLiteDataReader reader = command.ExecuteReader();
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