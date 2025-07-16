using CatalogoAgil.DataAccess;
using CatalogoAgil.DataAccess.Entities;
using CatalogoAgil.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace CatalogoAgil.Services;

public class ProductService
{
    private readonly AppDBContext dbContext;

    public ProductService(AppDBContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public async Task<List<ProductViewModel>> GetAllProducts()
    {
        return await dbContext.Products
            .OrderBy(x => x.ProductCategory)
            .Select(x => new ProductViewModel
            {
                ProductId = x.ProductId,
                ProductName = x.ProductName,
                ProductDescription = x.ProductDescription,
                ProductPrice = x.ProductPrice,
                ProductQuantity = x.ProductQuantity,
                ProductCategory = x.ProductCategory,
                ProductStatus = x.ProductStatus
            }).ToListAsync();
    }

    public bool CreateNewProduct(ProductViewModel productViewModel)
    {
        try
        {
            Product product = new Product
            {
                ProductName = productViewModel.ProductName,
                ProductDescription = productViewModel.ProductDescription,
                ProductPrice = productViewModel.ProductPrice,
                ProductQuantity = productViewModel.ProductQuantity,
                ProductCategory = productViewModel.ProductCategory,
                ProductStatus = productViewModel.ProductStatus
            };
            
            dbContext.Products.Add(product);
            
            var result = dbContext.SaveChanges();
            
            return result > 0;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}