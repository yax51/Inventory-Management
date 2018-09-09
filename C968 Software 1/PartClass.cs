using System;

public abstract class Part
{
    private int partID;
    private string name;
    private double price;
    private int inStock;
    private int min;
    private int max;

    protected int PartID { get => partID; set => partID = value; }
    protected string Name { get => name; set => name = value; }
    protected double Price { get => price; set => price = value; }
    protected int InStock { get => inStock; set => inStock = value; }
    protected int Min { get => min; set => min = value; }
    protected int Max { get => max; set => max = value; }
}
