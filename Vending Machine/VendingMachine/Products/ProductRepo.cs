using System;
using System.Collections.Generic;
using System.Text;

namespace iQuest.VendingMachine.Products
{
    public class ProductRepo
    {
        private List<Product> products;

        public ProductRepo()
        {
            products = new List<Product>();
        }

        public void AddProduct(Product input)
        {
            products.Add(input);
        }

        public void RemoveProduct(Product input)
        {
            products.Remove(input);
        }

        public List<Product> GetProducts()
        {
            return products;
        }
    }
}
