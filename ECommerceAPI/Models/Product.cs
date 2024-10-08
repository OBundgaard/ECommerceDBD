using System.ComponentModel.DataAnnotations;

namespace ECommerceAPI.Models;

public class Product
{
    [Key]
    public int ProductID { get; set; }

    [Required]
    public string? Name { get; set; }

    [Required]
    public float Price { get; set; }

    // Foreign key property for cateogry
    [Required]
    public int CategoryID { get; set; }

    // Navigation property to Category
    public Category? Category { get; set; }
}