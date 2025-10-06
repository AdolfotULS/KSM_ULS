using CommunityToolkit.Maui.Views;
using KSM_ULS.Model;
namespace KSM_ULS.Views.Inventario.popUps;

public partial class InventarioAddPupUp : Popup
{
	private Recurso nuevoRecurso;
	public InventarioAddPupUp()
	{
		InitializeComponent();
	}
	void OnClickedClosePopUp(object sender, EventArgs e)
	{
		this.CloseAsync();
	}
	void OnClickedCreateResource(object sender, EventArgs e)
	{

		//aqui lee los datos de entrys Y crea el recurso que tiene este y actualiza BD

	}
	private bool ValidateEntrys()
	{
		return true;
	}
}