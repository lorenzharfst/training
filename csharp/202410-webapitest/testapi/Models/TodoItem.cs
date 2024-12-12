namespace Models;

public class TodoItem
{
	// Id servers as the unique key in the DB
	public long Id { get; set; }
	public string? Name { get; set; }
	public bool IsComplete { get; set; }
}
