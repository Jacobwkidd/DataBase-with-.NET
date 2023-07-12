using WebsiteBlogs.Models;
using WebsiteBlogs.Interfaces;
using WebsiteBlogs.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebsiteBlogs.Services;

public class DatabaseService : IDatabaseService
{
    private ApplicationDbContext _context;

    public DatabaseService(ApplicationDbContext context)
    {
        _context = context;
    }
		
		/*
			TODO: Implement the IDatabaseService interface.
		*/

        public async Task<List<User>> GetAllUsers(){
            return await _context.Users
                                .ToListAsync();
        }
        public async Task<List<Blog>> GetAllBlogs(){
            return await _context.Blogs
                                      .ToListAsync();
        }
        public async Task<List<Post>> GetAllPosts(){
            return await _context.Posts
                                       .ToListAsync();
        }
        public async Task<User?> GetUserById(int id){
            return await _context.Users
                                       .Include(user => user.Id == id)
                                       .SingleOrDefaultAsync(user => user.Id == id);
        }
        public async Task AddUser(User user){
            await _context.Users.Add(user);
                                       
                                       
            await _context.SaveChangesAsync();
        }
}