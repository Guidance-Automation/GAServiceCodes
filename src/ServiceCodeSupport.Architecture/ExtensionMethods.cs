using GAAPICommon.Core.Dtos;
using System;

namespace ServiceCodeSupport.Architecture
{
    public static class ExtensionMethods
    {
        public static ServiceCodeDefinitionDto GetDefinition(this IServiceCodeDictionary dictionary, ErrorCode errorCode)
        {
            if (dictionary == null)
                throw new ArgumentNullException("dictionary");

            return dictionary.GetDefinition((int)errorCode);
        }
    }
}
