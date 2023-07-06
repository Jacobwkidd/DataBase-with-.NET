using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebsiteBlogs.Models;

public class User{
    public int Id{get; set;}
    public string FirstName{get; set;}
    public string LastName{get; set;}
    public string Email{get; set;}
    public int? BlogId{get; set;}
    [ForeignKey("BlogTable")]
    
    //public virtual List<Comment>? Comments{get; set;}

}