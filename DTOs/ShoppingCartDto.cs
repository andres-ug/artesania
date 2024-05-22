namespace artesania.DTOs;

public class ShoppingCartDto
{
    public ShoppingCartDto()
    {
        Product = new ProductDto();
    }
    public ProductDto Product { get; set; }
    public int Quantity { get; set; }
}