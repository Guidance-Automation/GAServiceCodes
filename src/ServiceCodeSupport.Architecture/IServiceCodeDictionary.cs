using GAAPICommon.Core.Dtos;

namespace ServiceCodeSupport.Architecture
{
    public interface IServiceCodeDictionary
    {
        ServiceCodeDefinitionDto GetDefinition(int serviceCode);
    }
}