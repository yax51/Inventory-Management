using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_Software_1
{
    class inventory
    {
        public static ArrayList Products<Product>();
        public static ArrayList allParts<Part>();

    }
    public static ArrayList<Products> Products
    {
        get
        {
            if (Products.Count == 0)
            {
                Load();
            }
            return Products;

        }
        set { products = value; }

    }
    public static void addProduct()
    {
        Product.Add(product);
        save();
    }
    public int removeProduct()
    {

    }
    public int updateProduct()
    {

    }
    public int addPart()
    {

    }
    public int deletePart()
    {

    }
    public int lookupPart()
    {

    }
    public int updatePart()
    {

    }


}
