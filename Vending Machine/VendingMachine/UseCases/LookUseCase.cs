using iQuest.VendingMachine.PresentationLayer;
using iQuest.VendingMachine.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace iQuest.VendingMachine.UseCases
{
    internal class LookUseCase : IUseCase
    {
        private readonly VendingMachineApplication application;

        private readonly ShelfView shelf;

        private readonly ProductRepo products;

        public string Name => "view products";

        public string Description => "Press this to view all products";

        public bool CanExecute => true;

        public LookUseCase(VendingMachineApplication application, ShelfView shelf, ProductRepo products)
        {
            this.application = application;
            this.shelf = shelf;
            this.products = products;
        }

        public void Execute()
        {
            shelf.DisplayProducts(products.GetProducts());
        }
    }
}
