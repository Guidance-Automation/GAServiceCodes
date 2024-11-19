using GAAPICommon.Messages;

namespace GAServiceCodes;

public interface IServiceCodeDictionary
{
    public ServiceCodeDefinitionDto? GetDefinition(int serviceCode);
}