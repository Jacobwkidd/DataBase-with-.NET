using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebsiteBlogs.Models;

public class Blog{
    [Key]
    public int Id{get; set;}
    public string Name{get;set;}
    [ForeignKey("User")]
    public int? UserId{get;set;}
    [ForeignKey("User")]
    public int? OwnerId{get;set;}
    
    public User? Owner{get;set;}
    public List<Post> Post{get;set;}
}