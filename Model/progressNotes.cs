using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSM_ULS.Model
{
    public class ProgressNotes
    {
        //esta clase es temporal , a futuro seria para archivar apropiadamente las notas de caso de cada ticket
        //ie: dia 1, ta sucio el procesador, dia2: dios santo cucaracha, dia3: cierre de ticket tras denunciar al cliente por atentado a mi salud

        public string[] notes;
        public string date;
        public string author;
        public ProgressNotes() { }
    }
}
