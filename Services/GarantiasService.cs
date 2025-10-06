using KSM_ULS.Model;
using System.Collections.Generic;
using System.Threading.Tasks;
using KSM_ULS.Services;

namespace KSM_ULS.Services
{
    public static class GarantiasService
    {
        public static async Task<List<GarantiaModel>> ObtenerGarantiasAsync()
            => await DatabaseService.ObtenerGarantiasAsync();

        public static async Task RegistrarGarantiaAsync(GarantiaModel nuevaGarantia)
            => await DatabaseService.RegistrarGarantiaAsync(nuevaGarantia);
    }
}
