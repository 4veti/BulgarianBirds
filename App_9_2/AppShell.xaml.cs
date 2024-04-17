using App_9_2.ViewModels;
using System.Windows.Input;
using Xamarin.Forms;

namespace App_9_2
{
    public partial class AppShell : Shell
    {
        private Command helpCommand;

        public AppShell()
        {
            InitializeComponent();
            BindingContext = this;
            Routing.RegisterRoute(nameof(AuthorInfoPage), typeof(AuthorInfoPage));
        }

        public string AuthorInfoText => "За автора";
        public ICommand HelpCommand
        {
            get
            {
                if (helpCommand == null)
                {
                    helpCommand = new Command(Help);
                }

                return helpCommand;
            }
        }

        private async void Help()
        {
            await Shell.Current.GoToAsync(nameof(AuthorInfoPage));
            Shell.Current.FlyoutIsPresented = false;
        }
    }
}
