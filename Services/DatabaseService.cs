using System.Collections.Generic;
using System.Threading.Tasks;

namespace KSM_ULS.Services
{
    public static class DatabaseService
    {
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
    }
}
