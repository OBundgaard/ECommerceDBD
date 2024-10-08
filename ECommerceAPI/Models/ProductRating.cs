using System.ComponentModel.DataAnnotations;

namespace ECommerceAPI.Models;

public class ProductRating
{
    [Key]
    public int ProductRatingID { get; set; }

    [Required]
    public int Rating { get; set; }

    [Required]
    public int ProductID { get; set; }

    public Product? Product { get; set; }
}