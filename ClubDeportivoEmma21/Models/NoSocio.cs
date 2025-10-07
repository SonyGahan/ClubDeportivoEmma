using System;

namespace ClubDeportivoEmma21.Models
{
    public class NoSocio
    {
        public int IdNoSocio { get; set; }
        public int IdPersona { get; set; }       // FK a Persona
        public DateTime FechaIngreso { get; set; }
    }
}
