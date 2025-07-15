using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CatalogoAgil.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductCategory", "ProductDescription", "ProductName", "ProductPrice", "ProductQuantity", "ProductStatus" },
                values: new object[,]
                {
                    { 1, "P", "Combustível tipo comum", "Gasolina Comum", 6.00m, 1000, true },
                    { 2, "P", "Combustível com aditivos", "Gasolina Aditivada", 6.30m, 800, true },
                    { 3, "P", "Álcool combustível", "Etanol", 4.20m, 500, true },
                    { 4, "P", "Diesel de baixa emissão", "Diesel S10", 5.80m, 1200, true },
                    { 5, "B", "350ml - Diversos sabores", "Refrigerante Lata", 5.00m, 100, true },
                    { 6, "B", "500ml - com ou sem gás", "Água Mineral", 3.00m, 150, true },
                    { 7, "B", "Copo 100ml", "Café Expresso", 2.50m, 50, true },
                    { 8, "A", "Frango ou atum", "Sanduíche Natural", 7.50m, 30, true },
                    { 9, "A", "Diversos sabores", "Salgadinho Chips", 4.00m, 40, true },
                    { 10, "A", "Barrinha 25g", "Chocolate", 2.80m, 60, true },
                    { 11, "A", "Sortida", "Bala", 1.00m, 100, true },
                    { 12, "A", "Sortido", "Chiclete", 1.50m, 80, true },
                    { 13, "O", "Lubrificante 1L", "Óleo de Motor", 30.00m, 20, true },
                    { 14, "O", "DOT 4", "Fluido de Freio", 25.00m, 15, true },
                    { 15, "O", "1L Pronto uso", "Aditivo Radiador", 22.00m, 10, true },
                    { 16, "O", "Farol H7", "Lâmpada Automotiva", 15.00m, 10, true },
                    { 17, "A", "Odorizador em cartão", "Desodorizador de Carro", 6.00m, 25, true },
                    { 18, "O", "Pacote com 5 unidades", "Pano Multiuso", 10.00m, 20, true },
                    { 19, "O", "Para emergência veicular", "Cabo de Chupeta", 45.00m, 5, true },
                    { 20, "A", "USB Veicular", "Carregador de Celular", 20.00m, 10, true }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20);
        }
    }
}
