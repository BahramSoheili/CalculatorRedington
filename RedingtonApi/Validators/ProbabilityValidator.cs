using CalculatorManagement.Dtos;
using CalculatorManagement.Factories.ProbabilityTypes;
using FluentValidation;

namespace RedingtonApi.Validators;

public class ProbabilityValidator: AbstractValidator<ProbabilityDto>
{
    public ProbabilityValidator()
    {
        RuleFor(x => x.FirstProbability).ExclusiveBetween(0, 1);
        RuleFor(x => x.SecondProbability).ExclusiveBetween(0, 1);
        RuleFor(x => x.ProbabilityType).InclusiveBetween(0, ProbabilityEnum.List.Count-1);
    }
}
