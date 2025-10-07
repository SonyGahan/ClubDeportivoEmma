using System;

namespace ClubDeportivoEmma21.Models
{
    public class PagoDiario
    {
        public int IdRecibo { get; set; }
        public int IdNoSocio { get; set; }         // FK a NoSocio
        public DateTime FechaPago { get; set; }
        public decimal Monto { get; set; }
    }
}
