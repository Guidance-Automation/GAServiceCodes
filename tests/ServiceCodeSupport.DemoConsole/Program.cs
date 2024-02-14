using GAAPICommon.Core.Dtos;
using ServiceCodeSupport.Core;

namespace ServiceCodeSupport.DemoConsole;

internal class Program
{
    private static void Main(string[] _)
    {
        ServiceCodeDictionary serviceCodeDictionary = new();

        bool continueFlag = true;

        while (continueFlag)
        {
            Console.WriteLine("Enter a service code or 'q' to quit");
            string? line = Console.ReadLine();

            if (int.TryParse(line, out int serviceCode))
            {
                ServiceCodeDefinitionDto? dto = serviceCodeDictionary.GetDefinition(serviceCode);

                if (dto == null)
                    Console.WriteLine("Unknown service code");
                else
                {
                    Console.WriteLine(dto.ToSummary());
                }
            }
            else
            {
                if (line != null && line.Length != 0 && line.ToLowerInvariant().First().CompareTo('q') == 0)
                    continueFlag = false;
            }
        }
    }
}