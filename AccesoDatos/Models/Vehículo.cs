using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AccesoDatos.Models
{
    public class Vehículo
    {
        public ICollection<DetalleAlquiler> DetalleAlquileres { get; set; }

        [Key]
        public int Patente { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int PrecioPorDia { get; set; }
        public int CantidadDisponible { get; set; }
    }
}
