namespace artesania.Entities;

public class Buy
{
    public int Id { get; set; }
    public string Identification { get; set; }
    public string Name { get; set; }
    public string Direction { get; set; }
    public List<Product> Products { get; set; }
    public decimal Total { get; set; }
    public DateTime Date { get; set; }
    
}