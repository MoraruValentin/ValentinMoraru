using iQuest.VendingMachine.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iQuest.VendingMachine.PresentationLayer
{
    internal class ShelfView
    {
        public void DisplayProducts(IEnumerable<Product> products)
        {
            if (!products.Any())
            {
                Console.WriteLine("no products left in the vending machine");
            }
            else
            {
                Console.WriteLine("Items avalaible in the vending machine...");

                foreach (var item in products)
                {
                    if (item.Quantity > 0)
                    {
                        Console.WriteLine(item.Name + " " + item.Price);
                    }
                }
            }
        }
    }
}
