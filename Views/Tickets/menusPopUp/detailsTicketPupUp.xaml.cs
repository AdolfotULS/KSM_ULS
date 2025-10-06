using CommunityToolkit.Maui.Views;
using System.ComponentModel;
using KSM_ULS.Model;
namespace KSM_ULS.Views.Tickets.menusPopUp;

public partial class DetailsTicketPupUp : Popup, INotifyPropertyChanged
{
    private Ticket TicketQueSeReferencia;

    private string ClientName { get; set; }
	public DetailsTicketPupUp(Ticket ticketIn)
	{
        this.TicketQueSeReferencia = ticketIn;
		InitializeComponent();
        SetDataInLabels();
    }
    private void SetDataInLabels()
    {


        this.IdNameLabel.Text = TicketQueSeReferencia.Id.ToString();
        this.ClientNameLabel.Text = TicketQueSeReferencia.ClientName;
        this.TecnitiansLabel.Text = TicketQueSeReferencia.TecnitianNames;
        this.LimitDateLabel.Text = TicketQueSeReferencia.LimitDate;
        this.remunareationLabel.Text = TicketQueSeReferencia.ExpectedRemuneration.ToString();
        this.TextBlockMainDescription.Text = TicketQueSeReferencia.Description;

    }
    void OnClickedClosePopUp(object sender, EventArgs e)
    {
        this.CloseAsync();
    }
}