using CommunityToolkit.Maui.Views;
using System.Windows.Input;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using KSM_ULS.Model;
using KSM_ULS;
using System.Linq;
using Microsoft.Maui.Controls;
using System.ComponentModel;

namespace KSMULS.Views
{
    public partial class NuevaGarantiaPopup : Popup, INotifyPropertyChanged
    {
        private readonly Action<Garantia> _onGarantiaAgregada;

        public ICommand CloseCommand { get; private set; }
        public ICommand SaveCommand { get; private set; }

        // Binding properties
        public ObservableCollection<string> Tickets { get; } = new();
        public ObservableCollection<string> Durations { get; } = new();
        public string SelectedTicket { get; set; }
        public string SelectedDuration { get; set; }
        private DateTime _fechaInicioDate = DateTime.Today;
        public DateTime FechaInicioDate
        {
            get => _fechaInicioDate;
            set
            {
                if (_fechaInicioDate != value)
                {
                    _fechaInicioDate = value;
                    OnPropertyChanged(nameof(FechaInicioDate));
                    CalcularVencimientoYRestantes();
                }
            }
        }

        private DateTime _fechaVencimientoDate = DateTime.Today.AddMonths(1);
        public DateTime FechaVencimientoDate
        {
            get => _fechaVencimientoDate;
            set
            {
                if (_fechaVencimientoDate != value)
                {
                    _fechaVencimientoDate = value;
                    OnPropertyChanged(nameof(FechaVencimientoDate));
                }
            }
        }

        private string _diasRestantes;
        public string DiasRestantes
        {
            get => _diasRestantes;
            set
            {
                if (_diasRestantes != value)
                {
                    _diasRestantes = value;
                    OnPropertyChanged(nameof(DiasRestantes));
                }
            }
        }

        public string Notas { get; private set; }
        public string Terminos { get; private set; }

        public NuevaGarantiaPopup(Action<Garantia> onGarantiaAgregada)
        {
            InitializeComponent();
            _onGarantiaAgregada = onGarantiaAgregada;

            CloseCommand = new Command(async () => await CloseAsync());
            SaveCommand = new Command(async () => await OnSaveAsync());

            BindingContext = this;

            // Datos de prueba
            Tickets.Add("TK-001");
            Tickets.Add("TK-002");
            Durations.Add("3 meses");
            Durations.Add("6 meses");
            Durations.Add("12 meses");

            CalcularVencimientoYRestantes();
        }

        private void CalcularVencimientoYRestantes()
        {
            int meses = 0;
            if (SelectedDuration != null)
            {
                if (SelectedDuration.Contains("12")) meses = 12;
                else if (SelectedDuration.Contains("6")) meses = 6;
                else if (SelectedDuration.Contains("3")) meses = 3;
            }
            FechaVencimientoDate = FechaInicioDate.AddMonths(meses);
            DiasRestantes = $"Días restantes: {(FechaVencimientoDate - FechaInicioDate).Days}";
        }

        private async Task OnSaveAsync()
        {
            // Fecha de inicio: ahora
            var fechaInicio = DateTime.Today;

            // Duración en meses según selección
            int meses = 0;
            if (SelectedDuration != null)
            {
                if (SelectedDuration.Contains("12")) meses = 12;
                else if (SelectedDuration.Contains("6")) meses = 6;
                else if (SelectedDuration.Contains("3")) meses = 3;
            }

            // Fecha de vencimiento
            var fechaVencimiento = fechaInicio.AddMonths(meses);

            // Días restantes
            int diasRestantes = (fechaVencimiento - fechaInicio).Days;

            var nueva = new Garantia
            {
                Codigo = GenerateTemporaryCodigo(),
                Ticket = SelectedTicket ?? string.Empty,
                Duracion = SelectedDuration ?? string.Empty,
                FechaInicio = fechaInicio.ToString("dd-MM-yyyy"),
                FechaVencimiento = fechaVencimiento.ToString("dd-MM-yyyy"),
                DiasRestantes = $"Días restantes: {diasRestantes}",
                Terminos = Terminos,
                Notas = Notas,
                Estado = "Pendiente",
                PuedeActivar = false
            };

            _onGarantiaAgregada?.Invoke(nueva);

            await Application.Current.MainPage.DisplayAlert("Éxito", "La garantía fue registrada correctamente.", "OK");
            await CloseAsync();
        }

        public async Task SaveGarantiaAsync(Garantia nueva)
        {
            // TODO: implementar guardado real (BD o API)
            await Task.CompletedTask;
        }

        private string GenerateTemporaryCodigo()
            => $"GAR-{DateTime.Now:yyMMddHHmmss}";
    }   
}