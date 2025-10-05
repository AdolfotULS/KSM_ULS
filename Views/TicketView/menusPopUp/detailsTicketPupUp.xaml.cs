using CommunityToolkit.Maui.Views;
using System.ComponentModel;

namespace KSM_ULS.Views.TicketView.menusPopUp;

public partial class DetailsTicketPupUp : Popup, INotifyPropertyChanged
{


    private string clientName { get; set; }
	public DetailsTicketPupUp()
	{
		InitializeComponent();
        
        
	}

    void OnClickedClosePopUp(object sender, EventArgs e)
    {
        this.CloseAsync();
    }
}