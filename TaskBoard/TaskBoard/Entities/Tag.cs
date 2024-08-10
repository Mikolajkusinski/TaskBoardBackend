namespace TaskBoard.Entities;

public class Tag
{
    public string Value { get; set; }
    public User Author { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? ModifiedDate { get; set; }
}
