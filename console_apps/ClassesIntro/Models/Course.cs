using System.Text.Json.Serialization;
namespace ClassIntro.Models;

public class Course{
    public string Id {get; set;}
    public string Name {get; set;}
    [JsonPropertyName("Intstructor")]
    public Instructor CourseInstructors {get; set;}
}