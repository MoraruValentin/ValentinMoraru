using System;
using System.Collections.Generic;
using System.Text;

namespace iQuest.VendingMachine.Products
{
    public class ProductRepo
    {
        static private List<Product> products;

        public ProductRepo()
        {
            products = new List<Product>();
            //products.Add(new Product(1, "Baseball Bat", 120, 2, 20));
            //products.Add(new Product(1, "Lion Bar", 25, 0, 2));
            //products.Add(new Product(1, "Mug", 25, 10, 2));
            //products.Add(new Product(1, "Snickers Bar", 50, 50, 1));
        }

        public void AddProduct(Product input)
        {
            products.Add(input);
        }

        public void RemoveProduct(Product input)
        {
            products.Remove(input);
        }

        public IEnumerable<Product> GetProducts()
        {
            return products;
        }
    }
}
