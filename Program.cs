var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

////
///////Minimal API
// var todos = new List<Todo>
// {
//     new Todo { Title = "1. First todo" }
// };

// app.MapGet("/todos",(HttpContext context) =>
// {
//     return Results.Ok(todos);   
// });

// app.MapPost("/todo", (Todo todo) =>
// {
//     if (string.IsNullOrWhiteSpace(todo.Title))
//     {
//         return Results.BadRequest("Title is required");
//     } 

//     todos.Add(todo);
//     return Results.Created($"/todos/${todos.Count -1}",todo);
// });

app.Run();


class Todo
{
    public string? Title { get; set; }
}