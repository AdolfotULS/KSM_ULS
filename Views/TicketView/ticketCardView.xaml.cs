using CommunityToolkit.Maui.Extensions;
using KSM_ULS.Model;
using KSM_ULS.Views.TicketView;
using KSM_ULS.Views.TicketView.menusPopUp;
using System.Diagnostics;
namespace KSM_ULS.Views.TicketView;

public partial class ticketCardView : ContentView
{
	
	private Ticket ticketData;
	public ticketCardView()
	{
		
		InitializeComponent();
        BindingContextChanged += setDataInLabels;
		
		
		
	}
	private void setDataInLabels(object sender, EventArgs e) {

        if (BindingContext is Ticket ticket)
        {
            this.ticketClientName.Text = ticket.clientName;
            this.ticketTecnitianName.Text = ticket.tecnitianNames;
            this.ticketLimitDate.Text = ticket.limitDate;
            this.tickeAmountRemuneration.Text = ticket.expectedRemuneration.ToString();
        }
    }

	void onPickerSelectionStates(object sender, EventArgs e)
	{
		//change the state of the respective ticket
	}
    async void onClickedEditTicketButton(object sender, EventArgs e) {
        //show popup menu with editable field for ticket

        var editTicket = new editTicketPupUp();
		editTicket.CanBeDismissedByTappingOutsideOfPopup = false;
        var pageReference = Shell.Current.CurrentPage;//rescata el elemento page actual para activar el popup desde hay
        await pageReference.ShowPopupAsync(editTicket);
    }
	async void onClickerDetailButton (object sender, EventArgs e) {
        //show popup with all the details and notes of ticket
        var detailTicket = new detailsTicketPupUp();
		detailTicket.CanBeDismissedByTappingOutsideOfPopup = false;
        var pageReference = Shell.Current.CurrentPage;//rescata el elemento page actual para activar el popup desde hay
        await pageReference.ShowPopupAsync(detailTicket);
    }
}