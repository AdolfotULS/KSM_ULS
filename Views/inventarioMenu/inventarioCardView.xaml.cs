using CommunityToolkit.Maui.Extensions;
using KSM_ULS.Views.inventarioMenu.popUps;
using KSM_ULS.Model;

namespace KSM_ULS.Views.inventarioMenu;

public partial class inventarioCardView : ContentView
{
	public inventarioCardView()
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
	void onClickerAddButton( object sender, EventArgs e) {
		//añade al stock
	}
	void onClickedMinustButton( object sender, EventArgs e ) {
		//resta al stock
	}
	async void onClickedEditButton( object sender, EventArgs e ) {
        var detailTicket = new inventarioDetailPopUp();
        detailTicket.CanBeDismissedByTappingOutsideOfPopup = false;
        var pageReference = Shell.Current.CurrentPage;//rescata el elemento page actual para activar el popup desde hay
        await pageReference.ShowPopupAsync(detailTicket);
    }
}