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
    void onTicketsClicked(object sender, EventArgs e) => Host.Content = new Views.TicketView.TicketOverView();
}