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
        public string TypeResource { get; set; }
        public int AmountResource { get; set; }
        public int MinAmuntResource { get; set; }
        public string MarcaResource { get; set; }
        public string ProveedorResource { get; set; }
        public string LastKnownDate { get; set; } //ultima fecha que fue actualizado
        public string Location { get; set; }
        public int Price { get; set; }
        public Recurso(string inName) { this.Name = inName; }
        public Recurso(string name, string typeResource, int amountResource, int minAmuntResource, string marcaResource, string proveedorResource, string lastKnownDate, string location, int price) : this(name)
        {
            this.TypeResource = typeResource;
            this.AmountResource = amountResource;
            this.MinAmuntResource = minAmuntResource;
            this.MarcaResource = marcaResource;
            this.ProveedorResource = proveedorResource;
            this.LastKnownDate = lastKnownDate;
            this.Location = location;
            this.Price = price;
        }
    }
}
