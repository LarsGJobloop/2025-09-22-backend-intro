var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Read all todoes
app.MapGet("/todo", () =>
{
  return "Returning all Todos!";
});

// Create a new todo
app.MapPost("/todo", (TodoItemCreateInfo createInfo) =>
{
  var newTodoItem = new TodoItem(createInfo.Description, createInfo.Deadline);

  return newTodoItem;
});


app.Run();
