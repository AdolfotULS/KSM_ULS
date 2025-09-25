using CommunityToolkit.Maui.Extensions;
using KSM_ULS.Model;
using CommunityToolkit.Maui.Views;
using KSMULS.Views;

namespace KSM_ULS.Pages;

public partial class GarantiasPage : ContentPage
{

    /*
    Objetivo: Forzar el tema claro al aparecer la página de garantías.
     
    */
    protected override void OnAppearing()
    {
        base.OnAppearing();
        Application.Current.UserAppTheme = AppTheme.Light; 
    }

    /*
    Objetivo: Inicializar la página de garantías y establecer la fuente de datos para la lista de garantías.

    Proxima mejora: Integrar con una base de datos real para cargar las garantías dinámicamente.
    */
    public GarantiasPage()
    {

        InitializeComponent();

        
        GarantiasList.ItemsSource = new List<Garantia>
        {
            //datos de ejemplo para comprobar la vista de las garantias

            new Garantia
            {
                Codigo = "GAR-001",
                Estado = "Activa",
                EstadoColor = Colors.Green,
                Ticket = "TK-003",
                Titulo = "Instalación red corporativa",
                Cliente = "Tech Solutions Ltd.",
                FechaInicio = "27/08/2025",
                FechaVencimiento = "27/08/2026",
                Duracion = "12 meses",
                DiasRestantes = "Días restantes: 338",
                Terminos = "Garantía total en instalación y configuración. Incluye soporte telefónico.",
                Notas = "Cliente empresarial - prioridad alta",
                PuedeActivar = false
            },
            new Garantia
            {
                Codigo = "GAR-002",
                Estado = "Pendiente",
                EstadoColor = Colors.Orange,
                Ticket = "TK-001",
                Titulo = "Reparación equipo de impresión",
                Cliente = "Empresa ABC S.A.",
                FechaInicio = "29/08/2025",
                FechaVencimiento = "29/11/2025",
                Duracion = "3 meses",
                DiasRestantes = "Días restantes: 67",
                Terminos = "Garantía por defectos de fabricación y mano de obra.",
                Notas = "Pendiente de entrega del equipo",
                PuedeActivar = true
            }



        };


        
    }
    /*
    Objetivo:se activa al hacer click en el boton de nueva garantia y abre un popup para crear una nueva garantia

    Error actual: El popup mantiene un error al presionar el boton cancelar.

    Proxima mejora: Corregir el error del popup y conectar con la base de datos para guardar las nuevas garantias.
     
     */
    private void NuevaGarantia_Clicked(object sender, EventArgs e)
    {
        var popup = new NuevaGarantiaPopup();
        this.ShowPopup(popup);
    }
}
