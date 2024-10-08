using System.ComponentModel.DataAnnotations;

namespace ECommerceAPI.Models;

public class Category
{
    [Key]
    public int CategoryID { get; set; }

    [Required]
    public string? name { get; set; }
}