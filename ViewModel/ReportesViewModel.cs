using System.Collections.ObjectModel;
using System.Windows.Input;
using Microsoft.Maui.Controls;
using KSM_ULS.Model;
using KSM_ULS.Views;
using System.Threading.Tasks;

namespace KSM_ULS.ViewModel
{
    public class ReportesViewModel : BindableObject
    {
        private readonly ReportesView _view;

        // === Estados de navegación ===
        private bool _isFinanciero;
        private bool _isOperaciones;
        private bool _isRendimiento;
        private bool _isGastos;

        public bool IsFinanciero { get => _isFinanciero; set { _isFinanciero = value; OnPropertyChanged(); } }
        public bool IsOperaciones { get => _isOperaciones; set { _isOperaciones = value; OnPropertyChanged(); } }
        public bool IsRendimiento { get => _isRendimiento; set { _isRendimiento = value; OnPropertyChanged(); } }
        public bool IsGastos { get => _isGastos; set { _isGastos = value; OnPropertyChanged(); } }

        // === Rango temporal ===
        public ObservableCollection<string> RangosDisponibles { get; } = new()
        {
            "Último mes",
            "Últimos 3 meses",
            "Año completo"
        };

        private string _rangoSeleccionado = "Último mes";
        public string RangoSeleccionado
        {
            get => _rangoSeleccionado;
            set
            {
                _rangoSeleccionado = value;
                OnPropertyChanged();
                ActualizarRango();
            }
        }

        // === Datos del resumen ===
        public ReportesResumen Resumen { get; set; } = new();

        // === Colecciones para gráficas ===
        public ObservableCollection<ReportePunto> IngresosMensuales { get; set; } = new();
        public ObservableCollection<ReportePunto> TicketsMensuales { get; set; } = new();
        public ObservableCollection<TecnicoRendimiento> RendimientoTecnicos { get; set; } = new();
        public ObservableCollection<GastoCategoria> GastosPorCategoria { get; set; } = new();

        // === Comandos ===
        public ICommand CambiarVistaCommand { get; }

        // === Constructor ===
        public ReportesViewModel(ReportesView view)
        {
            _view = view;
            CambiarVistaCommand = new Command<string>(CambiarVista);

            // Inicialización temporal (dummy)
            CargarResumenMock();
            CargarGraficosMock();
        }

        public ReportesViewModel() { }

        // ===============================
        // 🔹 MÉTODOS DE NAVEGACIÓN
        // ===============================
        private void CambiarVista(string vista)
        {
            IsFinanciero = vista == "Financiero";
            IsOperaciones = vista == "Operaciones";
            IsRendimiento = vista == "Rendimiento";
            IsGastos = vista == "Gastos";

            _view.CambiarVista(vista);
        }

        // ===============================
        // 🔹 MÉTODOS PRINCIPALES (futuros de BD)
        // ===============================

        //
        // Obtiene los datos del resumen general (ingresos, gastos, etc.)
        // desde la base de datos y los asigna a la propiedad Resumen.
        // 
        public async Task CargarResumenDesdeBD()
        {
            // TODO: Conectar a la base de datos
            // Ejemplo:
            // using (var connection = Conexion.GetConnection())
            // {
            //     var cmd = new MySqlCommand("SELECT ...", connection);
            //     var reader = cmd.ExecuteReader();
            //     while (reader.Read())
            //     {
            //         Resumen.IngresosMes = reader.GetDecimal("ingresos");
            //         ...
            //     }
            // }
            await Task.Delay(200); // Simulación temporal
            OnPropertyChanged(nameof(Resumen));
        }

        /// <summary>
        /// Obtiene la evolución de ingresos mensuales desde la BD.
        /// </summary>
        public async Task CargarIngresosMensualesDesdeBD()
        {
            // TODO: SELECT Mes, TotalIngresos FROM Ingresos WHERE Fecha BETWEEN ...
            await Task.Delay(200);
            IngresosMensuales.Clear();
            // Ejemplo:
            // IngresosMensuales.Add(new ReportePunto { Mes = "Enero", Valor = 5000 });
            OnPropertyChanged(nameof(IngresosMensuales));
        }

        /// <summary>
        /// Obtiene el rendimiento de los técnicos.
        /// </summary>
        public async Task CargarRendimientoTecnicosDesdeBD()
        {
            // TODO: SELECT Nombre, Tickets, Calificacion FROM Tecnicos ...
            await Task.Delay(200);
            RendimientoTecnicos.Clear();
            OnPropertyChanged(nameof(RendimientoTecnicos));
        }

        /// <summary>
        /// Obtiene los gastos agrupados por categoría.
        /// </summary>
        public async Task CargarGastosPorCategoriaDesdeBD()
        {
            // TODO: SELECT Categoria, SUM(Monto) FROM Gastos GROUP BY Categoria;
            await Task.Delay(200);
            GastosPorCategoria.Clear();
            OnPropertyChanged(nameof(GastosPorCategoria));
        }

        /// <summary>
        /// Actualiza todas las gráficas y valores según el rango seleccionado.
        /// </summary>
        public async void ActualizarRango()
        {
            await CargarResumenDesdeBD();
            await CargarIngresosMensualesDesdeBD();
            await CargarRendimientoTecnicosDesdeBD();
            await CargarGastosPorCategoriaDesdeBD();
        }

        // ===============================
        // 🔹 MÉTODOS TEMPORALES (mock)
        // ===============================
        private void CargarResumenMock()
        {
            Resumen = new ReportesResumen
            {
                IngresosMes = 7500,
                TicketsCompletados = 27,
                ClientesNuevos = 8,
                GastosMes = 3450,
                VariacionIngresosMes = 12,
                VariacionTickets = 8,
                VariacionClientes = 15,
                VariacionGastos = 5
            };
            OnPropertyChanged(nameof(Resumen));
        }

        private void CargarGraficosMock()
        {
            IngresosMensuales = new ObservableCollection<ReportePunto>
            {
                new() { Mes = "Ene", Valor = 4500 },
                new() { Mes = "Feb", Valor = 4800 },
                new() { Mes = "Mar", Valor = 5200 },
                new() { Mes = "Abr", Valor = 6100 },
                new() { Mes = "May", Valor = 7200 },
                new() { Mes = "Jun", Valor = 7800 }
            };
            OnPropertyChanged(nameof(IngresosMensuales));
        }
    }
}
