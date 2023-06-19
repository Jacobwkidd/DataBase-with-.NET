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
    System.Console.WriteLine("1.)" + name);
}

System.Console.WriteLine("-------------------------");

var deptMoreThanOne = _basicDbService.GetDepartmentsWithMoreThanOneCourses();
foreach(string name in deptMoreThanOne){
    System.Console.WriteLine("2.) " + name);
}

System.Console.WriteLine("----------------------");

var studentsInCourse = _basicDbService.GetStudentsInCourse("Algebra");
System.Console.WriteLine("Students in course");
foreach(string name in studentsInCourse){
    System.Console.WriteLine("3.) " + name);
}

System.Console.WriteLine("----------------------");

var deptMostCourses = _basicDbService.GetDepartmentWithMostCourses();
foreach(char dept in deptMostCourses){
    System.Console.WriteLine("4.) " + dept);
}

System.Console.WriteLine("--------------------------");

var studsMoreThenFive = _basicDbService.GetStudentsEnrolledInMoreThanFiveCourses();
foreach(string stud in studsMoreThenFive){
    System.Console.WriteLine("5.) " + stud);
}

System.Console.WriteLine("------------------------");


var intruInDept = _basicDbService.GetInstructorsInDepartment("Computer Science");
foreach(string intru in intruInDept){
    System.Console.WriteLine("6.) " + intru);
}

System.Console.WriteLine("-------------------------");

var courseByInst = _basicDbService.GetCoursesByInstructor("John");
foreach(string course in courseByInst){
    System.Console.WriteLine("7.) " + course);
}
System.Console.WriteLine("------------------------------");


var studsWithNoCourse = _basicDbService.GetStudentsWithNoCourses();
foreach(string stud in studentsInCourse){
    System.Console.WriteLine("8.) " + stud);
}
System.Console.WriteLine("----------------------------");


var deptWithNoCourse = _basicDbService.GetDepartmentsWithNoCourses();
foreach(string dept in deptWithNoCourse){
    System.Console.WriteLine("9.) " + dept);
}
System.Console.WriteLine("------------------------------");

var IntruWithMostCourses = _basicDbService.GetInstructorWithMostCourses();
foreach(char intru in IntruWithMostCourses){
    System.Console.WriteLine("10.) " + intru);
}



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

