using CommunityToolkit.Maui.Views;
using KSM_ULS.Model;

namespace KSM_ULS.Views.inventarioMenu.popUps;

public partial class InventarioDetailPopUp : Popup
{
	private Recurso resourceToEdit;
	public InventarioDetailPopUp()
	{
		InitializeComponent();
	}
	void OnClickedClosePopUp(object sender, EventArgs e)
	{
		this.CloseAsync();
	}
	void OnClickedEditResource(object sender, EventArgs e)
	{
		//primero valida las entrys y edita el ticket actual
	}
    private bool validateEntrys()
    {
        return true;
    }
}