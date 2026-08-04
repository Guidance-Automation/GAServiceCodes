using GAAPICommon.Messages;
using NUnit.Framework;

namespace GAServiceCodes.Test;

[TestFixture]
public class TServiceCodeDictionary
{
    [Test]
    public void EveryGenericServiceCodeHasADefinition()
    {
        ServiceCodeDictionary serviceCodeDictionary = new();

        using (Assert.EnterMultipleScope())
        {
            foreach (GAAPICommon.Enums.ServiceCode serviceCode in Enum.GetValues<GAAPICommon.Enums.ServiceCode>())
            {
                Assert.That(
                    serviceCodeDictionary.GetDefinition((int)serviceCode),
                    Is.Not.Null,
                    $"No definition exists for {serviceCode} ({(int)serviceCode}).");
            }
        }
    }

    [Test]
    public void EveryDeclaredErrorCodeHasADefinition()
    {
        ServiceCodeDictionary serviceCodeDictionary = new();

        using (Assert.EnterMultipleScope())
        {
            foreach (ErrorCode errorCode in Enum.GetValues<ErrorCode>())
            {
                Assert.That(
                    serviceCodeDictionary.GetDefinition(errorCode),
                    Is.Not.Null,
                    $"No definition exists for {errorCode} ({(int)errorCode}).");
            }
        }
    }

    [Test]
    public void NoError()
    {
        ServiceCodeDictionary serviceCodeDictionary = new();
        ServiceCodeDefinitionDto? dto = serviceCodeDictionary.GetDefinition(0);

        Assert.That(dto, Is.Not.Null);
        if(dto != null)
        {
            using (Assert.EnterMultipleScope())
            {
                Assert.That(dto.ServiceCode, Is.Zero);
                Assert.That(dto.Message, Is.EqualTo("no error").IgnoreCase);
                Assert.That(dto.Description, Is.EqualTo("The operation has completed successfully.").IgnoreCase);
                Assert.That(dto.Solution, Is.EqualTo(string.Empty).IgnoreCase);
            }
        }
    }

    [Test]
    public void UnknownFailure()
    {
        ServiceCodeDictionary serviceCodeDictionary = new();
        ServiceCodeDefinitionDto? dto = serviceCodeDictionary.GetDefinition(1);

        Assert.That(dto, Is.Not.Null);
        if (dto != null)
        {
            using (Assert.EnterMultipleScope())
            {
                Assert.That(dto.ServiceCode, Is.EqualTo(1));
                Assert.That(dto.Message, Is.EqualTo("Unknown Failure").IgnoreCase);
                Assert.That(dto.Description, Is.EqualTo("No description.").IgnoreCase);
                Assert.That(dto.Solution, Is.EqualTo("Unknown.").IgnoreCase);
            }
        }
    }
}
