using CalculatorManagement.Dtos;
using CalculatorManagement.Factories.ProbabilityTypes;
using CalculatorManagement.Factories;
using FluentValidation;
using MediatR;
using RedingtonApi.Validators;
using RedingtonApi.Responses;

namespace RedingtonApi.Queries;

public record GetProbabilitiesQuery(ProbabilityDto probabilityDto) : 
    IRequest<GetProbabilitiesCalculationResult>;

public class ProbabilitiesQueryHandler :
    IRequestHandler<GetProbabilitiesQuery, GetProbabilitiesCalculationResult>
{
    private readonly IValidator<ProbabilityDto> _probabilityValidator;
    public ProbabilitiesQueryHandler(IValidator<ProbabilityDto> probabilityValidator)
    {
        _probabilityValidator = probabilityValidator;
    }
    public async Task<GetProbabilitiesCalculationResult> Handle(GetProbabilitiesQuery request, CancellationToken cancellationToken)
    {
        var validationResult = await _probabilityValidator.ValidateAsync(request.probabilityDto, cancellationToken);
        if (!validationResult.IsValid)
        {
            return new ValidationFailed(validationResult.Errors);
        }
        return GetProbabilitiesResponse
            .CreateResponse(ProbabilityFactory
            .CreateInstance(ProbabilityEnum.FromValue(request.probabilityDto.ProbabilityType))
            .GetProbability(request.probabilityDto.FirstProbability, request.probabilityDto.SecondProbability));
    }
 }


