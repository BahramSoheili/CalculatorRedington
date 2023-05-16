namespace TestRedington.TestEither;

static class EitherData
{
    public static IEnumerable<object[]> TestData =>
        new List<object[]>
        {
            new object[]
            {
                "0.5",
                "0.5",
                "0.75"
            },
            new object[]
            {
                "0.5",
                "0.2",
                "0.6"
            }
        };
}
