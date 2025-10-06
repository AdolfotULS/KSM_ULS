using CommunityToolkit.Maui.Views;
using KSM_ULS.Model;
namespace KSM_ULS.Views.Tickets.menusPopUp;

public partial class EditTicketPupUp : Popup
{
    private int indexTicket;
    private TicketOverView referenciaPadreView;

    private Ticket TicketQueSeRepresenta;
	public EditTicketPupUp(Ticket refTicketIn, int indexTicket, TicketOverView referenciaView)
	{
        this.referenciaPadreView = referenciaView;
        this.indexTicket = indexTicket;
		this.TicketQueSeRepresenta = refTicketIn;
		InitializeComponent();
        SetDataInLabels();

    }
    private void SetDataInLabels()
    {


        this.idNameLabel.Text = TicketQueSeRepresenta.Id.ToString();
            this.clientNameLabel.Text = TicketQueSeRepresenta.ClientName;
            this.TecnitiansLabel.Text = TicketQueSeRepresenta.TecnitianNames;
            this.limitDateLabel.Text = TicketQueSeRepresenta.LimitDate;
            this.remunareationLabel.Text = TicketQueSeRepresenta.ExpectedRemuneration.ToString();
            this.textBlockMainDescription.Text = TicketQueSeRepresenta.Description;
        
    }
    void OnClickedClosePopUp(object sender, EventArgs e)
	{
		this.CloseAsync();
	}
	void OnClickedEditTicket(object sender, EventArgs e){
        if (DatosValidos())
        {
            this.TicketQueSeRepresenta.ClientName = this.clientNameLabel.Text;
            this.TicketQueSeRepresenta.TecnitianNames = this.TecnitiansLabel.Text;
            this.TicketQueSeRepresenta.LimitDate = this.limitDateLabel.Text;
            this.TicketQueSeRepresenta.ExpectedRemuneration = int.Parse(this.remunareationLabel.Text);
            this.TicketQueSeRepresenta.Description = this.textBlockMainDescription.Text;

            referenciaPadreView.ActualizarElemento(this.TicketQueSeRepresenta,this.indexTicket);

            this.CloseAsync();
        }
	}
    private bool DatosValidos() { return true; }
}