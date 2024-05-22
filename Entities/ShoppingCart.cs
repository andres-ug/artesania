using artesania.DTOs;

namespace artesania.Entities;

public class ShoppingCart
{
    public int Id { get; set; }
    public int Quantity { get; set; }
    public int ProductId { get; set; }
}