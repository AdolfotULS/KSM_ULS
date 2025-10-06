using CommunityToolkit.Maui.Extensions;
using KSM_ULS.Model;
using KSM_ULS.Views.Inventario.popUps;
namespace KSM_ULS.Views.Inventario;

public partial class InventarioDashView : ContentView
{
	public InventarioDashView()
	{
		InitializeComponent();
		InventoryList.ItemsSource = new List<Recurso> {
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
	async void OnClickedAddIventory(object sender, EventArgs e) {
		var detailTicket = new InventarioAddPupUp();
		detailTicket.CanBeDismissedByTappingOutsideOfPopup = false;
		var pageReference = Shell.Current.CurrentPage;//rescata el elemento page actual para activar el popup desde hay
		await pageReference.ShowPopupAsync(detailTicket);
	}
	void OnChangeTextBarInventory(object sender, EventArgs e) { }
}