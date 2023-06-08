using StudentSystem.Models;
using StudentSystem.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;


public class DatabaseService{
    private ApplicationDbContext _context;

    public DatabaseService(ApplicationDbContext context){
        this._context = context;

    }

    public List<Student> GetAll(){
        return _context.Instructors.Include(s => s.Courses).ToList();
                                // .Include(instructor => instructor.Department.Courses)
                                // .FirstOrDefault();
    }
}