namespace Tasko.Bll.Entities;

public class NoteItem
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public string? Content { get; set; }
    public string Status { get; set; } = "To Do";
    
    public DateTime CreatedAt { get; set; }
    public DateTime? DueDate { get; set; }
}