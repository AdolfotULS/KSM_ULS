namespace KSM_ULS.Model
{
    public class ReportesResumen
    {
        public decimal IngresosMes { get; set; }
        public int TicketsCompletados { get; set; }
        public int ClientesNuevos { get; set; }
        public decimal GastosMes { get; set; }

        public decimal VariacionIngresosMes { get; set; }
        public decimal VariacionTickets { get; set; }
        public decimal VariacionClientes { get; set; }
        public decimal VariacionGastos { get; set; }
    }

    public class ReportePunto
    {
        public string Mes { get; set; }
        public double Valor { get; set; }
    }

    public class TecnicoRendimiento
    {
        public string Nombre { get; set; }
        public int Tickets { get; set; }
        public double TiempoPromedioDias { get; set; }
        public double Calificacion { get; set; }
    }

    public class GastoCategoria
    {
        public string Categoria { get; set; }
        public double Monto { get; set; }
    }
}
