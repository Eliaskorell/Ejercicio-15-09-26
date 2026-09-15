using System;
using System.Collections.Generic;
using System.Text;
using AccesoDatos.Repositories;

namespace AccesoDatos.Models
{
    public class Alquiler
    {
        public int Id_alquiler { get; set; }   // recordá el [Key] o renombrar (lo vimos antes)
        public int DNI { get; set; }           // FK -> Cliente
        public Cliente Cliente { get; set; }   // navegación
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int TotalPagar { get; set; }
        public ICollection<DetalleAlquiler> Detalles { get; set; }
    }
}
