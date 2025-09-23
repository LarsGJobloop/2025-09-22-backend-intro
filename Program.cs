var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var todoList = new TodoList();

// Read all todoes
app.MapGet("/todo", () =>
{
  return todoList.GetAllTodoes();
});

// Create a new todo
app.MapPost("/todo", (TodoItemCreateInfo createInfo) =>
{
  var newTodoItem = todoList.CreateNewTodo(createInfo);

  return newTodoItem;
});

app.MapDelete("/todo/{todoId}", (string todoId) =>
{
  todoList.DeleteTodo(todoId);
});

app.Run();
