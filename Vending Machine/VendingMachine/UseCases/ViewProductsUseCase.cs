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

        private readonly ShelfView shelf = new ShelfView();

        public string Name => "view products";

        public string Description => "Press this to view all products";

        public bool CanExecute => application.UserIsLoggedIn;

        public ViewProductsUseCase(VendingMachineApplication application)
        {
            this.application = application;
        }

        public void Execute()
        {
            shelf.DisplayProducts(application.products.GetProducts());
        }
    }
}
