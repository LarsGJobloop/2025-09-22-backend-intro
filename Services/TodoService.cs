class TodoList
{
  // Properties
  public List<TodoItem> TodoItems;

  // How to create a new instance
  public TodoList()
  {
    TodoItems = new List<TodoItem>();
  }

  // Methods, what we can do with this thing
  public List<TodoItem> GetAllTodoes()
  {
    return TodoItems;
  }

  public TodoItem CreateNewTodo(TodoItemCreateInfo createInfo)
  {
    var newTodoItem = new TodoItem(createInfo.Description, createInfo.Deadline);

    TodoItems.Add(newTodoItem);

    return newTodoItem;
  }

  public void DeleteTodo(string todoId)
  {
    var foundTodo = TodoItems
      .Find(todo => todo.Id.ToString() == todoId);

    TodoItems.Remove(foundTodo);
  }
}
