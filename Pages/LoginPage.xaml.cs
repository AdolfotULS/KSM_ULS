namespace KSM_ULS.Pages;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private async void OnLoginClicked(object sender, EventArgs e)
    {
        try
        {
            Busy.IsVisible = Busy.IsRunning = true;
            ErrorLabel.Text = string.Empty;

            var user = UserEntry.Text?.Trim();
            var pass = PassEntry.Text;

            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass))
            {
                ErrorLabel.Text = "Completa usuario y contraseña";
                return;
            }

            //var ok = await _auth.LoginAsync(user, pass);
            var ok = user == "admin" && pass == "admin";
            if (!ok) { ErrorLabel.Text = "Credenciales inválidas"; return; }

            Preferences.Set("IsLoggedIn", true);


            // Solo navega a AppShell
            Application.Current.MainPage = new AppShell();

        }
        catch (Exception ex) { ErrorLabel.Text = ex.Message; }
        finally { Busy.IsVisible = Busy.IsRunning = false; }
    }
}