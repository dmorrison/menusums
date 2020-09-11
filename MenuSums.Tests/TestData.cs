
namespace MenuSums.Tests
{
    // TODO: Brainstorm on how to specify a variety of test data in a (possibly)
    // more readable way.
    public static class TestData
    {
        public static string NoItems
        {
            get
            {
                return @"
[
    {
        ""menu"": {
            ""header"": ""menu"",
            ""items"": []
        }
    }
]";
            }
        }

        public static string WithNulls
        {
            get
            {
                return @"
[
    {
        ""menu"": {
            ""header"": ""menu"",
            ""items"": [
                {
                    ""id"": 27
                },
                {
                    ""id"": 0,
                    ""label"": ""Label 0""
                },
                null,
                {
                    ""id"": 93
                },
                null,
                {
                    ""id"": 46,
                    ""label"": ""Label 46""
                }
            ]
        }
    }
]";
            }
        }
    }
}
