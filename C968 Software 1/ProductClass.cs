using System;

public class Product
{
    int[] associatedParts = new int[6];
    private int productId;
    private string productName;
    private double productPrice;
    private int productInStock;
    private int productMin;
    private int productMax;

    
    public int ProductId { get => productId; set => productId = value; }
    public string ProductName { get => productName; set => productName = value; }
    public double ProductPrice { get => productPrice; set => productPrice = value; }
    public int ProductInStock { get => productInStock; set => productInStock = value; }
    public int ProductMin { get => productMin; set => productMin = value; }
    public int ProductMax { get => productMax; set => productMax = value; }
}

public product()
{
    this.productID = new productID(0);
    this.productName = new productName("");
    this.productPrice = new productPrice(0);
    this.productInStock = new productInStock(0);
    this.productMin = new productMin(0);
    this.productMax = new productMax(0);
}


