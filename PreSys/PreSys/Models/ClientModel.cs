using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PreSys.Models
{
    public class ClientModel
    {
        public string Identificacion { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string FechaNac { get; set; }
        public string Nacionalidad { get; set; }
        public string Femenino { get; set; }
        public string Masculino { get; set; }
        public string EstadoCivil { get; set; }
        public string Profesion { get; set; }
        public string Apodo { get; set; }
        public int NumHijos { get; set; }
    }
}