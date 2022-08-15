using FluentAssertions;
using Xunit;

namespace Simple.Tests;

public class SimpleFixture
{
    Simple simple = new();
    
    [Theory]
    [InlineData(0, 0)]
    [InlineData(5, 55)]
    public void CalculatesSumOfSquares(int input, int expected)
    {
        simple.SumOfSquares(input).Should().Be(expected);
    }
}
