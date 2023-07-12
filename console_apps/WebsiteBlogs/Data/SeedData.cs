using System;
using System.Linq;
using WebsiteBlogs.Models;
using WebsiteBlogs.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;

namespace WebsiteBlogs.Data;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new ApplicationDbContext())
        {
            if (context.Users.Any())
            {
                // DB has been seeded
                return;
            }

            // Create Users
            var users = new List<User>
            {
                new User { FirstName = "John", LastName = "Doe", Email = "john@example.com" },
                new User { FirstName = "Jane", LastName = "Smith", Email = "jane@example.com" },
                new User { FirstName = "Alice", LastName = "Johnson", Email = "alice@example.com" },
                new User { FirstName = "Bob", LastName = "Williams", Email = "bob@example.com" },
                new User { FirstName = "Emma", LastName = "Brown", Email = "emma@example.com" },
            };

            // Create Blogs
            var blogs = new List<Blog>
            {
                new Blog { Name = "John's Blog", Owner = users[0] },
                new Blog { Name = "Jane's Blog", Owner = users[1] },
                new Blog { Name = "Alice's Blog", Owner = users[2] },
                new Blog { Name = "Bob's Blog", Owner = users[3] },
                new Blog { Name = "Emma's Blog", Owner = users[4] },
            };

            // Create Posts and Comments
            var comments = new List<Comment>();
            var posts = new List<Post>();
            var tags = new List<Tag>
            {
                new Tag { Name = "Introduction" },
                new Tag { Name = "Tutorial" },
                new Tag { Name = "Guide" },
                new Tag { Name = "Tips" },
                new Tag { Name = "Review" }
            };

            for (int i = 0; i < 5; i++)
            {
                var post = new Post
                {
                    Title = $"Post {i+1}",
                    Content = $"This is post {i+1}.",
                    Blog = blogs[i],
                    Tags = new List<Tag> { tags[i] }
                };
                posts.Add(post);

                var comment = new Comment
                {
                    Text = $"This is a comment on post {i+1}.",
                    User = users[(i+1)%5], // rotate users for comments
                    Post = post
                };
                comments.Add(comment);
            }

            context.Users.AddRange(users);
            context.Blogs.AddRange(blogs);
            context.Posts.AddRange(posts);
            context.Comments.AddRange(comments);
            context.Tags.AddRange(tags);

            context.SaveChanges();
        }
    }
}