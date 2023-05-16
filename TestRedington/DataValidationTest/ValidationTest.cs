using CalculatorManagement.Dtos;
using FluentValidation;
using RedingtonApi.Validators;
using Xunit;

namespace TestRedington.TestCombinWith;

public class ValidationTest
{
    private readonly IValidator<ProbabilityDto> _probabilityValidator = new ProbabilityValidator();
    [Theory]
    [MemberData(nameof(CombineWithData.TestValidData), MemberType = typeof(ValidationData))]

    public async Task Should_Validate_Inputs
       (decimal firstProbability, decimal secondProbability,
        int probabilityType, bool valid)
    {
        var probabilityDto = new ProbabilityDto
        {
            FirstProbability = firstProbability,
            SecondProbability = secondProbability,
            ProbabilityType = probabilityType,
        };
        var validationResult = await _probabilityValidator.ValidateAsync(probabilityDto, new CancellationToken());
        Assert.Equal(validationResult.IsValid, valid);
    }

}