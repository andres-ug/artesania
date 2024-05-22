using artesania.DTOs;

namespace artesania.Entities;

public class ShoppingCart
{
    public int Id { get; set; }
    public ShoppingCart()
    {
        Product = new Product();
    }
    public int Quantity { get; set; }
    public int ProductId { get; set; }
    public virtual Product Product { get; set; }
}