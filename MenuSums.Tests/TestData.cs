
namespace MenuSums.Tests
{
    // TODO: Brainstorm on how to specify a variety of test data in a possibly
    // more readable way.
    public static class TestData
    {
        public static string NoItems
        {
            get
            {
                return "[]";
            }
        }

        public static string NoMenuItems
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

        public static string AllLabelsPresent
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
                    ""id"": 10,
                    ""label"": ""Label 70""
                },
                {
                    ""id"": 20,
                    ""label"": ""Label 85""
                },
                {
                    ""id"": 30,
                    ""label"": ""Label 93""
                }
            ]
        }
    }
]";
            }
        }

        public static string AllLabelsNotPresent
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
                    ""id"": 10,
                    ""label"": ""Label 70""
                },
                {
                    ""id"": 20,
                    ""label"": ""Label 85""
                },
                {
                    ""id"": 30,
                    ""label"": ""Label 93""
                },
                {
                    ""id"": 40
                }
            ]
        }
    }
]";
            }
        }

        public static string WithTrailingCommas
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
                    ""id"": 10,
                    ""label"": ""Label 70"",
                },
                {
                    ""id"": 40,
                },
            ]
        }
    }
]";
            }
        }

        public static string NoMenuKey
        {
            get
            {
                return @"
[
    {
        ""emu"": {
            ""header"": ""menu"",
            ""items"": [
                {
                    ""id"": 10,
                    ""label"": ""Label 70""
                }
            ]
        }
    }
]";
            }
        }

        public static string NoMenuItemsKey
        {
            get
            {
                return @"
[
    {
        ""menu"": {
            ""header"": ""menu""
        }
    }
]";
            }
        }

        public static string FullDataSet
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
                {
                    ""id"": 85
                },
                {
                    ""id"": 54
                },
                null,
                {
                    ""id"": 46,
                    ""label"": ""Label 46""
                }
            ]
        }
    },
    {
        ""menu"": {
            ""header"": ""menu"",
            ""items"": [
                {
                    ""id"": 81
                }
            ]
        }
    },
    {
    ""menu"": {
        ""header"": ""menu"",
            ""items"": [
                {
                    ""id"": 70,
                    ""label"": ""Label 70""
                },
                {
                    ""id"": 85,
                    ""label"": ""Label 85""
                },
                {
                    ""id"": 93,
                    ""label"": ""Label 93""
                },
                {
                    ""id"": 2
                }
            ]
        }
    }
]";
            }
        }
    }
}
