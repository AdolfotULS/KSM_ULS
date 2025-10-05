using Microsoft.Maui.Controls;
using KSM_ULS.ViewModel;

namespace KSM_ULS.Views
{
    public partial class ReportesView : ContentView
    {
        private ReportesViewModel _vm;

        public ReportesView()
        {
            InitializeComponent();
            _vm = new ReportesViewModel(this);
            BindingContext = _vm;
            CambiarVista("Financiero");
        }

        public void CambiarVista(string vista)
        {
            View contenido = vista switch
            {
                "Financiero" => new ReportesFinancieroView(),
                "Operaciones" => new ReportesOperacionesView(),
                "Rendimiento" => new ReportesRendimientoView(),
                "Gastos" => new ReportesGastosView(),
                _ => new Label
                {
                    Text = "Vista no encontrada",
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.Center
                }
            };

            contenido.BindingContext = this.BindingContext;
            ContenidoActual.Content = contenido;
        }
    }
}
