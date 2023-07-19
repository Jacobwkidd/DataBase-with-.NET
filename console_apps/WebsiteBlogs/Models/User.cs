using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebsiteBlogs.Models;

public class User{
    [Key]
    public int Id{get; set;}
    public string FirstName{get; set;}
    public string LastName{get; set;}
    public string Email{get; set;}
    [ForeignKey("Blog")]
    public int? BlogId{get; set;}
    public Blog? Blog{get;set;}
    
    public virtual List<Comment>? Comments{get; set;}

}