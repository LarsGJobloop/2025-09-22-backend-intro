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

app.MapDelete("/todo/{todoId}", (string todoId) =>
{
  var foundTodo = todoList.TodoItems
    .Find(todo => todo.Id.ToString() == todoId);

  todoList.TodoItems.Remove(foundTodo);

  return foundTodo;
});


app.Run();
