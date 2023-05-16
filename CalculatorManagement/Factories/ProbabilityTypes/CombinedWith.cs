
namespace CalculatorManagement.Factories.ProbabilityTypes;

public class CombinedWith : ICalculator
{
    public decimal GetProbability(decimal firstProbability, decimal secondProbability) => 
        firstProbability * secondProbability;

}


