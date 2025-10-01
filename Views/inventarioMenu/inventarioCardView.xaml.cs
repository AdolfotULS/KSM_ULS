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
	void onClickerAddButton( object sender, EventArgs e) { }
	void onClickedMinustButton( object sender, EventArgs e ) { }
	void onClickedEditButton( object sender, EventArgs e ) { }
}