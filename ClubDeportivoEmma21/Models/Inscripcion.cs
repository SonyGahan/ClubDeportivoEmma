using System;

namespace ClubDeportivoEmma21.Models
{
    public class Inscripcion
    {
        public int IdInscripcion { get; set; }
        public int IdPersona { get; set; }        // FK a Persona
        public int IdActividad { get; set; }      // FK a Actividad
        public DateTime FechaInscripcion { get; set; }
    }
}
