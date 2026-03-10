# TodoApi

A minimal REST API built with **ASP.NET Core 10** (.NET 10) for managing todo items.

## Tech Stack

- [.NET 10](https://dotnet.microsoft.com/)
- ASP.NET Core Web API (Controller-based)
- Microsoft.AspNetCore.OpenApi

## Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)

## Getting Started

### Clone the repository

```bash
git clone https://github.com/Tamim2276/TodoApi.git
cd TodoApi
```

### Run the application

```bash
dotnet run
```

The API will start on `http://localhost:5207` by default.

## API Endpoints

| Method | Endpoint        | Description            |
| ------ | --------------- | ---------------------- |
| GET    | `/todos`        | Get all todo items     |
| POST   | `/todos/create` | Create a new todo item |

### GET /todos

Returns a list of all todo items.

**Response:**

```json
[{ "title": "1. First todo" }]
```

### POST /todos/create

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
├── Program.cs                    # App entry point, service registration
├── TodosController.cs            # Controller with GET and POST endpoints
├── TodoApi.csproj                # Project configuration
├── appsettings.json              # Application settings
├── appsettings.Development.json  # Development-specific settings
├── todo.http                     # HTTP request samples for testing
└── Properties/
    └── launchSettings.json       # Launch profiles (port, env)
```

## Notes

- Todo data is stored **in memory** and resets when the app restarts.
- For persistent storage, connect a database (e.g. SQLite, SQL Server) via Entity Framework Core.

## License

This project is open source and available under the [MIT License](LICENSE).
