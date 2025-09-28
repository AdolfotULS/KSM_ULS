using CommunityToolkit.Maui.Views;

namespace KSM_ULS.Views.TicketView;

public partial class popUpNewTicketView : Popup
{
	public popUpNewTicketView()
	{
		InitializeComponent();
	}
    void onClickedClosePopUp(object sender, EventArgs e)
    {
        this.CloseAsync();
    }
}