using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebsiteBlogs.Data;
using WebsiteBlogs.Services;
using WebsiteBlogs.Models;
DatabaseService _dbService;

var services = new ServiceCollection();

services.AddDbContext<ApplicationDbContext>();
services.AddScoped<DatabaseService>();

var serviceProvider = services.BuildServiceProvider();
_dbService = serviceProvider.GetRequiredService<DatabaseService>();

SeedData.Initialize(serviceProvider);

/*
    TODO: Create an instance of the DatabaseService in order to test
            your methods in that class.

            Note that you DO NOT need to comment out the SeedData.Initialize()
            method after seeding the database. The initialization method checks
            to see if the database is empty before executing. So if you have already
            populated the database, the initialization will not run again.
            If you would like to comment out the SeedData.Initialize() line, that
            is fine - it won't hurt anything - but no worries if you leave it in.
*/

Console.WriteLine("====================== NUMBER 1 BEGIN ======================");
// 1. Test GetAllUsers
//    Call GetAllUsers method on dbService and print the count of users. It should be 5.
var allUsers = await _dbService.GetAllUsers();
foreach(User name in allUsers){
    System.Console.WriteLine(name.FirstName);
}
Console.WriteLine("====================== NUMBER 1 END ======================");

Console.WriteLine("====================== NUMBER 2 BEGIN ======================");

// 2. Test GetUserById
//    Call GetUserById method on dbService with parameter id=1, print the user's name. It should be John Doe.
var getUserById = await _dbService.GetUserById(1);
System.Console.WriteLine(getUserById);



Console.WriteLine("====================== NUMBER 2 END ======================");

Console.WriteLine("====================== NUMBER 3 BEGIN ======================");
// 3. Test AddUser
//    Create a new User object with FirstName = "New", LastName = "User", Email = "new@example.com".
//    Call AddUser method on dbService with the new User object.
//    Again, call GetAllUsers and print the count of users. It should be 6.
//User newUser = new User {FirstName ="Bob", LastName ="Smith", Email = "new@example.com"};
// await _dbService.AddUser(newUser);
foreach(User name in allUsers){
    System.Console.WriteLine(name.FirstName);
}

Console.WriteLine("====================== NUMBER 3 END ======================");

Console.WriteLine("====================== NUMBER 4 BEGIN ======================");
// 4. Test UpdateUser
//    Update the FirstName of the new User object to "Updated".
//    Call UpdateUser method on dbService with the updated User object.
//    Call GetUserById method with id of the new User, print the user's name. It should be "Updated User".
// User Id6 = await _dbService.GetUserById(6);
await _dbService.UpdateUser(6, "Updated");
foreach(User name in allUsers){
    System.Console.WriteLine(name.FirstName);
}
Console.WriteLine("====================== NUMBER 4 END ======================");

Console.WriteLine("====================== NUMBER 5 BEGIN ======================");

// 5. Test DeleteUser
//    Call DeleteUser method on dbService with the id of the new User.
//    Again, call GetAllUsers and print the count of users. It should be 5.
await _dbService.DeleteUser(6);
foreach(User name in allUsers){
    System.Console.WriteLine(name.FirstName);
}

Console.WriteLine("====================== NUMBER 5 END ======================");

Console.WriteLine("====================== NUMBER 6 BEGIN ======================");

// 6. Test GetAllBlogs
//    Call GetAllBlogs method on dbService and print the count of blogs. It should be 5.
var getAllBlogs = await _dbService.GetAllBlogs();
foreach(Blog blog in getAllBlogs){
    System.Console.WriteLine(blog.Name);
}
Console.WriteLine("====================== NUMBER 6 END ======================");

Console.WriteLine("====================== NUMBER 7 BEGIN ======================");

// 7. Test AddBlog
//    Create a new Blog object with Name = "New Blog" and UserId = 1.
//    Call AddBlog method on dbService with the new Blog object.
//    Again, call GetAllBlogs and print the count of blogs. It should be 6.
Blog newBlog = new Blog {Name = "New Blog", UserId = 1};
await _dbService.AddBlog(newBlog);
foreach(Blog blog in getAllBlogs){
    System.Console.WriteLine(blog.Name);
}

Console.WriteLine("====================== NUMBER 7 END ======================");

Console.WriteLine("====================== NUMBER 8 BEGIN ======================");

// 8. Test UpdateBlog
//    Update the Name of the new Blog object to "Updated Blog".
//    Call UpdateBlog method on dbService with the updated Blog object.
//    Query the updated Blog from the database and print its name. It should be "Updated Blog".
await _dbService.UpdateBlog(newBlog, "Updated blog");
foreach(Blog blog in getAllBlogs){
    System.Console.WriteLine(blog.Name);
}


Console.WriteLine("====================== NUMBER 8 END ======================");

Console.WriteLine("====================== NUMBER 9 BEGIN ======================");

// 9. Test DeleteBlog
//    Call DeleteBlog method on dbService with the id of the new Blog.
//    Again, call GetAllBlogs and print the count of blogs. It should be 5.
await _dbService.DeleteBlog(1);
foreach(Blog blog in getAllBlogs){
    System.Console.WriteLine(blog.Name);
}
Console.WriteLine("====================== NUMBER 9 END ======================");

Console.WriteLine("====================== NUMBER 10 BEGIN ======================");

// 10. Test GetAllPosts
//    Call GetAllPosts method on dbService and print the count of posts. It should be 5.
var getAllPosts = await _dbService.GetAllPosts();
foreach(Post post in getAllPosts){
    System.Console.WriteLine(post.Title);
}
Console.WriteLine("====================== NUMBER 10 END ======================");

Console.WriteLine("====================== NUMBER 11 BEGIN ======================");

// 11. Test AddPost
//    Create a new Post object with Title = "New Post", Content = "This is a new post", BlogId = 1.
//    Call AddPost method on dbService with the new Post object.
//    Again, call GetAllPosts and print the count of posts. It should be 6.
Post newPost = new Post{Title = "New Post", Content = "This is a new Post", BlogId = 1};
await _dbService.AddPost(newPost);
foreach(Post post in getAllPosts){
    System.Console.WriteLine(post.Title);
}
Console.WriteLine("====================== NUMBER 11 END ======================");

Console.WriteLine("====================== NUMBER 12 BEGIN ======================");

// 12. Test UpdatePost
//    Update the Title of the new Post object to "Updated Post".
//    Call UpdatePost method on dbService with the updated Post object.
//    Query the updated Post from the database and print its title. It should be "Updated Post".
await _dbService.UpdatePost(newPost);
newPost.Title = "Updated Post";
foreach(Post post in getAllPosts){
    System.Console.WriteLine(post.Title);
}
Console.WriteLine("====================== NUMBER 12 END ======================");

Console.WriteLine("====================== NUMBER 13 BEGIN ======================");

// 13. Test DeletePost
//    Call DeletePost method on dbService with the id of the new Post.
//    Again, call GetAllPosts and print the count of posts. It should be 5.
await _dbService.DeletePost(1);
foreach(Post post in getAllPosts){
    System.Console.WriteLine(post.Title);
}
Console.WriteLine("====================== NUMBER 13 END ======================");