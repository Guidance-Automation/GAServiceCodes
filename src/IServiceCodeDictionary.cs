using GAAPICommon.Core.Dtos;

namespace GAServiceCodes.Architecture;

public interface IServiceCodeDictionary
{
    public ServiceCodeDefinitionDto? GetDefinition(int serviceCode);
}