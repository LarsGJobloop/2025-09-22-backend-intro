var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Read all todoes
app.MapGet("/todo", () =>
{
  return "Returning all Todos!";
});

// Create a new todo
app.MapPost("/todo", () =>
{
  var newTodoItem = new TodoItem("This is a task", DateTime.Today);

  return newTodoItem;
});


app.Run();
