using GAAPICommon.Core.Dtos;

namespace GAServiceCodes.Architecture;

public static class ExtensionMethods
{
    public static ServiceCodeDefinitionDto? GetDefinition(this IServiceCodeDictionary dictionary, ErrorCode errorCode)
    {
        ArgumentNullException.ThrowIfNull(dictionary);

        return dictionary.GetDefinition((int)errorCode);
    }
}