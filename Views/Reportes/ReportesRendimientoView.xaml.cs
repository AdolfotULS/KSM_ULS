using Microsoft.Maui.Controls;
using KSM_ULS.Services;
using System.Threading.Tasks;

namespace KSM_ULS.Views
{
    public partial class ReportesRendimientoView : ContentView
    {
        public ReportesRendimientoView()
        {
            InitializeComponent();
            this.Loaded += async (_, __) => await CargarDesdeBDAsync();
        }

        /// <summary>
        /// Carga los datos de rendimiento (productividad de técnicos, tiempos promedio, calificaciones) desde la base de datos.
        /// </summary>
        private async Task CargarDesdeBDAsync()
        {
            try
            {
                var data = await DatabaseService.ObtenerDatosRendimientoAsync();
                EstadoLabel.Text = $"{data.Count} métricas de rendimiento cargadas.";
            }
            catch (Exception ex)
            {
                EstadoLabel.Text = $"Error al cargar rendimiento: {ex.Message}";
            }
        }
    }
}
