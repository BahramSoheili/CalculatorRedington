using CalculatorManagement.Factories;
using CalculatorManagement.Factories.ProbabilityTypes;
using Xunit;

namespace TestRedington.TestCombinWith;

public class TestCombineWith
{
    private readonly ICalculator combinedWith = new CombinedWith();
    [Theory]
    [MemberData(nameof(CombineWithData.TestValidData), MemberType = typeof(CombineWithData))]
    public void Should_calculate_CombineWith_When_inputs_valid
        (decimal firstProbability, decimal secondProbability, decimal expectedProbability)
    {
        var probability = combinedWith.GetProbability(firstProbability, secondProbability);
        Assert.Equal(probability, expectedProbability);
    }
}