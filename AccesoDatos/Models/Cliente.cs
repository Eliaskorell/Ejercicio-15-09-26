using System;
using System.Collections.Generic;
using System.Text;

namespace AccesoDatos.Models
{
     public class Cliente
    {
        public ICollection<Alquiler> Alquileres { get; set; }

        public int DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Domicilio { get; set; }
        public string Telefono { get; set; }
        public string CorreoElectronico { get; set; }
        public int LicenciaConducir { get; set; }
    }
}
