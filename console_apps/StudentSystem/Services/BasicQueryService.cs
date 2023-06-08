using StudentSystem.Models;
using StudentSystem.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;


public class BasicQueryServices{
    private ApplicationDbContext _context;

    public BasicQueryServices(ApplicationDbContext context){
        this._context = context;

    }

    public List<string> GetAllInstructorNames(){
        return _context.Instructors.Select(indivInstructor => indivInstructor.LastName).ToList();
    }

    public List<string> GetStudentsInCourse(string courseName){
        return _context.Courses
                                .Where(course => course.CourseName == courseName)
                                .SelectMany(course => course.Students) //
                                .Select(student => student.LastName)
                                .ToList();
        //   var finalResult = new List<String>();
        //   foreach(Course course in result){
        //     foreach(Student stud in course.Students){
        //         finalResult.Add(stud.LastName);
        //     }
        //   }                      
    }


    public List<string> GetDepartmentsWithMoreThanOneCourses(){
        return _context.Departments
                                    .Where(dept => dept.Courses.Count > 0)
                                    .Select(dept => dept.DeptName)
                                    //.Select(course => course.CourseName)
                                    .ToList();
    }


}