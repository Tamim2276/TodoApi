# TodoApi

A minimal REST API built with **ASP.NET Core 10** (.NET 10) for managing todo items.

## Tech Stack

- [.NET 10](https://dotnet.microsoft.com/)
- ASP.NET Core Minimal API
- Microsoft.AspNetCore.OpenApi

## Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)

## Getting Started

### Clone the repository

```bash
git clone https://github.com/tam1m/TodoApi.git
cd TodoApi
```

### Run the application

```bash
dotnet run
```

The API will start on `http://localhost:5207` by default.

## API Endpoints

| Method | Endpoint | Description            |
| ------ | -------- | ---------------------- |
| GET    | `/todos` | Get all todo items     |
| POST   | `/todo`  | Create a new todo item |

### GET /todos

Returns a list of all todo items.

**Response:**

```json
[{ "title": "1. First todo" }]
```

### POST /todo

Creates a new todo item.

**Request body:**

```json
{
  "title": "My new task"
}
```

**Responses:**

- `201 Created` — Todo was added successfully
- `400 Bad Request` — Title is missing or empty

## Project Structure

```
TodoApi/
├── Program.cs               # App entry point and route definitions
├── TodoApi.csproj           # Project configuration
├── appsettings.json         # Application settings
├── appsettings.Development.json
└── Properties/
    └── launchSettings.json  # Launch profiles
```

## License

This project is open source and available under the [MIT License](LICENSE).
