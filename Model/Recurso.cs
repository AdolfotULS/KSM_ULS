using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSM_ULS.Model
{
    public class Recurso
    {
        public string Name { get; set; }
        public string typeResource { get; set; }
        public int amountResource { get; set; }
        public int minAmuntResource { get; set; }
        public string marcaResource { get; set; }
        public string proveedorResource { get; set; }
        public string lastKnownDate { get; set; } //ultima fecha que fue actualizado
        public string location { get; set; }
        public int price { get; set; }
        public Recurso(string inName) { this.Name = inName; }
        public Recurso(string name, string typeResource, int amountResource, int minAmuntResource, string marcaResource, string proveedorResource, string lastKnownDate, string location, int price) : this(name)
        {
            this.typeResource = typeResource;
            this.amountResource = amountResource;
            this.minAmuntResource = minAmuntResource;
            this.marcaResource = marcaResource;
            this.proveedorResource = proveedorResource;
            this.lastKnownDate = lastKnownDate;
            this.location = location;
            this.price = price;
        }
    }
}
