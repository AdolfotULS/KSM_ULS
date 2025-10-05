using Microsoft.Maui.Controls;
using System.Collections.Generic;

namespace KSM_ULS.Pages
{
    public partial class DashboardPage : ContentPage
    {
        // Lista de botones de navegación inferior y menú lateral
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

        // Método para actualizar el color activo
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

            // Menú lateral
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

        // Muestra/oculta el menú lateral
        private void OnMenuButtonClicked(object sender, EventArgs e)
        {
            MenuOverlay.IsVisible = !MenuOverlay.IsVisible;
        }

        // Cierra el menú lateral
        private void OnCloseMenuClicked(object sender, EventArgs e)
        {
            MenuOverlay.IsVisible = false;
        }

        // Muestra opciones adicionales
        private void OnOptionsButtonClicked(object sender, EventArgs e)
        {
            DisplayAlert("Opciones", "Menú de opciones adicionales", "OK");
        }


        // Acción rápida: ver reportes
        private void OnVerReportesClicked(object sender, EventArgs e)
        {
            DisplayAlert("Reportes", "Navegando a reportes...", "OK");
        }

        // Navegación barra inferior: Dashboard
        private void OnBottomNavDashboardClicked(object sender, EventArgs e)
        {
            LoadSubView("Dashboard");
        }

        // Navegación barra inferior: Tickets
        private void OnBottomNavTicketsClicked(object sender, EventArgs e)
        {
            LoadSubView("Tickets");
        }

        // Navegación barra inferior: Clientes
        private void OnBottomNavClientesClicked(object sender, EventArgs e)
        {
            LoadSubView("Clientes");
        }

        // Navegación barra inferior: Inventario
        private void OnBottomNavInventarioClicked(object sender, EventArgs e)
        {
            LoadSubView("Inventario");
        }

        // Navegación barra inferior: Reportes
        private void OnBottomNavReportesClicked(object sender, EventArgs e)
        {
            LoadSubView("Reportes");
        }

        // Menú lateral: Dashboard
        private void OnMenuDashboardClicked(object sender, EventArgs e)
        {
            MenuOverlay.IsVisible = false;
            LoadSubView("Dashboard");
        }

        // Menú lateral: Tickets
        private void OnMenuTicketsClicked(object sender, EventArgs e)
        {
            MenuOverlay.IsVisible = false;
            LoadSubView("Tickets");
        }

        // Menú lateral: Clientes
        private void OnMenuClientesClicked(object sender, EventArgs e)
        {
            MenuOverlay.IsVisible = false;
            LoadSubView("Clientes");
        }

        // Menú lateral: Inventario
        private void OnMenuInventarioClicked(object sender, EventArgs e)
        {
            MenuOverlay.IsVisible = false;
            LoadSubView("Inventario");
        }

        // Menú lateral: Garantías
        private void OnMenuGarantiasClicked(object sender, EventArgs e)
        {
            MenuOverlay.IsVisible = false;
            LoadSubView("Garantias");
        }

        // Menú lateral: Reportes
        private void OnMenuReportesClicked(object sender, EventArgs e)
        {
            MenuOverlay.IsVisible = false;
            LoadSubView("Reportes");
        }

        // Menú lateral: Configuración
        private void OnMenuConfiguracionClicked(object sender, EventArgs e)
        {
            MenuOverlay.IsVisible = false;
            DisplayAlert("Configuracion", "Navegando a configuracion...", "OK");
        }

        // Menú lateral: Cerrar sesión con confirmación
        private async void OnMenuCerrarSesionClicked(object sender, EventArgs e)
        {
            MenuOverlay.IsVisible = false;

            bool result = await DisplayAlert("Cerrar Sesion",
                "¿Estas seguro de que deseas cerrar sesion?",
                "Si", "Cancelar");

            if (result)
            {
                await DisplayAlert("Sesion Cerrada", "Has cerrado sesion exitosamente.", "OK");
            }
        }

        // Carga una subvista en el ContentView host según el nombre
        private void LoadSubView(string viewName)
        {
            try
            {
                Host.Content = null;
                SetActiveView(viewName);
                // Selecciona la vista a mostrar según el nombre
                View subView = viewName switch
                {
                    "Dashboard" => new Views.DashOverviewView(),
                    "Clientes" => new Views.DashClientsView(),
                    //"Tickets" => new Views.DashTicketsView(),
                    "Inventario" => new Views.inventarioMenu.inventarioDashView(),
                    /*"Reportes" => new Views.DashReportsView(),
                    "Garantias" => new Views.DashWarrantiesView(),*/
                    _ => null
                };
                Host.Content = subView;
            }
            catch (Exception ex)
            {
                DisplayAlert("Error", $"Error al cargar la vista: {ex.Message}", "OK");
            }
        }
    }
}