using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSM_ULS.Model
{

    /*
     Clase garantia para implementar las garantias de los productos en las vistas
     */

    public class Garantia
    {
        public string Codigo { get; set; }
        public string Estado { get; set; }
        public Color EstadoColor { get; set; }
        public string Ticket { get; set; }
        public string Titulo { get; set; }
        public string Cliente { get; set; }
        public string FechaInicio { get; set; }
        public string FechaVencimiento { get; set; }
        public string Duracion { get; set; }
        public string DiasRestantes { get; set; }
        public string Terminos { get; set; }
        public string Notas { get; set; }
        public bool PuedeActivar { get; set; }
    }
}
