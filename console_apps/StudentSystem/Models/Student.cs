using System.ComponentModel.DataAnnotations;
namespace StudentSystem.Models;
public class Student
{
    [Key]
    public int Id { get; set; }
    public string FirstName {get; set;}
    public string LastName {get; set;}
    public DateTime JoiningDate { get; set; }
    public virtual List<Course>? Courses { get; set; }
    public void EnrollInCourse(Course course)
    {
        Console.WriteLine("Enrolling in a course!");
    }
    public void DropCourse(Course course)
    {
        Console.WriteLine("Dropping a course!");
    }
}