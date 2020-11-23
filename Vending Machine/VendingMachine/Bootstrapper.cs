using System.Collections.Generic;
using iQuest.VendingMachine.PresentationLayer;
using iQuest.VendingMachine.Products;
using iQuest.VendingMachine.UseCases;

namespace iQuest.VendingMachine
{
    internal class Bootstrapper
    {
        public void Run()
        {
            VendingMachineApplication vendingMachineApplication = BuildApplication();
            vendingMachineApplication.Run();
        }

        private static VendingMachineApplication BuildApplication()
        {
            MainDisplay mainDisplay = new MainDisplay();
            List<IUseCase> useCases = new List<IUseCase>();
            ProductRepo products = new ProductRepo();
            ShelfView shelf = new ShelfView();

            products.AddProduct(new Product(1, "Baseball Bat", 120, 2, 20));
            products.AddProduct(new Product(1, "Lion Bar", 25, 0, 2));
            products.AddProduct(new Product(1, "Mug", 25, 10, 2));
            products.AddProduct(new Product(1, "Snickers Bar", 50, 50, 1));

            VendingMachineApplication vendingMachineApplication = new VendingMachineApplication(useCases, mainDisplay, products);

            useCases.AddRange(new IUseCase[]
            {
                new LoginUseCase(vendingMachineApplication, mainDisplay),
                new LogoutUseCase(vendingMachineApplication),
                new TurnOffUseCase(vendingMachineApplication),
                new LookUseCase(vendingMachineApplication,shelf,products)
            });

            return vendingMachineApplication;
        }
    }
}