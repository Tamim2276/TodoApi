
using Microsoft.AspNetCore.Mvc;

// Controller handles all /todos routes
[ApiController]
[Route("todos")]
public class TodosController : ControllerBase
{
    // Static list so data persists across requests for the lifetime of the app.
    // Note: data resets when the app restarts. Use a database for real persistence.
    private static readonly List<Todo> todos = new List<Todo>
    {
        new Todo { Title = "1. First todo" }
    };

    // GET /todos — returns all todo items
    [HttpGet]
    public IActionResult GetTodos()
    {
        return Ok(todos);
    }

    // POST /todos/create — adds a new todo item
    // Expects JSON body: { "title": "your task" }
    [HttpPost("create")]
    public IActionResult CreateTodo(Todo todo)
    {
        // Reject empty or whitespace-only titles
        if (string.IsNullOrWhiteSpace(todo.Title))
        {
            return BadRequest("Title is required");
        }

        todos.Add(todo);
        return Created($"/todos/{todos.Count - 1}", todo);
    }
}

// Model representing a single todo item
public class Todo
{
    public string? Title { get; set; }
}