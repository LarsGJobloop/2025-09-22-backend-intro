using System.Net;

var builder = WebApplication.CreateBuilder(args);

builder.WebHost.ConfigureKestrel(serverOptions =>
{
  serverOptions.Listen(IPAddress.Loopback, 5001, listenOptions =>
  {
    listenOptions.UseHttps("cert.pfx", "yourpassword");
  });
});

builder.Services.AddSingleton<FileStorageService>();
builder.Services.AddSingleton<TodoList>();

var app = builder.Build();

// Router definitions (Mappings)

// Read all todoes
app.MapGet("/todo", (TodoList todoList) =>
{
  return todoList.GetAllTodoes();
});

// Create a new todo
app.MapPost("/todo", (TodoList todoList, TodoItemCreateInfo createInfo) =>
{
  var newTodoItem = todoList.CreateNewTodo(createInfo);

  return newTodoItem;
});

app.MapDelete("/todo/{todoId}", (TodoList todoList, string todoId) =>
{
  todoList.DeleteTodo(todoId);
});

app.Run();
