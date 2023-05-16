
using CalculatorManagement.Factories.ProbabilityTypes;

namespace CalculatorManagement.Factories;

public class ProbabilityFactory
{
    public static ICalculator CreateInstance(ProbabilityEnum probabilityEnum)
    {
        return probabilityEnum.Name switch
        {
            "CombinedWith" => new CombinedWith(),
            "Either" => new Either(),
            _ => throw new NotImplementedException()
        };
    }
}
