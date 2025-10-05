using CommunityToolkit.Maui.Extensions;
using KSM_ULS.Views.inventarioMenu.popUps;
using KSM_ULS.Model;

namespace KSM_ULS.Views.inventarioMenu;

public partial class InventarioCardView : ContentView
{
	public InventarioCardView()
	{
		InitializeComponent();
		BindingContextChanged += setDataLabels;
	}
	private void setDataLabels( object sender, EventArgs e)
	{
		if (BindingContext is Recurso recurso) {
			this.resourceName.Text = recurso.Name;
		}
	}
	void OnClickerAddButton( object sender, EventArgs e) {
		//añade al stock
	}
	void OnClickedMinustButton( object sender, EventArgs e ) {
		//resta al stock
	}
	async void OnClickedEditButton( object sender, EventArgs e ) {
        var detailTicket = new InventarioDetailPopUp();
        detailTicket.CanBeDismissedByTappingOutsideOfPopup = false;
        var pageReference = Shell.Current.CurrentPage;//rescata el elemento page actual para activar el popup desde hay
        await pageReference.ShowPopupAsync(detailTicket);
    }
}