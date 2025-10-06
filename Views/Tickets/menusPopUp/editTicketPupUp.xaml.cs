using CommunityToolkit.Maui.Views;

namespace KSM_ULS.Views.Tickets.menusPopUp;

public partial class EditTicketPupUp : Popup
{
	public EditTicketPupUp()
	{
		InitializeComponent();
	}
	void OnClickedClosePopUp(object sender, EventArgs e)
	{
		this.CloseAsync();
	}
	void OnClickedEditTicket(object sender, EventArgs e){
	}
}