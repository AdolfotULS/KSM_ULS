using KSM_ULS.Views.TicketView;
using KSM_ULS.Model;
using System.Diagnostics;
namespace KSM_ULS.Views.TicketView;

public partial class ticketCardView : ContentView
{
	
	
	public ticketCardView()
	{
		
		InitializeComponent();
		
		
	}
	void onPickerSelectionStates(object sender, EventArgs e)
	{
		//change the state of the respective ticket
	}
    void onClickedEditTicketButton(object sender, EventArgs e) {
		//show popup menu with editable field for ticket
	}
	void onClickerDetailButton (object sender, EventArgs e) { 
		//show popup with all the details and notes of ticket
	}
}