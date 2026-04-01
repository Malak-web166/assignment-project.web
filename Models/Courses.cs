namespace WebApplication1.Models;

public class Course
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public int InstructorId { get; set; } // Foreign Key
    public Instructor? Instructor { get; set; }
}
