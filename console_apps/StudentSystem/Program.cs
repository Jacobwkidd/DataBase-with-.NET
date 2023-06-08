using Microsoft.Extensions.DependencyInjection;
using StudentSystem.Models;
using StudentSystem.Data;
using System;
using System.Collections.Generic;

ServiceProvider _serviceProvider;
//DatabaseService _dbService;
BasicQueryServices _basicDbService;

var services = new ServiceCollection();

services.AddDbContext<ApplicationDbContext>();
services.AddScoped<BasicQueryServices>();

_serviceProvider = services.BuildServiceProvider();
_basicDbService = _serviceProvider.GetRequiredService<BasicQueryServices>();

var instructorNames = _basicDbService.GetAllInstructorNames();
foreach(string name in instructorNames){
    System.Console.WriteLine(name);
}

var studentsInCourse = _basicDbService.GetStudentsInCourse("Algebra");
System.Console.WriteLine("Students in course");
foreach(string name in studentsInCourse){
    System.Console.WriteLine(name);
}
_serviceProvider.Dispose();

