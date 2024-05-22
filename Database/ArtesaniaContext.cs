using artesania.Entities;
using Microsoft.EntityFrameworkCore;

namespace artesania.Database;

public class ArtesaniaContext : DbContext
{

    public ArtesaniaContext(DbContextOptions<ArtesaniaContext> options) : base(options)
    {

    }

    public DbSet<Product> Products { get; set; }
    public DbSet<Purchase> Purchases { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<ShoppingCart> ShoppingCarts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=artesania.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>().HasData(
            new Product
            {
                Id = 1,
                ImageURL =
                    "https://th.bing.com/th/id/R.e3c2b536ba1a86a7e03559c765a9bd13?rik=roz00SogitUCDg&pid=ImgRaw&r=0",
                Name = "Bolso de cuero",
                Description = "Hecho de piezas de cuero en piezas originales",
                Price = 100
            },
            new Product
            {
                Id = 2,
                ImageURL = "https://main.globalmarketmanager.com/images/1/pt2p.jpg",
                Name = "Pulsera de Tagua",
                Description = "Pulsera hecha de Tagua, también conocida como 'marfil vegetal'.",
                Price = 50
            },
            new Product
            {
                Id = 3,
                ImageURL = "https://www.lavanguardia.com/files/og_thumbnail/uploads/2015/02/20/5fa2787324dfc.jpeg",
                Name = "Sombrero de paja Toquilla",
                Description = "Reconocidos por su larga y cuidadosa elaboracion.",
                Price = 75
            },
            new Product
            {
                Id = 4,
                ImageURL = "https://th.bing.com/th/id/OIP.qbpXCKvF9rZzYmgFfGXMHwHaE_?rs=1&pid=ImgDetMain",
                Name = "Manta de Otavalo",
                Description = "Manta tejida a mano en la región de Otavalo.",
                Price = 25
            },
            new Product
            {
                Id = 5,
                ImageURL =
                    "https://www.somosmamas.com.ar/wp-content/uploads/2019/06/product-hugerect-1958297-126370-1520514051-61c3ea2fb41ad97118ff5a48525211d6.jpg",
                Name = "Zapatos de Cuero de Cotacachi",
                Description = "Zapatos de cuero hechos a mano en Cotacachi.",
                Price = 90
            },
            new Product
            {
                Id = 6,
                ImageURL =
                    "https://www.vistazo.com/binrepository/640x524/0c0/0d0/none/12727/OUUQ/foto-3-calidad-ceramica-artesa-2_416590_20220503103626.jpg",
                Name = "Cerámica de Cuenca",
                Description = "Cerámica pintada a mano de la ciudad de Cuenca.",
                Price = 30
            },
            new Product
            {
                Id = 7,
                ImageURL = "https://i.etsystatic.com/17835651/r/il/1b599f/2749386384/il_fullxfull.2749386384_lsqe.jpg",
                Name = "Chal de Alpaca",
                Description = "Chal tejido con lana de alpaca.",
                Price = 25
            },
            new Product
            {
                Id = 8,
                ImageURL = "https://i.pinimg.com/originals/42/4e/25/424e2521e7fc2cef080b5c97e965ed62.jpg",
                Name = "Máscara de Diabluma",
                Description = "Máscara tradicional utilizada en la fiesta de la Diabluma.",
                Price = 20
            },
            new Product
            {
                Id = 9,
                ImageURL = "https://i.pinimg.com/originals/f6/66/99/f66699085122d24e0b3f5534c01ee23a.jpg",
                Name = "Hamaca de Manabí",
                Description = "Hamaca tejida a mano en la provincia de Manabí.",
                Price = 15
            },
            new Product
            {
                Id = 10,
                ImageURL = "https://www.expectativa.ec/wp-content/uploads/2020/09/w4LQATAm04HkMLu.jpg",
                Name = "Talla de Madera de San Antonio",
                Description = "Talla de madera hecha a mano en el pueblo de San Antonio.",
                Price = 40
            }
        );
    }
}