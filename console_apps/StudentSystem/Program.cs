using StudentSystem.Models;
using StudentSystem.Data;
using System;
using System.Collections.Generic;
namespace StudentSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            using (var context = new ApplicationDbContext())
            {
                // // Create instructors
                var instructors = new List<Instructor>
                {
                    new Instructor { FirstName = "John", LastName = "Doe", JoiningDate = DateTime.Now },
                    new Instructor { FirstName = "Jane", LastName = "Smith", JoiningDate = DateTime.Now },
                    new Instructor { FirstName = "Michael", LastName = "Johnson", JoiningDate = DateTime.Now },
                    new Instructor { FirstName = "Emily", LastName = "Brown", JoiningDate = DateTime.Now },
                    new Instructor { FirstName = "David", LastName = "Wilson", JoiningDate = DateTime.Now }
                };
                // Create departments
                var departments = new List<Department>
                {
                    new Department { DeptName = "Computer Science" },
                    new Department { DeptName = "Physics" },
                    new Department { DeptName = "Mathematics" },
                    new Department { DeptName = "History" },
                    new Department { DeptName = "English" }
                };
                // Create courses
                var courses = new List<Course>
                {
                    new Course { Subject = "Programming", CourseName = "Introduction to Programming", Instructor = instructors[0], Department = departments[0] },
                    new Course { Subject = "Physics", CourseName = "Mechanics", Instructor = instructors[1], Department = departments[1] },
                    new Course { Subject = "Math", CourseName = "Algebra", Instructor = instructors[2], Department = departments[2] },
                    new Course { Subject = "History", CourseName = "World History", Instructor = instructors[3], Department = departments[3] },
                    new Course { Subject = "English", CourseName = "Literature", Instructor = instructors[4], Department = departments[4] }
                };
                // Create students
                var students = new List<Student>
                {
                    new Student { FirstName = "Alice", LastName = "Johnson", JoiningDate = DateTime.Now },
                    new Student { FirstName = "Bob", LastName = "Smith", JoiningDate = DateTime.Now },
                    new Student { FirstName = "Emma", LastName = "Davis", JoiningDate = DateTime.Now },
                    new Student { FirstName = "Daniel", LastName = "Anderson", JoiningDate = DateTime.Now },
                    new Student { FirstName = "Olivia", LastName = "Wilson", JoiningDate = DateTime.Now }
                };
                // Associate students with courses
                courses[0].Students = new List<Student> { students[0], students[1], students[2] };
                courses[1].Students = new List<Student> { students[1], students[3] };
                courses[2].Students = new List<Student> { students[0], students[2], students[4] };
                courses[3].Students = new List<Student> { students[3], students[4] };
                courses[4].Students = new List<Student> { students[0], students[1], students[3], students[4] };
                // Associate courses with students
                students[0].Courses = new List<Course> { courses[0], courses[2], courses[4] };
                students[1].Courses = new List<Course> { courses[0], courses[4] };
                students[2].Courses = new List<Course> { courses[0], courses[2] };
                students[3].Courses = new List<Course> { courses[1], courses[3], courses[4] };
                students[4].Courses = new List<Course> { courses[2], courses[3], courses[4] };
                // Add entities to the context and save changes
                context.Instructors.AddRange(instructors);
                context.Departments.AddRange(departments);
                context.Courses.AddRange(courses);
                context.Students.AddRange(students);
                context.SaveChanges();
                // Associate instructors with departments
                for (int i = 0; i < instructors.Count; i++)
                {
                    instructors[i].Department = departments[i];
                }
                context.SaveChanges();
                // Associate instructors with departments
                for (int i = 0; i < instructors.Count; i++)
                {
                    departments[i].DepartmentHead = instructors[i];                    
                }
                context.SaveChanges();
            }
        }
    }
}