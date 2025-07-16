using CatalogoAgil.DataAccess;
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
}