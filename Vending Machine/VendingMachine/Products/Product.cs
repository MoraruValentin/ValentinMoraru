using System;
using System.Collections.Generic;
using System.Text;

namespace iQuest.VendingMachine.Products
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public int Size { get; set; }

        public Product(int id, string name, int price, int quantity,int size)
        {
            this.ProductId = id;
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
            this.Size = size;
        }
    }
}
