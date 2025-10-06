using CommunityToolkit.Maui.Views;
using KSM_ULS.Model;
using KSM_ULS.Views.Tickets;
using System.Collections.ObjectModel;

namespace KSM_ULS.Views.Tickets;

public partial class PopUpNewTicketView : Popup
{
    private ObservableCollection<Ticket> _ticketList;
    private TicketOverView referenciaPadreView;
    public PopUpNewTicketView(ObservableCollection<Ticket> ListaEntrada, TicketOverView overViewPadre)
    {
        this.referenciaPadreView = overViewPadre;
        InitializeComponent();
        this._ticketList= ListaEntrada;

    }
    void OnClickedClosePopUp(object sender, EventArgs e)
    {
        this.CloseAsync();
    }
    void OnClickedCreateTicket(object sender, EventArgs e)
    {
        string clienName = this.ClientNameLabel.Text;
        string tecnitianName = this.TecnitiansLabel.Text;
        string limitDate = this.LimitDateLabel.Text;
        string idName = this.IdNameLabel.Text;
        string extra = this.ExtraLabel.Text;
        string fechaEmision = this.EmisionDateLabel.Text;
        string descripcion = this.TextBlockMainDescription.Text;
        string date = DateTime.Now.ToString();

        if (VerificarCampos())
        {
            Ticket NuevoTicket = new Ticket(int.Parse(idName),clienName,tecnitianName,date,descripcion);
            this._ticketList.Add(NuevoTicket);
            referenciaPadreView.ActualizarLista(this._ticketList);
            this.CloseAsync();
        }
    }
    private bool VerificarCampos()
    {
        string clienName = this.ClientNameLabel.Text;
        string tecnitianName = this.TecnitiansLabel.Text;
        string limitDate = this.LimitDateLabel.Text;
        string idName = this.IdNameLabel.Text;
        string extra = this.ExtraLabel.Text;
        string fechaEmision = this.EmisionDateLabel.Text;
        string descripcion = this.TextBlockMainDescription.Text;
        return true;
    }
}