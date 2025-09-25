using CommunityToolkit.Maui.Extensions;
using KSM_ULS.Views.Config_options;
using System.Threading.Tasks;

namespace KSM_ULS.Pages;

public partial class DashboardPage : ContentPage
{
	public DashboardPage()
	{
		InitializeComponent();
        // Subvista por defecto
        Host.Content = new Views.DashOverviewView();
    }

    void OnResumenClicked(object sender, EventArgs e) => Host.Content = new Views.DashOverviewView();

    void OnClientesClicked(object sender, EventArgs e) => Host.Content = new Views.DashClientsView();
    //void OnReportesClicked(object sender, EventArgs e) => Host.Content = new Views.DashReportsView();
    void OnGarantiasClicked(object sender, EventArgs e)
    {
        var garantiasPage = new Pages.GarantiasPage();
        Host.Content = garantiasPage.Content;
    }

    async void OnConfigClicked(object sender, EventArgs e)
    {
        var popupConfigMenu = new popUpConfig(); //abre un menu pop up para la configuracion
        await this.ShowPopupAsync(popupConfigMenu);
    }
    // Cuando se presiona el boton de config abre menu popup con todas las opciones de configuracion respectivas 

    void OnCloseSessionClicked(object sender, EventArgs e) {
        Application.Current.MainPage = new LoginPage(); // entra al Dashboard
    }

    private void Button_Clicked(object sender, EventArgs e)
    {

    }
    //cierra sesion -- envia al usuario a la pantalla de login
    // considerar, que tenemos que borrar cualquier credencial de usuario de sale de la cuenta
}