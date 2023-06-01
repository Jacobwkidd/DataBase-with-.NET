using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace StudentSystem.Models;
public class Department
{
    [Key]
    public int Id { get; set; }
    [ForeignKey("DepartmentHead")]
    public int? DepartmentHeadId { get; set; }
    public virtual Instructor? DepartmentHead { get; set; }
    public string DeptName {get; set;}
    public virtual List<Course>? Courses { get; set; }
}