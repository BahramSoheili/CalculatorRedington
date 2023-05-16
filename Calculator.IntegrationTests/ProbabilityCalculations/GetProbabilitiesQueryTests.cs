using Core.Events;
using Core.Testing;
using FluentAssertions;
using MeetingsSearch.Meetings;
using MeetingsSearch.Meetings.CreatingMeeting;
using Xunit;
using Ogooreck.API;
using static Ogooreck.API.ApiSpecification;
using CalculatorManagement.Dtos;

namespace Calculator.IntegrationTests.ProbabilityCalculations;

public class GetProbabilitiesQueryTests : IClassFixture<TestWebApplicationFactory<Program>>
{
    private readonly ApiSpecification<Program> API;
    private readonly TestWebApplicationFactory<Program> fixture;

    public CreateMeetingTests(TestWebApplicationFactory<Program> fixture)
    {
        this.fixture = fixture;
        API = ApiSpecification<Program>.Setup(fixture);
    }

    [Fact]
    [Trait("Category", "Acceptance")]
    public Task CreateCommand_ShouldPublish_MeetingCreateEvent() =>
        API.Given(
                URI(GetProbabilityApi.ProbabilitiesUrl),
                BODY(new ProbabilityDto(0.5, 0.5, 0))
            )
            .When(POST)
            .Then(CREATED_WITH_DEFAULT_HEADERS(eTag: 1));
}
