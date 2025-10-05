using CommunityToolkit.Maui.Views;
using System.ComponentModel;

namespace KSM_ULS.Views.Tickets.menusPopUp;

public partial class DetailsTicketPupUp : Popup, INotifyPropertyChanged
{


    private string ClientName { get; set; }
	public DetailsTicketPupUp()
	{
		InitializeComponent();
        
        
	}

    void OnClickedClosePopUp(object sender, EventArgs e)
    {
        this.CloseAsync();
    }
}