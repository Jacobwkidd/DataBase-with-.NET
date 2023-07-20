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
                                       .SingleOrDefaultAsync(user => user.Id == id);
        }
        public async Task AddUser(User user){
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateUser(int Id, string newFirstName){
            var singleUser = await _context.Users.FindAsync(Id);
            singleUser.FirstName = newFirstName;
            
            await _context.SaveChangesAsync();
        }
        public async Task DeleteUser(int id){
            var user = await _context.Users
                                          .SingleOrDefaultAsync(singleUser => singleUser.Id == id);
            if(user != null){
                _context.Users.Remove(user);
                await _context.SaveChangesAsync();
            }
        }
        public async Task AddBlog(Blog blog){
            _context.Blogs.Add(blog);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateBlog(Blog blog, string newBlogName){
            var singleBlog = await _context.Blogs.FindAsync(blog.Id);
            // have to ask for what I have to change
            singleBlog.Name = newBlogName;
            await _context.SaveChangesAsync();

        }
        public async Task DeleteBlog(int id){
            var blog = await _context.Blogs            
                                            .SingleOrDefaultAsync(blog => blog.Id == id);
            if(blog != null){
                _context.Blogs.Remove(blog);
                //save changes 
                await _context.SaveChangesAsync();
            }

        }
        public async Task AddPost(Post post){
            _context.Posts.Add(post);
            await _context.SaveChangesAsync();
        }
        public async Task UpdatePost(Post post){
            var newTitle = "";
            var singlePost = await _context.Posts.FindAsync(post.Id);
            singlePost.Title = newTitle;
            await _context.SaveChangesAsync();
        }
        public async Task DeletePost(int id){
            var singlePost = await _context.Posts    
                                                .SingleOrDefaultAsync(post => post.Id == id);
            if(singlePost != null){
                _context.Posts.Remove(singlePost);
                await _context.SaveChangesAsync();
            }
        }

}