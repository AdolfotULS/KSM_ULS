using Microsoft.Maui.Controls;
using KSM_ULS.Services;
using System.Threading.Tasks;

namespace KSM_ULS.Views
{
    public partial class ReportesFinancieroView : ContentView
    {
        public ReportesFinancieroView()
        {
            InitializeComponent();
            this.Loaded += async (_, __) => await CargarDesdeBDAsync();
        }

        /// <summary>
        /// Carga los datos financieros (ingresos, egresos, balances) desde la base de datos.
        /// </summary>
        private async Task CargarDesdeBDAsync()
        {
            try
            {
                var data = await DatabaseService.ObtenerDatosFinancierosAsync();
                EstadoLabel.Text = $"{data.Count} registros financieros cargados.";
            }
            catch (Exception ex)
            {
                EstadoLabel.Text = $"Error al cargar: {ex.Message}";
            }
        }
    }
}
