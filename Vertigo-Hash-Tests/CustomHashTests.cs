using Vertigo_Hash.Helpers;
namespace Vertigo_Hash_Tests;

public class CustomHashTests
{
  
    [Test]
    public void Test_Empty_String()
    {
        string value = "";

        long expectedHash = 0;

        long hash = CustomHash.Hash(value);

        Assert.That(hash, Is.EqualTo(expectedHash));
    }

    [Test]
    public void Test_Vertigo_String()
    {
        string value = "Vertigo";

        long expectedHash = 79325702176;

        long hash = CustomHash.Hash(value);

        Assert.That(hash, Is.EqualTo(expectedHash));
    }

    [Test]
    public void Test_Numbers_String()
    {
        string value = "12345";

        long expectedHash = 46792755;

        long hash = CustomHash.Hash(value);

        Assert.That(hash, Is.EqualTo(expectedHash));
    }
}
