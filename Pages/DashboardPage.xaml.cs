using Microsoft.Maui.Controls;

namespace KSM_ULS.Pages
{
    public partial class DashboardPage : ContentPage
    {
        public DashboardPage()
        {
            InitializeComponent();
            Title = "Krakenware";
        }

        // evento para mostrar/ocultar menu lateral
        private void OnMenuButtonClicked(object sender, EventArgs e)
        {
            MenuOverlay.IsVisible = !MenuOverlay.IsVisible;
        }

        // evento para cerrar menu lateral
        private void OnCloseMenuClicked(object sender, EventArgs e)
        {
            MenuOverlay.IsVisible = false;
        }

        // evento para el boton de opciones
        private void OnOptionsButtonClicked(object sender, EventArgs e)
        {
            DisplayAlert("Opciones", "Menú de opciones adicionales", "OK");
        }

        // eventos de acciones rapidas
        private void OnAgregarProductoClicked(object sender, EventArgs e)
        {
            DisplayAlert("Agregar Producto", "Navegando a la página de agregar producto...", "OK");
        }

        private void OnVerReportesClicked(object sender, EventArgs e)
        {
            DisplayAlert("Reportes", "Navegando a reportes...", "OK");
        }

        // eventos de navegacion de la barra inferior
        private void OnBottomNavDashboardClicked(object sender, EventArgs e)
        {
            DisplayAlert("Navegacion", "Dashboard seleccionado", "OK");
        }

        private void OnBottomNavTicketsClicked(object sender, EventArgs e)
        {
            DisplayAlert("Navegacion", "Tickets seleccionado", "OK");
        }

        private void OnBottomNavClientesClicked(object sender, EventArgs e)
        {
            DisplayAlert("Navegacion", "Clientes seleccionado", "OK");
        }

        private void OnBottomNavInventarioClicked(object sender, EventArgs e)
        {
            DisplayAlert("Navegacion", "Inventario seleccionado", "OK");
        }

        private void OnBottomNavReportesClicked(object sender, EventArgs e)
        {
            DisplayAlert("Navegacion", "Reportes seleccionado", "OK");
        }

        // eventos del menu lateral
        private void OnMenuDashboardClicked(object sender, EventArgs e)
        {
            MenuOverlay.IsVisible = false;
            LoadSubView("Dashboard");
        }

        private void OnMenuTicketsClicked(object sender, EventArgs e)
        {
            MenuOverlay.IsVisible = false;
            LoadSubView("Tickets");
        }

        private void OnMenuClientesClicked(object sender, EventArgs e)
        {
            MenuOverlay.IsVisible = false;
            LoadSubView("Clientes");
        }

        private void OnMenuInventarioClicked(object sender, EventArgs e)
        {
            MenuOverlay.IsVisible = false;
            LoadSubView("Inventario");
        }

        private void OnMenuGarantiasClicked(object sender, EventArgs e)
        {
            MenuOverlay.IsVisible = false;
            LoadSubView("Garantias");
        }

        private void OnMenuReportesClicked(object sender, EventArgs e)
        {
            MenuOverlay.IsVisible = false;
            LoadSubView("Reportes");
        }

        private void OnMenuConfiguracionClicked(object sender, EventArgs e)
        {
            MenuOverlay.IsVisible = false;
            DisplayAlert("Configuracion", "Navegando a configuracion...", "OK");
        }

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

        // metodo para cargar subvistas en el contentview host
        private void LoadSubView(string viewName)
        {
            try
            {
                Host.Content = null;

                View subView = viewName switch
                {
                    "Dashboard" => CreateDashboardView(),
                    "Tickets" => CreateTicketsView(),
                    "Clientes" => CreateClientesView(),
                    "Inventario" => CreateInventarioView(),
                    "Garantias" => CreateGarantiasView(),
                    "Reportes" => CreateReportesView(),
                    _ => CreateDefaultView()
                };

                Host.Content = subView;
                DisplayAlert("Vista Cargada", $"Se ha cargado la vista: {viewName}", "OK");
            }
            catch (Exception ex)
            {
                DisplayAlert("Error", $"Error al cargar la vista: {ex.Message}", "OK");
            }
        }

        // metodos para crear las diferentes vistas
        private View CreateDashboardView()
        {
            return new StackLayout
            {
                Padding = new Thickness(20),
                Children =
                {
                    new Label
                    {
                        Text = "Vista de Dashboard",
                        FontSize = 18,
                        FontAttributes = FontAttributes.Bold,
                        TextColor = Color.FromArgb("#2C3E50")
                    },
                    new Label
                    {
                        Text = "Aqui se mostraria el dashboard principal.",
                        FontSize = 14,
                        TextColor = Colors.Gray
                    }
                }
            };
        }

        private View CreateTicketsView()
        {
            return new StackLayout
            {
                Padding = new Thickness(20),
                Children =
                {
                    new Label
                    {
                        Text = "Vista de Tickets",
                        FontSize = 18,
                        FontAttributes = FontAttributes.Bold,
                        TextColor = Color.FromArgb("#2C3E50")
                    },
                    new Label
                    {
                        Text = "Aqui se mostraria la lista de tickets.",
                        FontSize = 14,
                        TextColor = Colors.Gray
                    }
                }
            };
        }

        private View CreateClientesView()
        {
            return new StackLayout
            {
                Padding = new Thickness(20),
                Children =
                {
                    new Label
                    {
                        Text = "Vista de Clientes",
                        FontSize = 18,
                        FontAttributes = FontAttributes.Bold,
                        TextColor = Color.FromArgb("#2C3E50")
                    },
                    new Label
                    {
                        Text = "Aqui se mostraria la lista de clientes.",
                        FontSize = 14,
                        TextColor = Colors.Gray
                    }
                }
            };
        }

        private View CreateInventarioView()
        {
            return new StackLayout
            {
                Padding = new Thickness(20),
                Children =
                {
                    new Label
                    {
                        Text = "Vista de Inventario",
                        FontSize = 18,
                        FontAttributes = FontAttributes.Bold,
                        TextColor = Color.FromArgb("#2C3E50")
                    },
                    new Label
                    {
                        Text = "Aqui se mostraria el inventario de productos.",
                        FontSize = 14,
                        TextColor = Colors.Gray
                    }
                }
            };
        }

        private View CreateGarantiasView()
        {
            return new StackLayout
            {
                Padding = new Thickness(20),
                Children =
                {
                    new Label
                    {
                        Text = "Vista de Garantias",
                        FontSize = 18,
                        FontAttributes = FontAttributes.Bold,
                        TextColor = Color.FromArgb("#2C3E50")
                    },
                    new Label
                    {
                        Text = "Aqui se mostraran las garantias.",
                        FontSize = 14,
                        TextColor = Colors.Gray
                    }
                }
            };
        }

        private View CreateReportesView()
        {
            return new StackLayout
            {
                Padding = new Thickness(20),
                Children =
                {
                    new Label
                    {
                        Text = "Vista de Reportes",
                        FontSize = 18,
                        FontAttributes = FontAttributes.Bold,
                        TextColor = Color.FromArgb("#2C3E50")
                    },
                    new Label
                    {
                        Text = "Aqui se mostraran los reportes del sistema.",
                        FontSize = 14,
                        TextColor = Colors.Gray
                    }
                }
            };
        }

        private View CreateDefaultView()
        {
            return new StackLayout
            {
                Padding = new Thickness(20),
                Children =
                {
                    new Label
                    {
                        Text = "Vista por Defecto",
                        FontSize = 18,
                        FontAttributes = FontAttributes.Bold,
                        TextColor = Color.FromArgb("#2C3E50")
                    },
                    new Label
                    {
                        Text = "Selecciona una opcion del menu para ver el contenido.",
                        FontSize = 14,
                        TextColor = Colors.Gray
                    }
                }
            };
        }

        // metodos originales mantenidos para compatibilidad
        private void OnResumenClicked(object sender, EventArgs e)
        {
            LoadSubView("Dashboard");
        }

        private void OnClientesClicked(object sender, EventArgs e)
        {
            LoadSubView("Clientes");
        }
    }
}
