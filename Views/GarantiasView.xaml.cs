using KSM_ULS.ViewModel;

namespace KSM_ULS.Views
{
    public partial class GarantiasView : ContentView

    {
        public GarantiasView()
        {
            InitializeComponent();

            // Asignamos el ViewModel correspondiente
            BindingContext = new GarantiasViewModel();
        }
    }
}
