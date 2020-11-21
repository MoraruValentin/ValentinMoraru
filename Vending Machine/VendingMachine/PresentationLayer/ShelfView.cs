using iQuest.VendingMachine.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace iQuest.VendingMachine.PresentationLayer
{
    class ShelfView
    {
        public void DisplayProducts(IEnumerable<Product> products)
        {
            Console.WriteLine("Items avalaible in the vending machine...");
            foreach (var item in products)
            {
                if (item.Quantity > 0)
                {
                    Console.WriteLine(item.Name + " " + item.Price );
                }
            }
        }
    }
}
