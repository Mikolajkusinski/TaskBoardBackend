namespace TaskBoard.Entities;

public class User
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string email { get; set; }
    public Address Address { get; set; }
    public List<WorkItem> WorkItems { get; set; } = new List<WorkItem>();
}
