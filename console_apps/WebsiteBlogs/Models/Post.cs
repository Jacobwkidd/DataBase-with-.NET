using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebsiteBlogs.Models;

public class Post{
    [Key]
    public int Id{get;set;}
    public string Title{get;set;}
    public string Content{get;set;}
    [ForeignKey("Blog")]
    public int? BlogId{get;set;}
    public Blog? Blog{get;set;}
    public List<Comment>? Comments{get;set;}
    public List<Tag>? Tags{get;set;}
}