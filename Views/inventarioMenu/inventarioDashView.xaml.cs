using CommunityToolkit.Maui.Extensions;
using KSM_ULS.Model;
using KSM_ULS.Views.inventarioMenu.popUps;
namespace KSM_ULS.Views.inventarioMenu;

public partial class inventarioDashView : ContentView
{
	public inventarioDashView()
	{
        InitializeComponent();
        inventoryList.ItemsSource = new List<Recurso> {
			new Recurso("patata"),
            new Recurso("cebolla"),
            new Recurso("lechuga"),
            new Recurso("lechuga"),
            new Recurso("lechuga"),
            new Recurso("lechuga"),
            new Recurso("lechuga"),
            new Recurso("lechuga"),
            new Recurso("lechuga"),
            new Recurso("lechuga"),
            new Recurso("lechuga"),
            new Recurso("lechuga"),
            new Recurso("lechuga"),
            new Recurso("lechuga"),
            new Recurso("lechuga"),
            new Recurso("lechuga"),
            new Recurso("lechuga"),
            new Recurso("lechuga"),
            new Recurso("lechuga"),
            new Recurso("lechuga"),
            new Recurso("lechuga"),
            new Recurso("lechuga"),
            new Recurso("lechuga"),
            new Recurso("jerico")
        };
		
	}
	async void onClickedAddIventory(object sender, EventArgs e) {
        var detailTicket = new inventarioAddPupUp();
        detailTicket.CanBeDismissedByTappingOutsideOfPopup = false;
        var pageReference = Shell.Current.CurrentPage;//rescata el elemento page actual para activar el popup desde hay
        await pageReference.ShowPopupAsync(detailTicket);
    }
	void onChangeTextBarInventory(object sender, EventArgs e) { }
}