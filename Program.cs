var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var todoList = new TodoList();

// Read all todoes
app.MapGet("/todo", () =>
{
  return todoList.TodoItems;
});

// Create a new todo
app.MapPost("/todo", (TodoItemCreateInfo createInfo) =>
{
  var newTodoItem = new TodoItem(createInfo.Description, createInfo.Deadline);

  todoList.TodoItems.Add(newTodoItem);

  return newTodoItem;
});


app.Run();
