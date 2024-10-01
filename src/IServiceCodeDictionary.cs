using GAAPICommon.Messages;

namespace GAServiceCodes.Architecture;

public interface IServiceCodeDictionary
{
    public ServiceCodeDefinitionDto? GetDefinition(int serviceCode);
}