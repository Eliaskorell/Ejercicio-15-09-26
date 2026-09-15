using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using AccesoDatos.Repositories;

namespace AccesoDatos.Models
{
    public class Alquiler
    {
        [Key]
        public int Id_alquiler { get; set; }
        public int DNI { get; set; }           // FK -> Cliente
        public Cliente Cliente { get; set; }   // navegación
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int TotalPagar { get; set; }
        public ICollection<DetalleAlquiler> Detalles { get; set; }
    }
}
