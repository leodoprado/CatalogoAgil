﻿namespace CatalogoAgil.DataAccess.Entities;

public class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public string ProductDescription { get; set; }
    public string ProductCategory { get; set; }
    public int ProductQuantity { get; set; }
    public decimal ProductPrice { get; set; }
    public bool ProductStatus { get; set; }
}