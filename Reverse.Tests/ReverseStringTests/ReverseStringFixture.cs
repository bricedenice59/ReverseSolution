using Reverse;

namespace Reverse.Tests.ReverseStringTests;

public class ReverseStringFixture : IDisposable
{
    public string RandomString;
    public string ReverseFromFramework;

    public ReverseStringFixture()
    {
        RandomString = Utils.GenerateRandomAlphanumericString(1_000_000);
        ReverseFromFramework = new string(RandomString.Reverse().ToArray());
    }

    public void Dispose()
    {
        RandomString = null;
        ReverseFromFramework = null;
    }
}