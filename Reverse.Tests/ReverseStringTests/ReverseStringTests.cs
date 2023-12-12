using FluentAssertions;
using Reverse;

namespace Reverse.Tests.ReverseStringTests;

public class ReverseStringTests : IClassFixture<ReverseStringFixture>
{
    private readonly ReverseStringFixture _fixture;
    public ReverseStringTests(ReverseStringFixture fixture)
    {
        _fixture = fixture;
    }

    [Fact]
    public void ReverseString_TestWithStringBuilder()
    {
        //Act
        var reverseWithStrBuilder = _fixture.RandomString.ReverseStringWithStringBuilder();
        //Assert
        reverseWithStrBuilder.Should().Be(_fixture.ReverseFromFramework);
    }

    [Fact]
    public void ReverseString_TestWithSpan()
    {
        //Act
        var reverseWithSpan = _fixture.RandomString.ReverseStringOptimized();
        //Assert
        reverseWithSpan.Should().Be(_fixture.ReverseFromFramework);
    }
}