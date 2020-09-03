using GAAPICommon.Core.Dtos;
using ServiceCodeSupport.Architecture;
using System.Data.SQLite;
using System.IO;
using System.Reflection;

namespace ServiceCodeSupport.Core
{
    public class ServiceCodeDictionary : IServiceCodeDictionary
    {
        public string FileName { get; } = string.Empty;

        private string connectionString { get; } = string.Empty;

        private void HandleLoadDB()
        {
            Assembly ass = Assembly.GetExecutingAssembly();

            using (Stream stream = ass.GetManifestResourceStream(@"ServiceCodeSupport.Core.Resources.ServiceCodes.sqlite"))
            {
                using (FileStream fileStream = new FileStream(FileName, FileMode.Create))
                {
                    stream.CopyTo(fileStream);
                }
            }
        }

        public ServiceCodeDictionary()
        {
            FileName = Path.GetTempFileName();
            connectionString = $"Data Source={FileName};Version=3;Read Only=True;";

            HandleLoadDB();
        }

        public ServiceCodeDefinitionDto GetDefinition(int serviceCode)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = "SELECT ServiceCode, Message, Description, Solution FROM ServiceCodes WHERE ServiceCode = @serviceCodeParam";

                    SQLiteParameter parameter = new SQLiteParameter("@serviceCodeParam", System.Data.DbType.Int32) { Value = serviceCode };
                    command.Parameters.Add(parameter);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
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
                    }
                }
            }

            return null;
        }
    }
}