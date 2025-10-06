using CommunityToolkit.Maui.Extensions;
using KSM_ULS.Model;
using KSM_ULS.Views.Tickets;
using KSM_ULS.Views.Tickets.menusPopUp;
using System.Diagnostics;
namespace KSM_ULS.Views.Tickets;

public partial class TicketCardView : ContentView
{
	
	private Ticket ticketData;
	public TicketCardView()
	{
		
		InitializeComponent();
		BindingContextChanged += SetDataInLabels;
		
		
		
	}
	private void SetDataInLabels(object sender, EventArgs e) {

		if (BindingContext is Ticket ticket)
		{
			this.TicketClientName.Text = ticket.ClientName;
			this.TicketTecnitianName.Text = ticket.TecnitianNames;
			this.TicketLimitDate.Text = ticket.LimitDate;
			this.TickeAmountRemuneration.Text = ticket.ExpectedRemuneration.ToString();
		}
	}

	void OnPickerSelectionStates(object sender, EventArgs e)
	{
		//change the state of the respective ticket
	}
	async void OnClickedEditTicketButton(object sender, EventArgs e) {
		//show popup menu with editable field for ticket

		var editTicket = new EditTicketPupUp();
		editTicket.CanBeDismissedByTappingOutsideOfPopup = false;
		var pageReference = Shell.Current.CurrentPage;//rescata el elemento page actual para activar el popup desde hay
		await pageReference.ShowPopupAsync(editTicket);
	}
	async void OnClickerDetailButton (object sender, EventArgs e) {
		//show popup with all the details and notes of ticket
		var detailTicket = new DetailsTicketPupUp();
		detailTicket.CanBeDismissedByTappingOutsideOfPopup = false;
		var pageReference = Shell.Current.CurrentPage;//rescata el elemento page actual para activar el popup desde hay
		await pageReference.ShowPopupAsync(detailTicket);
	}
}