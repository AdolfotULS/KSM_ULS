using Microsoft.Maui.Storage;

namespace KSM_ULS
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new Pages.LoginPage();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(MainPage ?? new AppShell());
        }
    }
}