using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NotizApp.Models;

public class Notiz
{
    [Key]
    public int NotizId { get; set; }
        
    [Required]
    public string Heading { get; set; }
        
    [Required]
    public string Content { get; set; }
        
    // Foreign key for User
    [ForeignKey("User")]
    public int UserId { get; set; }
    public User User { get; set; }
        
    // Foreign key for Category
    [ForeignKey("Category")]
    public int CategoryId { get; set; }
    public Category Category { get; set; }
}