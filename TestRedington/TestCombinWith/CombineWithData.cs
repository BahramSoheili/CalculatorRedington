namespace TestRedington.TestCombinWith;

static class CombineWithData
{
    public static IEnumerable<object[]> TestValidData =>
        new List<object[]>
        {
            new object[]
            {
                "0.5",
                "0.5",
                "0.25"
            },
            new object[]
            {
                "0.5",
                "0.2",
                "0.1"
            }
        };
}
