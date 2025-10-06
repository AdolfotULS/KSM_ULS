using CommunityToolkit.Maui.Extensions;
using KSM_ULS.Model;
using KSM_ULS.Views.Tickets;
using KSM_ULS.Views.Tickets.menusPopUp;
using System.Collections.ObjectModel;
using System.Diagnostics;
namespace KSM_ULS.Views.Tickets;

public partial class TicketCardView : ContentView
{
	public TicketOverView ReferenciaPadreView { get => (TicketOverView)GetValue(ParentView); set=>SetValue(ParentView, value); }
	public static readonly BindableProperty ParentView =
		BindableProperty.Create(nameof(ReferenciaPadreView), typeof(TicketOverView), typeof(TicketCardView), null);
    public ObservableCollection<Ticket> TicketsSource
    {
        get => (ObservableCollection<Ticket>)GetValue(TicketsSourceProperty);
        set => SetValue(TicketsSourceProperty, value);
    }

    public static readonly BindableProperty TicketsSourceProperty =
        BindableProperty.Create(nameof(TicketsSource), typeof(ObservableCollection<Ticket>), typeof(TicketCardView), null);
    private int ticketIndex;
    private Ticket ticketData;
	public TicketCardView()
	{
		
		InitializeComponent();
		BindingContextChanged += SetDataInLabels;
		
		
		
	}
	private void SetDataInLabels(object sender, EventArgs e) {

		if (BindingContext is Ticket ticket && TicketsSource != null)
		{
			
			this.ticketIndex = TicketsSource.IndexOf(ticket);
            this.ticketData = ticket;
			this.ticketName.Text = ticket.Id.ToString();
			this.TicketClientName.Text = ticket.ClientName;
			this.TicketTecnitianName.Text = ticket.TecnitianNames;
			this.TicketLimitDate.Text = ticket.LimitDate;
			this.TicketStateLabel.Text = ticket.GetState();
			this.TicketPriorityLabel.Text = ticket.GetPrioriry();
			this.TickeAmountRemuneration.Text = ticket.ExpectedRemuneration.ToString();
			this.TicketDescription.Text = ticket.Description;
		}
	}

	async void OnPickerSelectionStates(object sender, EventArgs e)
	{
        //change the state of the respective ticket
        var picker = (Picker)sender;
        int selectedIndex = picker.SelectedIndex;

		switch (selectedIndex) {
			case 0:
				this.ticketData.ChangeStateTicket("finalized");
				this.TicketStateLabel.Text = "Finalizado";
                break;
			case 1:
                this.ticketData.ChangeStateTicket("pending");
                this.TicketStateLabel.Text = "Pendiente";
                break;
			case 2:
                this.ticketData.ChangeStateTicket("in progress");
                this.TicketStateLabel.Text = "En Progreso";
                break;
                ReferenciaPadreView.ActualizarElemento(ticketData,this.ticketIndex);
        }
    }
	async void OnClickedEditTicketButton(object sender, EventArgs e) {
		//show popup menu with editable field for ticket

		var editTicket = new EditTicketPupUp(ticketData,this.ticketIndex,this.ReferenciaPadreView);
		editTicket.CanBeDismissedByTappingOutsideOfPopup = false;
		var pageReference = Shell.Current.CurrentPage;//rescata el elemento page actual para activar el popup desde hay
		await pageReference.ShowPopupAsync(editTicket);
	}
	async void OnClickerDetailButton (object sender, EventArgs e) {
		//show popup with all the details and notes of ticket
		var detailTicket = new DetailsTicketPupUp(ticketData);
		detailTicket.CanBeDismissedByTappingOutsideOfPopup = false;
		var pageReference = Shell.Current.CurrentPage;//rescata el elemento page actual para activar el popup desde hay
		await pageReference.ShowPopupAsync(detailTicket);
	}
}