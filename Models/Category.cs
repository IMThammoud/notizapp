using System.ComponentModel.DataAnnotations;

namespace NotizApp.Models;

public class Category
{
    [Key]
    public int CategoryId { get; set; }
        
    [Required]
    public string Name { get; set; }
        
    public string Icon { get; set; }
        
    // Navigation property for the notes under this category
    public virtual ICollection<Notiz> Notizen { get; set; }
}