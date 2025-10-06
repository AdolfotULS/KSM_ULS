using System.Collections.Generic;
using System.Threading.Tasks;
using KSM_ULS.Model;

namespace KSM_ULS.Services
{
    public static class DatabaseService
    {
        // =========================================
        // MÉTODOS EXISTENTES
        // =========================================
        public static async Task<List<object>> ObtenerDatosFinancierosAsync()
        {
            await Task.Delay(500);
            return new List<object>();
        }

        public static async Task<List<object>> ObtenerDatosOperacionesAsync()
        {
            await Task.Delay(500);
            return new List<object>();
        }

        public static async Task<List<object>> ObtenerDatosRendimientoAsync()
        {
            await Task.Delay(500);
            return new List<object>();
        }

        public static async Task<List<object>> ObtenerDatosGastosAsync()
        {
            await Task.Delay(500);
            return new List<object>();
        }

        // =========================================
        // NUEVOS MÉTODOS PARA GARANTÍAS
        // =========================================

        /// <summary>
        /// Obtiene la lista de garantías registradas.
        /// </summary>
        public static async Task<List<GarantiaModel>> ObtenerGarantiasAsync()
        {
            await Task.Delay(300); // Simulación de espera
            // 🔧 Futuro: aquí va la lógica real con conexión a MySQL
            return new List<GarantiaModel>
            {
                new GarantiaModel
                {
                    Id = 1,
                    Codigo = "GAR-001",
                    Ticket = "TK-003",
                    Cliente = "Tech Solutions Ltd.",
                    Estado = "Activa",
                    FechaInicio = new DateTime(2025, 8, 27),
                    FechaVencimiento = new DateTime(2026, 8, 27),
                    DuracionMeses = 12,
                    Terminos = "Garantía total en instalación y configuración. Incluye soporte técnico telefónico.",
                    Notas = "Cliente empresarial - prioridad alta"
                },
                new GarantiaModel
                {
                    Id = 2,
                    Codigo = "GAR-002",
                    Ticket = "TK-001",
                    Cliente = "Empresa ABC S.A.",
                    Estado = "Pendiente",
                    FechaInicio = new DateTime(2025, 8, 29),
                    FechaVencimiento = new DateTime(2025, 11, 29),
                    DuracionMeses = 3,
                    Terminos = "Garantía por defectos de fabricación y mano de obra. No incluye daños por mal uso.",
                    Notas = "Pendiente de entrega del equipo"
                }
            };
        }

        /// <summary>
        /// Registra una nueva garantía en la base de datos.
        /// </summary>
        public static async Task RegistrarGarantiaAsync(GarantiaModel garantia)
        {
            await Task.Delay(300); // Simulación de ejecución
            // 🔧 Futuro:
            // Aquí se hará la inserción real:
            // using (var conn = new MySqlConnection("cadena"))
            // {
            //     string query = "INSERT INTO garantias (codigo, ticket, cliente, estado, fecha_inicio, fecha_vencimiento, duracion_meses, terminos, notas) VALUES (@Codigo, @Ticket, ...)";
            //     ...
            // }
        }
    }
}
