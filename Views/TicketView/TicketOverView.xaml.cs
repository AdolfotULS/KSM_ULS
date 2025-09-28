
using CommunityToolkit.Maui.Extensions;
using KSM_ULS.Model;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
namespace KSM_ULS.Views.TicketView;

public partial class TicketOverView : ContentView
{
    private string searchQueryText ;
    private string searchSolicitude;
    private List<Ticket> ticketsUsuario { get; set; }
    public TicketOverView()
    {
        
        InitializeComponent();


        ticketList.ItemsSource = new List<Ticket> {
                new Ticket(2,"cliente1",new string[]{"tec1"}),
                new Ticket(5,"cliente2",new string[]{"tec2"}),
                new Ticket(1,"cliente1",new string[]{"tec3"}),
                new Ticket(3,"cliente3",new string[]{"tec2"}),
                new Ticket(4,"trol",new string[]{"hacked"}),
                new Ticket(4,"trol",new string[]{"hacked"}),
                new Ticket(4,"trol",new string[]{"hacked"}),
                new Ticket(4,"trol",new string[]{"hacked"}),
                new Ticket(4,"trol",new string[]{"hacked"}),
                new Ticket(4,"trol",new string[]{"hacked"}),
                new Ticket(4,"trol",new string[]{"hacked"}),
                new Ticket(4,"trol",new string[]{"hacked"}),
                new Ticket(4,"trol",new string[]{"hacked"}),
                new Ticket(4,"trol",new string[]{"hacked"}),
                new Ticket(4,"trol",new string[]{"hacked"}),
                new Ticket(4,"trol",new string[]{"hacked"})
            };
        BindingContext = this;

	}

    void onChangeTextSearchBarTickets(object sender, TextChangedEventArgs eventData)
    {
        //en caso de que se escriba algun dato de un ticket que muestre aquellos que coinciden
        this.searchQueryText = eventData.NewTextValue; //this read the searcbox 
        
    }
    
    async void onClickedButtonNewTicketCreation(object sender, EventArgs e)
    {
        //aparece un pop up que genera una ventana para llenar datos de nuevo ticket

        //TODO revisar esta logica
        var popUpNewTicket = new popUpNewTicketView();
        var pageReference = Shell.Current.CurrentPage;//rescata el elemento page actual para activar el popup desde hay
        await pageReference.ShowPopupAsync(popUpNewTicket);
    }

}