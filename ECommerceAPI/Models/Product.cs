using System.ComponentModel.DataAnnotations;

namespace ECommerceAPI.Models;

public class Product
{
    [Key]
    public int ProductID { get; set; }

    [Required]
    public string? Name { get; set; }

    [Required]
    public decimal Price { get; set; }
}