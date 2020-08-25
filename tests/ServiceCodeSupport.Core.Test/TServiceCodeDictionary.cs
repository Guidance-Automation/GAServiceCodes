using NUnit.Framework;
using ServiceCodeSupport.APICommon.Dtos;

namespace ServiceCodeSupport.Core.Test
{
    [TestFixture]
    public class TServiceCodeDictionary
    {
        [Test]
        public void NoError()
        {
            ServiceCodeDictionary serviceCodeDictionary = new ServiceCodeDictionary();
            ServiceCodeDefinitionDto dto = serviceCodeDictionary.GetDefinition(0);

            Assert.IsNotNull(dto);

            Assert.AreEqual(0, dto.ServiceCode);
            StringAssert.AreEqualIgnoringCase("no error", dto.Message);
            StringAssert.AreEqualIgnoringCase("The operation has completed successfully.", dto.Description);
            StringAssert.AreEqualIgnoringCase(string.Empty, dto.Solution);
        }

        [Test]
        public void UnknownFailure()
        {
            ServiceCodeDictionary serviceCodeDictionary = new ServiceCodeDictionary();
            ServiceCodeDefinitionDto dto = serviceCodeDictionary.GetDefinition(1);

            Assert.IsNotNull(dto);

            Assert.AreEqual(1, dto.ServiceCode);
            StringAssert.AreEqualIgnoringCase("Unknown Failure", dto.Message);
            StringAssert.AreEqualIgnoringCase("No description.", dto.Description);
            StringAssert.AreEqualIgnoringCase("Unknown.", dto.Solution);
        }
    }
}
