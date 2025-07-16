using System.ComponentModel.DataAnnotations;

namespace CatalogoAgil.ViewModels;

public class ProductViewModel
{
    public int ProductId { get; set; }

    public string ProductIdView
    {
        get
        {
            return "PROD" + ProductId.ToString().PadLeft(4, '0');
        }
    }

    [Required] public string ProductName { get; set; }
    public string ProductDescription { get; set; }
    [Required] public string ProductCategory { get; set; }
    [Required] public int ProductQuantity { get; set; }
    [Required] public decimal ProductPrice { get; set; }
    [Required] public bool ProductStatus { get; set; }
}