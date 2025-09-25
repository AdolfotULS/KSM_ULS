using CommunityToolkit.Maui.Views;

namespace KSM_ULS.Views.Config_options;

public partial class popUpConfig : Popup
{
	public popUpConfig()
	{
		InitializeComponent();
	}
	void onClickButton1(object sender, EventArgs e) { }//cambiar nombre a uso respectivo

    void onClickButton2(object sender, EventArgs e) { }//cambiar nombre a uso respectivo

    void onClickButton3(object sender, EventArgs e) { }//cambiar nombre a uso respectivo
    
    void onClickClosePopUp(object sender, EventArgs e) {
		CloseAsync(); //cierra el pup up apropiadamente
	}
}