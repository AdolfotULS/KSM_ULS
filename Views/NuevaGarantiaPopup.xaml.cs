using CommunityToolkit.Maui.Views;
using System.Windows.Input;

namespace KSMULS.Views
{
    public partial class NuevaGarantiaPopup : Popup
    {
        public ICommand CloseCommand { get; private set; }


        /*
        Objetivo: constructor de la ventana emergente para crear una nueva garantía.
        
     
         
         */
        public NuevaGarantiaPopup()
        {
            InitializeComponent();
            CloseCommand = new Command(() => CloseAsync());
            BindingContext = this;
        }
    }
}
