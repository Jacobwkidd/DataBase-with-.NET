using StudentSystem.Models;
using StudentSystem.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace StudentSystem.Services;

//install dotnet windows 10 && commands in notion -- don't use this
// then dotnet build

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

    public string GetDepartmentWithMostCourses(){
        return _context.Departments // or OrderByDescending(dept => dept.Courses.Count == 0) maybe group by it too
                                    .OrderByDescending(dept => dept.Courses.Count)
                                    .Select(dept => dept.DeptName)
                                    .First();
    }

    public List<string> GetStudentsEnrolledInMoreThanFiveCourses(){
        return _context.Students
                                .Where(Stud => Stud.Courses.Count > 5)
                                .Select(stud => stud.FirstName)
                                .ToList();
    }

    public List<string> GetInstructorsInDepartment(string departmentName){
        return _context.Departments
                                    .Where(dept => dept.DeptName == departmentName)
                                    .SelectMany(dept => dept.Courses
                                                        .Select(course => course.Instructor.LastName)
                                    )
                                    .Distinct()
                                    .ToList();

                                    //Another way of doing this
                                    //.SelectMany(dept => dept.Courses)
                                    //.Select(course => course.Instructor.LastName)
    }


    public List<string> GetCoursesByInstructor(string instructorName){
            return _context.Instructors
                                .Where(Intru => Intru.FirstName == instructorName)
                                .SelectMany(instructor => instructor.Courses)
                                .Select(course => course.CourseName)
                                .ToList();
    }

    public List<string> GetStudentsWithNoCourses(){
        return _context.Students 
                                .OrderByDescending(studCourse => studCourse.Courses.Count < 0)                           
                                .Select(studCourse => studCourse.FirstName)
                                .ToList();
    }

    public List<string> GetDepartmentsWithNoCourses(){
        return _context.Departments
                                    .OrderByDescending(dept => dept.Courses.Count < 0)
                                    .Select(dept => dept.DeptName)
                                    .ToList();
    }

    public string GetInstructorWithMostCourses(){
        return _context.Instructors
                                  .OrderByDescending(instru => instru.Courses.Count)
                                  .Select(instru => instru.FirstName)
                                  .First();
    }




}