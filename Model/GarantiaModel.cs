namespace KSM_ULS.Model
{
    public class GarantiaModel
    {
        public int Id { get; set; }
        public string Codigo { get; set; } // Ej: GAR-001
        public string Ticket { get; set; } // Ej: TK-001
        public string Cliente { get; set; }
        public string Estado { get; set; } // Activa, Pendiente, Por Vencer, etc.
        public DateTime FechaInicio { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public int DuracionMeses { get; set; }
        public string Terminos { get; set; }
        public string Notas { get; set; }

        // Campo calculado
        public int DiasRestantes => (FechaVencimiento - DateTime.Today).Days;
    }
}
