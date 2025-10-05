using Microsoft.Maui.Controls;
using System.Collections.Generic;

namespace KSM_ULS.Pages
{
    public partial class DashboardPage : ContentPage
    {
        // Lista de botones de navegaci�n inferior y men� lateral
        private List<Button> bottomNavButtons;
        private List<Button> menuButtons;

        public DashboardPage()
        {
            InitializeComponent();
            Title = "Krakenware";

            // Inicializar listas de botones
            bottomNavButtons = new List<Button>
            {
                BottomNavDashboardButton,
                BottomNavTicketsButton,
                BottomNavClientesButton,
                BottomNavInventarioButton,
                BottomNavReportesButton
            };
            menuButtons = new List<Button>
            {
                MenuDashboardButton,
                MenuTicketsButton,
                MenuClientesButton,
                MenuInventarioButton,
                MenuGarantiasButton,
                MenuReportesButton
            };
        }

        // M�todo para actualizar el color activo
        private void SetActiveView(string viewName)
        {
            // Colores
            var activeBg = Color.FromArgb("#E3F2FD");
            var activeText = Color.FromArgb("#4A90E2"); // PrimaryColor
            var inactiveBg = Colors.Transparent;
            var inactiveText = Color.FromArgb("#2C3E50"); // SecondaryColor
            var inactiveTextBottom = Colors.Gray;

            // Barra inferior
            foreach (var btn in bottomNavButtons)
            {
                btn.BackgroundColor = inactiveBg;
                btn.TextColor = inactiveTextBottom;
                btn.FontAttributes = FontAttributes.None;
            }
            switch (viewName)
            {
                case "Dashboard":
                    BottomNavDashboardButton.BackgroundColor = activeBg;
                    BottomNavDashboardButton.TextColor = activeText;
                    BottomNavDashboardButton.FontAttributes = FontAttributes.Bold;
                    break;
                case "Tickets":
                    BottomNavTicketsButton.BackgroundColor = activeBg;
                    BottomNavTicketsButton.TextColor = activeText;
                    BottomNavTicketsButton.FontAttributes = FontAttributes.Bold;
                    break;
                case "Clientes":
                    BottomNavClientesButton.BackgroundColor = activeBg;
                    BottomNavClientesButton.TextColor = activeText;
                    BottomNavClientesButton.FontAttributes = FontAttributes.Bold;
                    break;
                case "Inventario":
                    BottomNavInventarioButton.BackgroundColor = activeBg;
                    BottomNavInventarioButton.TextColor = activeText;
                    BottomNavInventarioButton.FontAttributes = FontAttributes.Bold;
                    break;
                case "Reportes":
                    BottomNavReportesButton.BackgroundColor = activeBg;
                    BottomNavReportesButton.TextColor = activeText;
                    BottomNavReportesButton.FontAttributes = FontAttributes.Bold;
                    break;
            }

            // Men� lateral
            foreach (var btn in menuButtons)
            {
                btn.BackgroundColor = inactiveBg;
                btn.TextColor = inactiveText;
                btn.FontAttributes = FontAttributes.None;
            }
            switch (viewName)
            {
                case "Dashboard":
                    MenuDashboardButton.BackgroundColor = activeBg;
                    MenuDashboardButton.TextColor = activeText;
                    MenuDashboardButton.FontAttributes = FontAttributes.Bold;
                    break;
                case "Tickets":
                    MenuTicketsButton.BackgroundColor = activeBg;
                    MenuTicketsButton.TextColor = activeText;
                    MenuTicketsButton.FontAttributes = FontAttributes.Bold;
                    break;
                case "Clientes":
                    MenuClientesButton.BackgroundColor = activeBg;
                    MenuClientesButton.TextColor = activeText;
                    MenuClientesButton.FontAttributes = FontAttributes.Bold;
                    break;
                case "Inventario":
                    MenuInventarioButton.BackgroundColor = activeBg;
                    MenuInventarioButton.TextColor = activeText;
                    MenuInventarioButton.FontAttributes = FontAttributes.Bold;
                    break;
                case "Garantias":
                    MenuGarantiasButton.BackgroundColor = activeBg;
                    MenuGarantiasButton.TextColor = activeText;
                    MenuGarantiasButton.FontAttributes = FontAttributes.Bold;
                    break;
                case "Reportes":
                    MenuReportesButton.BackgroundColor = activeBg;
                    MenuReportesButton.TextColor = activeText;
                    MenuReportesButton.FontAttributes = FontAttributes.Bold;
                    break;
            }
        }

        // Muestra/oculta el men� lateral
        private void OnMenuButtonClicked(object sender, EventArgs e)
        {
            MenuOverlay.IsVisible = !MenuOverlay.IsVisible;
        }

        // Cierra el men� lateral
        private void OnCloseMenuClicked(object sender, EventArgs e)
        {
            MenuOverlay.IsVisible = false;
        }

        // Muestra opciones adicionales
        private void OnOptionsButtonClicked(object sender, EventArgs e)
        {
            DisplayAlert("Opciones", "Men� de opciones adicionales", "OK");
        }


        // Acci�n r�pida: ver reportes
        private void OnVerReportesClicked(object sender, EventArgs e)
        {
            DisplayAlert("Reportes", "Navegando a reportes...", "OK");
        }

        // Navegaci�n barra inferior: Dashboard
        private void OnBottomNavDashboardClicked(object sender, EventArgs e)
        {
            LoadSubView("Dashboard");
        }

        // Navegaci�n barra inferior: Tickets
        private void OnBottomNavTicketsClicked(object sender, EventArgs e)
        {
            LoadSubView("Tickets");
        }

        // Navegaci�n barra inferior: Clientes
        private void OnBottomNavClientesClicked(object sender, EventArgs e)
        {
            LoadSubView("Clientes");
        }

        // Navegaci�n barra inferior: Inventario
        private void OnBottomNavInventarioClicked(object sender, EventArgs e)
        {
            LoadSubView("Inventario");
        }

        // Navegaci�n barra inferior: Reportes
        private void OnBottomNavReportesClicked(object sender, EventArgs e)
        {
            LoadSubView("Reportes");
        }

        // Men� lateral: Dashboard
        private void OnMenuDashboardClicked(object sender, EventArgs e)
        {
            MenuOverlay.IsVisible = false;
            LoadSubView("Dashboard");
        }

        // Men� lateral: Tickets
        private void OnMenuTicketsClicked(object sender, EventArgs e)
        {
            MenuOverlay.IsVisible = false;
            LoadSubView("Tickets");
        }

        // Men� lateral: Clientes
        private void OnMenuClientesClicked(object sender, EventArgs e)
        {
            MenuOverlay.IsVisible = false;
            LoadSubView("Clientes");
        }

        // Men� lateral: Inventario
        private void OnMenuInventarioClicked(object sender, EventArgs e)
        {
            MenuOverlay.IsVisible = false;
            LoadSubView("Inventario");
        }

        // Men� lateral: Garant�as
        private void OnMenuGarantiasClicked(object sender, EventArgs e)
        {
            MenuOverlay.IsVisible = false;
            LoadSubView("Garantias");
        }

        // Men� lateral: Reportes
        private void OnMenuReportesClicked(object sender, EventArgs e)
        {
            MenuOverlay.IsVisible = false;
            LoadSubView("Reportes");
        }

        // Men� lateral: Configuraci�n
        private void OnMenuConfiguracionClicked(object sender, EventArgs e)
        {
            MenuOverlay.IsVisible = false;
            DisplayAlert("Configuracion", "Navegando a configuracion...", "OK");
        }

        // Men� lateral: Cerrar sesi�n con confirmaci�n
        private async void OnMenuCerrarSesionClicked(object sender, EventArgs e)
        {
            MenuOverlay.IsVisible = false;

            bool result = await DisplayAlert("Cerrar Sesion",
                "�Estas seguro de que deseas cerrar sesion?",
                "Si", "Cancelar");

            if (result)
            {
                await DisplayAlert("Sesion Cerrada", "Has cerrado sesion exitosamente.", "OK");
            }
        }

        // Carga una subvista en el ContentView host seg�n el nombre
        private void LoadSubView(string viewName)
        {
            try
            {
                Host.Content = null;
                SetActiveView(viewName);
                // Selecciona la vista a mostrar seg�n el nombre
                View subView = viewName switch
                {
                    "Dashboard" => new Views.DashOverviewView(),
                    "Clientes" => new Views.DashClientsView(),
                    "Reportes" => new Views.ReportesView(),
                    "Inventario" => new Views.Inventario.InventarioDashView(),
                    _ => null
                };
                Host.Content = subView;
            } catch (Exception ex)
            {
                DisplayAlert("Error", $"Error al cargar la vista: {ex.Message}", "OK");
            }
        }
    }
}
