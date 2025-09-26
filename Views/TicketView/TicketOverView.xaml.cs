using KSM_ULS.Model;
using System.Collections.ObjectModel;
using System.Security.Cryptography.X509Certificates;
namespace KSM_ULS.Views.TicketView;

public partial class TicketOverView : ContentView
{
    private List<Ticket> ticketsUsuario { get; set; }
    public TicketOverView()
    {
        
        InitializeComponent();


        ticketList.ItemsSource = new List<Ticket> {
                new Ticket { clientName="bla", limitDate="blew" },
                new Ticket { clientName="bla1", limitDate="blew1" },
                new Ticket {  clientName="bla2", limitDate="blew2"}
            };
        BindingContext = this;

	}
   
}