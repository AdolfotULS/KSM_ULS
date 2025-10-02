using CommunityToolkit.Maui.Views;
using KSM_ULS.Model;

namespace KSM_ULS.Views.inventarioMenu.popUps;

public partial class inventarioDetailPopUp : Popup
{
	private Recurso resourceToEdit;
	public inventarioDetailPopUp()
	{
		InitializeComponent();
	}
	void onClickedClosePopUp(object sender, EventArgs e)
	{
		this.CloseAsync();
	}
	void onClickedEditResource(object sender, EventArgs e)
	{
		//primero valida las entrys y edita el ticket actual
	}
    private bool validateEntrys()
    {
        return true;
    }
}