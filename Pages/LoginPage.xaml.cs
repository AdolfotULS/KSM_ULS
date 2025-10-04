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
			// Mostrar indicador de carga
			Busy.IsVisible = Busy.IsRunning = true;
			ErrorLabel.Text = string.Empty;

			var user = UserEntry.Text?.Trim();
			var pass = PassEntry.Text;

			// Validar campos vacíos
			if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass))
			{
				ErrorLabel.Text = "Completa email y contraseña";
				return;
			}

			// Validar formato de email
			if (!ValidarEmail(user))
			{
				ErrorLabel.Text = "Formato de email inválido";
				return;
			}

			// Validar inyección SQL
			if (SQLInjectionCheck(user) || SQLInjectionCheck(pass))
			{
				ErrorLabel.Text = "Entrada inválida detectada";
				return;
			}

			// TODO: Implementar autenticación real

			// var ok = await _auth.LoginAsync(user, pass);
			/*var ok = user == "admin" && pass == "admin";
			if (!ok)
			{
				ErrorLabel.Text = "Credenciales inválidas";
				return;
			}
*/
			// Guardar estado de sesión y navegar al Dashboard
			Preferences.Set("IsLoggedIn", true);
			Application.Current.MainPage = new AppShell();
		}
		catch (Exception ex)
		{
			ErrorLabel.Text = ex.Message;
		}
		finally
		{
			// Ocultar indicador de carga
			Busy.IsVisible = Busy.IsRunning = false;
		}
	}


	private bool ValidarEmail(string email)
	{
		if (string.IsNullOrWhiteSpace(email))
			return false;

		// Validación adicional con Regex para formato de email
		string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
		if (!System.Text.RegularExpressions.Regex.IsMatch(email, pattern))
			return false;

		try
		{
			var addr = new System.Net.Mail.MailAddress(email);
			return addr.Address == email;
		}
		catch
		{
			return false;
		}
	}

	private bool SQLInjectionCheck(string input)
	{
		// Patrón simple para detectar intentos comunes de inyección SQL
		string pattern = @"('|--|;|/\*|\*/|xp_)";
		return System.Text.RegularExpressions.Regex.IsMatch(input, pattern, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
	}

	void OnForgotTapped(object sender, EventArgs e)
	{
		DisplayAlert("Recuperar Contraseña", "Contacte a soporte para asistencia.", "OK");
	}
}