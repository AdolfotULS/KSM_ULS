using CommunityToolkit.Maui.Views;

namespace KSM_ULS.Views.TicketView.menusPopUp;

public partial class editTicketPupUp : Popup
{
	public editTicketPupUp()
	{
		InitializeComponent();
	}
	void onClickedClosePopUp(object sender, EventArgs e)
	{
		this.CloseAsync();
	}
}