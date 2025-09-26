using KSM_ULS.Views.TicketView;
using KSM_ULS.Model;
using System.Diagnostics;
namespace KSM_ULS.Views.TicketView;

public partial class ticketCardView : ContentView
{
	
	public ticketCardView()
	{
		Debug.WriteLine("Test");
		InitializeComponent();
		
		
	}
    void onClickedEditTicketButton(object sender, EventArgs e) { }
}