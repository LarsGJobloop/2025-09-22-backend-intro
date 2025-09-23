// This is in essence the JSON object the client (frontend)
// needs to send us
class TodoItemCreateInfo
{
  public required string Description { get; set; }
  public DateTime Deadline { get; set; }
}
