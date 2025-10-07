using System;

namespace ClubDeportivoEmma21.Models
{
    public class Socio
    {
        public int IdSocio { get; set; }
        public int IdPersona { get; set; }      // FK a Persona
        public DateTime FechaAlta { get; set; }
        public string EstadoMembresia { get; set; }
        public bool CarnetEntregado { get; set; }
    }
}
