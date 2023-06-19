using Microsoft.Extensions.DependencyInjection;
using StudentSystem.Models;
using StudentSystem.Data;
using System;
using System.Collections.Generic;
using StudentSystem.Services;

ServiceProvider _serviceProvider;
DatabaseService _dbService;
BasicQueryServices _basicDbService;

var services = new ServiceCollection();

services.AddDbContext<ApplicationDbContext>();
services.AddScoped<BasicQueryServices>();
services.AddScoped<DatabaseService>();

_serviceProvider = services.BuildServiceProvider();
_basicDbService = _serviceProvider.GetRequiredService<BasicQueryServices>();
_dbService = _serviceProvider.GetRequiredService<DatabaseService>();

var instructorNames = _basicDbService.GetAllInstructorNames();
 foreach(string name in instructorNames){
    System.Console.WriteLine(name);
}



var deptMoreThanOne = _basicDbService.GetDepartmentsWithMoreThanOneCourses();
// var studentsInCourse = _basicDbService.GetStudentsInCourse("Algebra");
// System.Console.WriteLine("Students in course");
// foreach(string name in studentsInCourse){
//     System.Console.WriteLine(name);
// }



var deptMostCourses = _basicDbService.GetDepartmentWithMostCourses();
var studsMoreThenFive = _basicDbService.GetStudentsEnrolledInMoreThanFiveCourses();
var intruInDept = _basicDbService.GetInstructorsInDepartment();




var courseByInst = _basicDbService.GetCoursesByInstructor();
var studsWithNoCourse = _basicDbService.GetStudentsWithNoCourses();
var deptWithNoCourse = _basicDbService.GetDepartmentsWithNoCourses();
var IntruWithMostCourses = _basicDbService.GetInstructorWithMostCourses();




////////////////=--------------------       Database Start

System.Console.WriteLine("____________________________________________ Start of Database Service");
var intialStud = await _dbService.GetStudentById(1);
System.Console.WriteLine(intialStud);

System.Console.WriteLine(intialStud.Courses[0].CourseName);

var instr = await _dbService.GetInstructorById(1);


System.Console.WriteLine("--------------------");
System.Console.WriteLine("--------------------");
System.Console.WriteLine(instr.LastName);
System.Console.WriteLine(instr.Department.DeptName);


_serviceProvider.Dispose();

