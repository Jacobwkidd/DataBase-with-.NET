using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebsiteBlogs.Models;

public class Tag{
   public int Id{get;set;}
   public string Name{get;set;}
   public List<Post> Posts{get;set;}
}