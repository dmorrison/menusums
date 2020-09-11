# Menu Sums

My solution to the UTIMCO coding exercise.

# Description

Processes a JSON file containing menu data and sums up menu item ids.

# Requirements

.NET Core SDK 3.1 or higher is required.

**Note**: This project was tested on macOS Catalina and Windows 10 using .NET Core SDK 3.1.

# Running the App

- Download/clone the repository.
- `cd MenuSums`
- `dotnet run --project MenuSums <path to JSON file>`

# Running the Tests

- Download/clone the repository.
- `cd MenuSums`
- `dotnet test`

# Example Test Data

Given a file containing the following JSON:

```json
[
    {
        "menu": {
            "header": "menu",
            "items": [
                {
                    "id": 27
                },
                {
                    "id": 0,
                    "label": "Label 0"
                },
                null,
                {
                    "id": 93
                },
                {
                    "id": 85
                },
                {
                    "id": 54
                },
                null,
                {
                    "id": 46,
                    "label": "Label 46"
                }
            ]
        }
    },
    {
        "menu": {
            "header": "menu",
            "items": [
                {
                    "id": 81
                }
            ]
        }
    },
    {
        "menu": {
            "header": "menu",
            "items": [
                {
                    "id": 70,
                    "label": "Label 70"
                },
                {
                    "id": 85,
                    "label": "Label 85"
                },
                {
                    "id": 93,
                    "label": "Label 93"
                },
                {
                    "id": 2
                }
            ]
        }
    }
]
```

...the app will return:
```
46
0
248
```
