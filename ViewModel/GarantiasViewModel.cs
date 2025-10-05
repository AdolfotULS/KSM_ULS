using CommunityToolkit.Maui.Extensions;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Maui.Views;
using KSM_ULS.Model;
using KSM_ULS.Services;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Maui.Core;
using System.Linq;

namespace KSM_ULS.ViewModel
{
    public partial class GarantiasViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<GarantiaModel> garantias;

        [ObservableProperty]
        private int totalGarantias;
        [ObservableProperty]
        private int garantiasActivas;
        [ObservableProperty]
        private int garantiasPendientes;
        [ObservableProperty]
        private int garantiasPorVencer;

        public ICommand NuevaGarantiaCommand { get; }

        public GarantiasViewModel()
        {
            NuevaGarantiaCommand = new AsyncRelayCommand(AbrirPopupNuevaGarantiaAsync);
            _ = CargarGarantiasAsync();
        }

        private async Task CargarGarantiasAsync()
        {
            var lista = await GarantiasService.ObtenerGarantiasAsync();
            Garantias = new ObservableCollection<GarantiaModel>(lista);

            TotalGarantias = lista.Count;
            GarantiasActivas = lista.Count(g => g.Estado == "Activa");
            GarantiasPendientes = lista.Count(g => g.Estado == "Pendiente");
            GarantiasPorVencer = lista.Count(g => g.Estado == "Por Vencer");
        }

        private async Task AbrirPopupNuevaGarantiaAsync()
        {
            var popup = new KSM_ULS.Views.NuevaGarantiaPopup();
            var result = await Application.Current.MainPage.ShowPopupAsync(popup);

            if (result is IPopupResult popupResult && !popupResult.WasDismissedByTappingOutsideOfPopup)
            {
                await Application.Current.MainPage.DisplayAlert("Registro", "Garantía registrada correctamente (simulado).", "OK");
                await CargarGarantiasAsync(); // Refresca la lista
            }
        }

    }
}