using iQuest.VendingMachine.PresentationLayer;
using iQuest.VendingMachine.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace iQuest.VendingMachine.UseCases
{
    internal class ViewProductsUseCase : IUseCase
    {
        private readonly VendingMachineApplication application;

        private readonly ShelfView shelf;

        public string Name => "view products";

        public string Description => "Press this to view all products";

        public bool CanExecute => true;

        public ViewProductsUseCase(VendingMachineApplication application, ShelfView shelf)
        {
            this.application = application;
            this.shelf = shelf;
        }

        public void Execute()
        {
            shelf.DisplayProducts(application.products.GetProducts());
        }
    }
}
