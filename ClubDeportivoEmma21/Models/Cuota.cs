using System;

namespace ClubDeportivoEmma21.Models
{
    public class Cuota
    {
        public int IdCuota { get; set; }
        public int IdSocio { get; set; }          // FK a Socio
        public string MesAPagar { get; set; }
        public decimal ValorCuota { get; set; }
        public DateTime FechaPago { get; set; }
        public string FormaDePago { get; set; }
        public string EstadoPago { get; set; }     // Pagada / Pendiente
    }
}
