using System;
using System.Collections.Generic;
using System.Text;
using AccesoDatos.Repositories;

namespace AccesoDatos.Models
{
    public class Alquiler
    {
        public int Id_alquiler { get; set; }
        public int DNI { get; set; }
        public int Patente { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int CantidadDias { get; set; }
        public int TotalPagar { get; set; }

    }
}
