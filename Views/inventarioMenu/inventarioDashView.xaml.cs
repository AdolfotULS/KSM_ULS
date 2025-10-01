using KSM_ULS.Model;
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
            new Recurso("jerico")
        };
		
	}
	void onClickedAddIventory(object sender, EventArgs e) { }
	void onChangeTextBarInventory(object sender, EventArgs e) { }
}