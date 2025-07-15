using CatalogoAgil.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace CatalogoAgil.DataAccess;

public static class Seed
{
    public static void GenerateSeed(this ModelBuilder modelBuilder)
    {
        var products = new[]
        {
            new Product { ProductId = 1, ProductName = "Gasolina Comum", ProductDescription = "Combustível tipo comum", ProductCategory = "P", ProductQuantity = 1000, ProductPrice = 6.00m, ProductStatus = true },
            new Product { ProductId = 2, ProductName = "Gasolina Aditivada", ProductDescription = "Combustível com aditivos", ProductCategory = "P", ProductQuantity = 800, ProductPrice = 6.30m, ProductStatus = true },
            new Product { ProductId = 3, ProductName = "Etanol", ProductDescription = "Álcool combustível", ProductCategory = "P", ProductQuantity = 500, ProductPrice = 4.20m, ProductStatus = true },
            new Product { ProductId = 4, ProductName = "Diesel S10", ProductDescription = "Diesel de baixa emissão", ProductCategory = "P", ProductQuantity = 1200, ProductPrice = 5.80m, ProductStatus = true },
            new Product { ProductId = 5, ProductName = "Refrigerante Lata", ProductDescription = "350ml - Diversos sabores", ProductCategory = "B", ProductQuantity = 100, ProductPrice = 5.00m, ProductStatus = true },
            new Product { ProductId = 6, ProductName = "Água Mineral", ProductDescription = "500ml - com ou sem gás", ProductCategory = "B", ProductQuantity = 150, ProductPrice = 3.00m, ProductStatus = true },
            new Product { ProductId = 7, ProductName = "Café Expresso", ProductDescription = "Copo 100ml", ProductCategory = "B", ProductQuantity = 50, ProductPrice = 2.50m, ProductStatus = true },
            new Product { ProductId = 8, ProductName = "Sanduíche Natural", ProductDescription = "Frango ou atum", ProductCategory = "A", ProductQuantity = 30, ProductPrice = 7.50m, ProductStatus = true },
            new Product { ProductId = 9, ProductName = "Salgadinho Chips", ProductDescription = "Diversos sabores", ProductCategory = "A", ProductQuantity = 40, ProductPrice = 4.00m, ProductStatus = true },
            new Product { ProductId = 10, ProductName = "Chocolate", ProductDescription = "Barrinha 25g", ProductCategory = "A", ProductQuantity = 60, ProductPrice = 2.80m, ProductStatus = true },
            new Product { ProductId = 11, ProductName = "Bala", ProductDescription = "Sortida", ProductCategory = "A", ProductQuantity = 100, ProductPrice = 1.00m, ProductStatus = true },
            new Product { ProductId = 12, ProductName = "Chiclete", ProductDescription = "Sortido", ProductCategory = "A", ProductQuantity = 80, ProductPrice = 1.50m, ProductStatus = true },
            new Product { ProductId = 13, ProductName = "Óleo de Motor", ProductDescription = "Lubrificante 1L", ProductCategory = "O", ProductQuantity = 20, ProductPrice = 30.00m, ProductStatus = true },
            new Product { ProductId = 14, ProductName = "Fluido de Freio", ProductDescription = "DOT 4", ProductCategory = "O", ProductQuantity = 15, ProductPrice = 25.00m, ProductStatus = true },
            new Product { ProductId = 15, ProductName = "Aditivo Radiador", ProductDescription = "1L Pronto uso", ProductCategory = "O", ProductQuantity = 10, ProductPrice = 22.00m, ProductStatus = true },
            new Product { ProductId = 16, ProductName = "Lâmpada Automotiva", ProductDescription = "Farol H7", ProductCategory = "O", ProductQuantity = 10, ProductPrice = 15.00m, ProductStatus = true },
            new Product { ProductId = 17, ProductName = "Desodorizador de Carro", ProductDescription = "Odorizador em cartão", ProductCategory = "A", ProductQuantity = 25, ProductPrice = 6.00m, ProductStatus = true },
            new Product { ProductId = 18, ProductName = "Pano Multiuso", ProductDescription = "Pacote com 5 unidades", ProductCategory = "O", ProductQuantity = 20, ProductPrice = 10.00m, ProductStatus = true },
            new Product { ProductId = 19, ProductName = "Cabo de Chupeta", ProductDescription = "Para emergência veicular", ProductCategory = "O", ProductQuantity = 5, ProductPrice = 45.00m, ProductStatus = true },
            new Product { ProductId = 20, ProductName = "Carregador de Celular", ProductDescription = "USB Veicular", ProductCategory = "A", ProductQuantity = 10, ProductPrice = 20.00m, ProductStatus = true }
        };

        modelBuilder.Entity<Product>().HasData(products);   

    }
}
