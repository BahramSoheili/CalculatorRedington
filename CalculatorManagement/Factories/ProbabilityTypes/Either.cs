
namespace CalculatorManagement.Factories.ProbabilityTypes;

public class Either : ICalculator
{
    public decimal GetProbability(decimal firstProbability, decimal secondProbability) =>
        firstProbability + secondProbability - firstProbability * secondProbability;
}
