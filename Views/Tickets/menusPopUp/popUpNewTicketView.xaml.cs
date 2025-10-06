using CommunityToolkit.Maui.Views;

namespace KSM_ULS.Views.Tickets;

public partial class PopUpNewTicketView : Popup
{
    public PopUpNewTicketView()
    {
        InitializeComponent();
    }
    void OnClickedClosePopUp(object sender, EventArgs e)
    {
        this.CloseAsync();
    }
    void OnClickedCreateTicket(object sender, EventArgs e)
    {

    }
}