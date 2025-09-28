using CommunityToolkit.Maui.Views;
using System.ComponentModel;

namespace KSM_ULS.Views.TicketView.menusPopUp;

public partial class detailsTicketPupUp : Popup, INotifyPropertyChanged
{


    private string clientName { get; set; }
	public detailsTicketPupUp()
	{
		InitializeComponent();
        
        
	}

    void onClickedClosePopUp(object sender, EventArgs e)
    {
        this.CloseAsync();
    }
}