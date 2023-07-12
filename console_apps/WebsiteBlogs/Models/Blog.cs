using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebsiteBlogs.Models;

public class Blog{
    public int Id{get; set;}
    public string Name{get;set;}
    public int? UserId{get;set;}
    public int? OwnerId{get;set;}
    public User? Owner{get;set;}
    public List<Post> Post{get;set;}
}