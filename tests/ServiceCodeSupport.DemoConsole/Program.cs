using ServiceCodeSupport.APICommon;
using ServiceCodeSupport.APICommon.Dtos;
using ServiceCodeSupport.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ServiceCodeSupport.DemoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceCodeDictionary serviceCodeDictionary = new ServiceCodeDictionary();

            bool continueFlag = true;

            while (continueFlag)
            {
                Console.WriteLine("Enter a service code or 'q' to quit");
                string line = Console.ReadLine();

                if (int.TryParse(line, out int serviceCode))
                {
                    ServiceCodeDefinitionDto dto = serviceCodeDictionary.GetDefinition(serviceCode);

                    if (dto == null)
                        Console.WriteLine("Unkown service code");
                    else
                    {
                        Console.WriteLine(dto.ToSummary());
                    }
                }
                else
                {
                    if (line.Any() && line.ToLowerInvariant().First().CompareTo('q') == 0)
                        continueFlag = false;
                }               
            }            
        }
    }
}
