using GAAPICommon.Messages;
using NUnit.Framework;

namespace GAServiceCodes.Test;

[TestFixture]
public class TServiceCodeDictionary
{
    [Test]
    public void NoError()
    {
        ServiceCodeDictionary serviceCodeDictionary = new();
        ServiceCodeDefinitionDto? dto = serviceCodeDictionary.GetDefinition(0);

        Assert.That(dto, Is.Not.Null);

        Assert.That(dto.ServiceCode, Is.EqualTo(0));
        Assert.That(dto.Message, Is.EqualTo("no error").IgnoreCase);
        Assert.That(dto.Description, Is.EqualTo("The operation has completed successfully.").IgnoreCase);
        Assert.That(dto.Solution, Is.EqualTo(string.Empty).IgnoreCase);
    }

    [Test]
    public void UnknownFailure()
    {
        ServiceCodeDictionary serviceCodeDictionary = new();
        ServiceCodeDefinitionDto? dto = serviceCodeDictionary.GetDefinition(1);

        Assert.That(dto, Is.Not.Null);

        Assert.That(dto.ServiceCode, Is.EqualTo(1));
        Assert.That(dto.Message, Is.EqualTo("Unknown Failure").IgnoreCase);
        Assert.That(dto.Description, Is.EqualTo("No description.").IgnoreCase);
        Assert.That(dto.Solution, Is.EqualTo("Unknown.").IgnoreCase);
    }
}