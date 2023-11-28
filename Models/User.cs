using System.ComponentModel.DataAnnotations;

namespace NotizApp.Models;

public class User
{
    [Key]
    public int UserId { get; set; }
        
    [Required]
    [EmailAddress]
    public string Email { get; set; }
        
    // Password will be hashed, no plain text will be stored
    [Required]
    [DataType(DataType.Password)]
    public string PasswordHash { get; set; }
        
    [Required]
    public string Username { get; set; }

    // Navigation property for the notes created by the user
    public virtual ICollection<Notiz> Notizen { get; set; }
}