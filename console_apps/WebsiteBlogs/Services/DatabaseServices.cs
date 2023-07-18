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
        public async Task UpdateUser(User user){
            var singleUser = await _context.User.FindAsync(user);
            singleUser.FirstName = newFirstName;
            singleUser.LastName = newLastName;
            await _context.SaveChangesAsync();
        }
        public async Task DeleteUser(int id){
            var user = await _context.User
                                          .SingleOrDefaultAsync(singleUser => singleUser.id == id);
            if(user != null){
                _context.User.Remove(user);
                await _context.SaveChangesAsync();
            }
        }
        public async Task AddBlog(Blog blog){
            _context.Blog.Add(blog);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateBlog(Blog blog){
            var singleBlog = await _context.Blog.FindAsync(blog);
            // have to ask for what I have to change
        }
        public async Task DeleteBlog(int id){
            var BlogId = await _context.Blog            
                                            .SingleOrDefaultAsync(blog => blog.id == id);
            if(BlogId != null){
                _context.Blog.Remove(BlogId);
                //save changes 
                await _context.SaveChangesAsync();
            }

        }
        public async Task AddPost(Post post){
            _context.Post.Add(post);
            await _context.SaveChangesAsync();
        }
        public async Task UpdatePost(Post post){

        }
        public async Task DeletePost(int id){
            var singlePost = await _context.Post    
                                                .SingleOrDefaultAsync(post => post.id == id);
            if(singlePost != null){
                _context.Post.Remove(singlePost);
                await _context.SaveChangesAsync();
            }
        }

}