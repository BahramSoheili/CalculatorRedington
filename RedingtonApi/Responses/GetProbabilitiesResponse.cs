namespace RedingtonApi.Responses;

public class GetProbabilitiesResponse
{

    public ProbabilitiesResponse Probability { get; set;}     
    public static GetProbabilitiesResponse CreateResponse(decimal probability)
    {
        return new GetProbabilitiesResponse
        {
            Probability = new ProbabilitiesResponse(probability)
        };           
    } 
    public record struct ProbabilitiesResponse(decimal Probability);
}