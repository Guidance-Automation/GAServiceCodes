using GAAPICommon.Messages;

namespace GAServiceCodes.Architecture;

public interface IServiceCodeDictionary
{
    public ServiceCodeDefinition? GetDefinition(int serviceCode);
}