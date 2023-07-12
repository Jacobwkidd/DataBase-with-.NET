using WebsiteBlogs.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebsiteBlogs.Interfaces;

public interface IDatabaseService
{
    // This method should return a list of all users in the database, including their blogs, posts, and comments.
    Task<List<User>> GetAllUsers();

    // This method should return a list of all blogs in the database, including their associated users, posts, and comments.
    Task<List<Blog>> GetAllBlogs();

    // This method should return a list of all posts in the database, including their associated blog, user, comments, and tags.
    Task<List<Post>> GetAllPosts();

    // This method should return a user with the specified id, including their blogs, posts, and comments.
    Task<User?> GetUserById(int id);

    // This method should create a new user in the database.
    Task AddUser(User user);

    // This method should update an existing user in the database.
    Task UpdateUser(User user);

    // This method should delete a user with the specified id from the database.
    Task DeleteUser(int id);

    // This method should create a new blog in the database.
    Task AddBlog(Blog blog);

    // This method should update an existing blog in the database.
    Task UpdateBlog(Blog blog);

    // This method should delete a blog with the specified id from the database.
    Task DeleteBlog(int id);

    // This method should create a new post in the database.
    Task AddPost(Post post);

    // This method should update an existing post in the database.
    Task UpdatePost(Post post);

    // This method should delete a post with the specified id from the database.
    Task DeletePost(int id);
}