using Microsoft.Maui.Controls;
using KSM_ULS.Services;
using System.Threading.Tasks;

namespace KSM_ULS.Views
{
    public partial class ReportesGastosView : ContentView
    {
        public ReportesGastosView()
        {
            InitializeComponent();
            this.Loaded += async (_, __) => await CargarDesdeBDAsync();
        }

        /// <summary>
        /// Carga los datos de gastos (por categoría, totales mensuales, variaciones) desde la base de datos.
        /// </summary>
        private async Task CargarDesdeBDAsync()
        {
            try
            {
                var data = await DatabaseService.ObtenerDatosGastosAsync();
                EstadoLabel.Text = $"{data.Count} categorías de gasto cargadas.";
            }
            catch (Exception ex)
            {
                EstadoLabel.Text = $"Error al cargar gastos: {ex.Message}";
            }
        }
    }
}
