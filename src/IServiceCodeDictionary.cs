using GAAPICommon.Core.Dtos;

namespace ServiceCodeSupport.Architecture;

public interface IServiceCodeDictionary
{
    public ServiceCodeDefinitionDto? GetDefinition(int serviceCode);
}