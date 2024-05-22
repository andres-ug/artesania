using System.ComponentModel.DataAnnotations;

namespace artesania.Entities;

public class Product
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string ImageURL { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
}