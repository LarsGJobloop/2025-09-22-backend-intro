class TodoItem
{
  // Properties / Egenskaper
  public string Description { get; set; }
  public bool IsComplete { get; set; }
  public DateTime Deadline { get; set; }
  public DateTime CreatedAt { get; set; }

  // Constructor / Beskrivelse av hvordan lage denne klasse
  public TodoItem(string description, DateTime deadline)
  {
    IsComplete = false;
    CreatedAt = DateTime.Now;
    Description = description;
    Deadline = deadline;
  }
}