using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace artesania.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    ImageURL = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageURL", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Hecho de piezas de cuero en piezas originales", "https://th.bing.com/th/id/R.e3c2b536ba1a86a7e03559c765a9bd13?rik=roz00SogitUCDg&pid=ImgRaw&r=0", "Bolso de cuero", 100m },
                    { 2, "Pulsera hecha de Tagua, también conocida como 'marfil vegetal'.", "https://main.globalmarketmanager.com/images/1/pt2p.jpg", "Pulsera de Tagua", 50m },
                    { 3, "Reconocidos por su larga y cuidadosa elaboracion.", "https://www.lavanguardia.com/files/og_thumbnail/uploads/2015/02/20/5fa2787324dfc.jpeg", "Sombrero de paja Toquilla", 75m },
                    { 4, "Manta tejida a mano en la región de Otavalo.", "https://th.bing.com/th/id/OIP.qbpXCKvF9rZzYmgFfGXMHwHaE_?rs=1&pid=ImgDetMain", "Manta de Otavalo", 25m },
                    { 5, "Zapatos de cuero hechos a mano en Cotacachi.", "https://www.somosmamas.com.ar/wp-content/uploads/2019/06/product-hugerect-1958297-126370-1520514051-61c3ea2fb41ad97118ff5a48525211d6.jpg", "Zapatos de Cuero de Cotacachi", 90m },
                    { 6, "Cerámica pintada a mano de la ciudad de Cuenca.", "https://www.vistazo.com/binrepository/640x524/0c0/0d0/none/12727/OUUQ/foto-3-calidad-ceramica-artesa-2_416590_20220503103626.jpg", "Cerámica de Cuenca", 30m },
                    { 7, "Chal tejido con lana de alpaca.", "https://i.etsystatic.com/17835651/r/il/1b599f/2749386384/il_fullxfull.2749386384_lsqe.jpg", "Chal de Alpaca", 25m },
                    { 8, "Máscara tradicional utilizada en la fiesta de la Diabluma.", "https://i.pinimg.com/originals/42/4e/25/424e2521e7fc2cef080b5c97e965ed62.jpg", "Máscara de Diabluma", 20m },
                    { 9, "Hamaca tejida a mano en la provincia de Manabí.", "https://i.pinimg.com/originals/f6/66/99/f66699085122d24e0b3f5534c01ee23a.jpg", "Hamaca de Manabí", 15m },
                    { 10, "Talla de madera hecha a mano en el pueblo de San Antonio.", "https://www.expectativa.ec/wp-content/uploads/2020/09/w4LQATAm04HkMLu.jpg", "Talla de Madera de San Antonio", 40m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
