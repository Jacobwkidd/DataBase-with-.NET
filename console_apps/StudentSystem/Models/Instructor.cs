using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace StudentSystem.Models;
public class Instructor
{
    [Key]
    public int Id { get; set; }
    
    public string FirstName {get; set;}
    public string LastName {get; set;}
    public DateTime JoiningDate { get; set; }
    // [InverseProperty("Instructor")]
    public virtual List<Course>? Courses { get; set; }
    [ForeignKey("Department")]
    public int? DepartmentId { get; set; }
    public virtual Department? Department { get; set; }
    public void AddCourse(Course course)
    {
        Console.WriteLine("Adding a course!");
    }
    public void RemoveCourse(Course course)
    {
        Console.WriteLine("Removing a course!");
    }
}