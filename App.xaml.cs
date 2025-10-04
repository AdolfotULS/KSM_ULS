

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
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new Pages.LoginPage());
        }
    }
}