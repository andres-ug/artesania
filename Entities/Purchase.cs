namespace artesania.Entities;

public class Purchase
{
    public int Id { get; set; }
    public Customer Customer { get; set; }
    public List<ShoppingCart> Products { get; set; }
    public DateTime PurchaseDate { get; set; }
}