using Microsoft.Maui.Controls;
using KSM_ULS.Services;
using System.Threading.Tasks;

namespace KSM_ULS.Views
{
    public partial class ReportesOperacionesView : ContentView
    {
        public ReportesOperacionesView()
        {
            InitializeComponent();
            this.Loaded += async (_, __) => await CargarDesdeBDAsync();
        }

        /// <summary>
        /// Carga los datos de operaciones (tickets, servicios, procesos) desde la base de datos.
        /// </summary>
        private async Task CargarDesdeBDAsync()
        {
            try
            {
                var data = await DatabaseService.ObtenerDatosOperacionesAsync();
                EstadoLabel.Text = $" {data.Count} operaciones encontradas.";
            }
            catch (Exception ex)
            {
                EstadoLabel.Text = $"Error al cargar operaciones: {ex.Message}";
            }
        }
    }
}
