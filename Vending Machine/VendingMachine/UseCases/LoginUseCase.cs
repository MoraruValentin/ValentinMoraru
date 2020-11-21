using System;
using iQuest.VendingMachine.PresentationLayer;
using iQuest.VendingMachine.Products;

namespace iQuest.VendingMachine.UseCases
{
    internal class LoginUseCase : IUseCase
    {
        private readonly VendingMachineApplication application;
        private readonly MainDisplay mainDisplay;

        public string Name => "login";

        public string Description => "Get access to administration buttons.";

        public bool CanExecute => !application.UserIsLoggedIn;

        public LoginUseCase(VendingMachineApplication application, MainDisplay mainDisplay)
        {
            this.application = application ?? throw new ArgumentNullException(nameof(application));
            this.mainDisplay = mainDisplay ?? throw new ArgumentNullException(nameof(mainDisplay));
        }

        public void Execute()
        {
            string password = mainDisplay.AskForPassword();

            if (password == "123")
                application.UserIsLoggedIn = true;
            else
                throw new Exception("Invalid password");
        }
    }
}