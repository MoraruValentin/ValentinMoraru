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

            VendingMachineApplication vendingMachineApplication = new VendingMachineApplication(useCases, mainDisplay, products);

            useCases.AddRange(new IUseCase[]
            {
                new LoginUseCase(vendingMachineApplication, mainDisplay),
                new LogoutUseCase(vendingMachineApplication),
                new TurnOffUseCase(vendingMachineApplication),
                new ViewProductsUseCase(vendingMachineApplication,shelf)
            });

            return vendingMachineApplication;
        }
    }
}