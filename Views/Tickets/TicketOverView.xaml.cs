
using CommunityToolkit.Maui.Extensions;
using KSM_ULS.Model;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
namespace KSM_ULS.Views.Tickets;

public partial class TicketOverView : ContentView
{
	private string searchQueryText ;
	
	private List<Ticket> ticketsUsuario { get; set; }
		public TicketOverView()
		{
		
			InitializeComponent();

			BindingContext = this;
			TicketList.ItemsSource = new List<Ticket> {
					new Ticket(2,"cliente1","tec1"),
					new Ticket(5,"cliente2","tec2"),
					new Ticket(1,"cliente1","tec3"),
					new Ticket(3,"cliente3","tec2"),
					new Ticket(4,"trol","hacked"),
					new Ticket(4,"trol","hacked"),
					new Ticket(4,"trol","hacked"),
					new Ticket(4,"trol","hacked"),
					new Ticket(4,"trol","hacked"),
					new Ticket(4,"trol","hacked"),
					new Ticket(4,"trol","hacked"),
					new Ticket(4,"trol","hacked")
				
				};
		

		}

	void OnChangeTextSearchBarTickets(object sender, TextChangedEventArgs eventData)
	{
		//en caso de que se escriba algun dato de un ticket que muestre aquellos que coinciden
		this.searchQueryText = eventData.NewTextValue; //this read the searcbox 
		
	}
	
	async void OnClickedButtonNewTicketCreation(object sender, EventArgs e)
	{
		//aparece un pop up que genera una ventana para llenar datos de nuevo ticket

		//TODO revisar esta logica
		var popUpNewTicket = new PopUpNewTicketView();
		popUpNewTicket.CanBeDismissedByTappingOutsideOfPopup = false;
		var pageReference = Shell.Current.CurrentPage;//rescata el elemento page actual para activar el popup desde hay
		await pageReference.ShowPopupAsync(popUpNewTicket);
	}

}