using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace StudentSystem.Models;
public class Course
{
    [Key]
    public int Id { get; set; }
    public string Subject { get; set; }
    public string CourseName {get; set;}
    [ForeignKey("Instructor")]
    public int? InstructorId { get; set; }
    public virtual Instructor? Instructor { get; set; }
    [ForeignKey("Department")]
    public int? DepartmentId { get; set; }
    public virtual Department? Department { get; set; }
    public virtual List<Student>? Students { get; set; }
}