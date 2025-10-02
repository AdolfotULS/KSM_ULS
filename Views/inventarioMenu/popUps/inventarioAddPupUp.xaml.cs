using CommunityToolkit.Maui.Views;
using KSM_ULS.Model;
namespace KSM_ULS.Views.inventarioMenu.popUps;

public partial class inventarioAddPupUp : Popup
{
	private Recurso nuevoRecurso;
	public inventarioAddPupUp()
	{
		InitializeComponent();
	}
	void onClickedClosePopUp(object sender, EventArgs e)
	{
		this.CloseAsync();
	}
	void onClickedCreateResource(object sender, EventArgs e)
	{

		//aqui lee los datos de entrys Y crea el recurso que tiene este y actualiza BD

	}
	private bool validateEntrys()
	{
		return true;
	}
}