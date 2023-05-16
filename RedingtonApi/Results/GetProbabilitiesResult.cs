using RedingtonApi.Responses;
using RedingtonApi.Validators;
using OneOf;

namespace RedingtonApi.Queries
{
    [GenerateOneOf]
    public partial class GetProbabilitiesCalculationResult : 
        OneOfBase<GetProbabilitiesResponse, ValidationFailed>
    { }
}
