

namespace KSM_ULS
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            if (Application.Current.UserAppTheme == null)
            {
                Application.Current.UserAppTheme = AppTheme.Light;
            }
            // Uncomment and use the following logic if you want to show LoginPage when not logged in:
            // var logged = Preferences.Get("IsLoggedIn", false);
            // MainPage = logged ? new AppShell() : new Pages.LoginPage();
            // Otherwise, you can set MainPage directly to AppShell if login is not required:
            // MainPage = new AppShell();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            // Ensure the main page is set for the window
            return new Window(new Pages.LoginPage());
        }
    }
}