using CommunityToolkit.Maui.Views;
using System.Windows.Input;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using KSM_ULS.Model;
using System;
using System.ComponentModel;
using Microsoft.Maui.Controls;

namespace KSM_ULS.Views
{
    public partial class NuevaGarantiaPopup : Popup, INotifyPropertyChanged
    {
        // Comandos para los botones
        public ICommand CloseCommand { get; private set; }
        public ICommand SaveCommand { get; private set; }

        // Colecciones para pickers
        public ObservableCollection<string> Tickets { get; } = new();
        public ObservableCollection<string> Durations { get; } = new();

        // Propiedades seleccionadas
        private string _selectedTicket;
        public string SelectedTicket
        {
            get => _selectedTicket;
            set
            {
                if (_selectedTicket != value)
                {
                    _selectedTicket = value;
                    OnPropertyChanged(nameof(SelectedTicket));
                }
            }
        }

        private string _selectedDuration;
        public string SelectedDuration
        {
            get => _selectedDuration;
            set
            {
                if (_selectedDuration != value)
                {
                    _selectedDuration = value;
                    OnPropertyChanged(nameof(SelectedDuration));
                    CalcularVencimientoYRestantes();
                }
            }
        }

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

        public string Terminos { get; set; }
        public string Notas { get; set; }

        public NuevaGarantiaPopup()
        {
            InitializeComponent();

            // Configurar comandos
            CloseCommand = new Command(async () => await CerrarPopupAsync());
            SaveCommand = new Command(async () => await RegistrarGarantiaAsync());

            BindingContext = this;

            // Datos de ejemplo para los pickers (hasta que conectes la BD)
            Tickets.Add("TK-001");
            Tickets.Add("TK-002");
            Tickets.Add("TK-003");

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
            int dias = (FechaVencimientoDate - FechaInicioDate).Days;
            DiasRestantes = $"Días restantes: {dias}";
        }

        private async Task RegistrarGarantiaAsync()
        {
            // 🔧 Aquí irá la lógica real para guardar en la base de datos más adelante.
            await Application.Current.MainPage.DisplayAlert("Registro", "Garantía registrada correctamente (simulado).", "OK");

            
            Close(true);
        }

        private void Close(bool v)
        {
            throw new NotImplementedException();
        }

        private async Task CerrarPopupAsync()
        {
            await CloseAsync();
        }

        // Implementación de INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
