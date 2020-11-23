using System;
using System.Collections.Generic;
using System.Linq;
using iQuest.VendingMachine.PresentationLayer;
using iQuest.VendingMachine.Products;

namespace iQuest.VendingMachine
{
    internal class VendingMachineApplication
    {
        private readonly List<IUseCase> useCases;
        private readonly MainDisplay mainDisplay;
        public ProductRepo products;

        private bool turnOffWasRequested;

        public bool UserIsLoggedIn { get; set; }
        public bool AdminIsLoggedIn { get; set; }

        public VendingMachineApplication(List<IUseCase> useCases, MainDisplay mainDisplay, ProductRepo products)
        {
            this.useCases = useCases ?? throw new ArgumentNullException(nameof(useCases));
            this.mainDisplay = mainDisplay ?? throw new ArgumentNullException(nameof(mainDisplay));
            this.products = products ?? throw new ArgumentNullException(nameof(products));
        }

        public void Run()
        {
            turnOffWasRequested = false;

            while (!turnOffWasRequested)
            {
                IEnumerable<IUseCase> availableUseCases = useCases
                    .Where(x => x.CanExecute);

                IUseCase useCase = mainDisplay.ChooseCommand(availableUseCases);
                useCase.Execute();
            }
        }

        public void TurnOff()
        {
            turnOffWasRequested = true;
        }
    }
}