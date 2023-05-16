using CalculatorManagement.Factories;
using CalculatorManagement.Factories.ProbabilityTypes;
using Xunit;

namespace TestRedington.TestEither;

public class TestEither
{
    private readonly ICalculator either = new Either();
    [Theory]
    [MemberData(nameof(EitherData.TestData), MemberType = typeof(EitherData))]
    public void Should_calculate_Either_When_inputs_valid
        (decimal firstProbability, decimal secondProbability, decimal expectedProbability)
    {
        var probability = either.GetProbability(firstProbability, secondProbability);
        Assert.Equal(probability, expectedProbability);
    }
}