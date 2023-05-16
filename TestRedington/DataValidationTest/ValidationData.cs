namespace TestRedington.TestCombinWith;

static class ValidationData
{
    public static IEnumerable<object[]> TestValidData =>
        new List<object[]>
        {
            new object[]
            {
                "0.5",
                "1.5",
                "1",
                false
            },
            new object[]
            {
                "0.5",
                "0.2",
                "0",
                true
            },
            new object[]
            {
                "0.5",
                "1.2",
                "0",
                false
            },
            new object[]
            {
                "0.5",
                "0.2",
                "2",
                false
            },
            new object[]
            {
                "0.3",
                "0.2",
                "0",
                true
            }
        };
}
