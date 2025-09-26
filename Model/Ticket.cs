using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSM_ULS.Model
{
    public class Ticket //TODO revisar permisos de sistemas
    {
        public int Id { get; set; }
        public string clientName{ get; set; }
        public string tecnitianName { get; set; }
        public string limitDate { get; set; }
    }
}
