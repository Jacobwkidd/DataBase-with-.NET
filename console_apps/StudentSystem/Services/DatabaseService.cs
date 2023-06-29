using StudentSystem.Models;
using StudentSystem.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace StudentSystem.Services;
public class DatabaseService{
    private ApplicationDbContext _context;

    public DatabaseService(ApplicationDbContext context){
        this._context = context;

    }

//     public List<Student> GetAll(){
        
//         return //_context.Instructors.Include(s => s.Courses).ToList();
//                                 // .Include(instructor => instructor.Department.Courses)
//                                 // .FirstOrDefault();
//     }

    public Student? GetStudentByIdSync(int id){
        return _context.Students
                                .SingleOrDefault(s => s.Id == id);
    }

    //Async
    public async Task<Student?> GetStudentById(int id){
        return await _context.Students
                                .Include(student => student.Courses)
                                .SingleOrDefaultAsync(student => student.Id == id);
    }

    public async Task<Instructor?> GetInstructorById(int id){
        return await _context.Instructors
                                    .Include(instr => instr.Department)
                                    .SingleOrDefaultAsync(instr => instr.Id == id);
    }

    public async Task<List<Course>> GetAllCourseWithStudents(){
        return await _context.Courses
                                .Include(courses => courses.Students)
                                .ToListAsync();
    }

    public async Task AddStudent(Student student){
        _context.Students.Add(student);
        //save to database =>
        await  _context.SaveChangesAsync();
    }

    public async Task UpdateStudentName(int studentId, string newFirstName, string newLastName){
        // find the student 
        var student = await _context.Students.FindAsync(studentId); 
        //update the name   
        student.FirstName = newFirstName;
        student.LastName = newLastName;
        //save the changes.
        await _context.SaveChangesAsync();
    }

    public async Task DeleteStudent(int studentId){
        // find the student
        var student = await _context.Students
                                    .SingleOrDefaultAsync(stud => stud.Id == studentId);
        //if the student was found, then delete
        if(student != null){
            //then a student was found
            _context.Students.Remove(student);
            //save the changes
            await _context.SaveChangesAsync();
        }
    }   

    public async Task EnrollStudentInCourse(int studentId, int courseId){
        // get the student 
        var student = await _context.Students
                                .SingleOrDefaultAsync(stud => stud.Id == studentId);
        // get course
        var course = await _context.Courses
                                    .Include(course => course.Students)
                                    .SingleOrDefaultAsync(course => course.Id == courseId);
        // update the models
        if(student != null && course != null){
            course.Students.Add(student);
            // save the changes
            await _context.SaveChangesAsync();
        }
        


    }


}