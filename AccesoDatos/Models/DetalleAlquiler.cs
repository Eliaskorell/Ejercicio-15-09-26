using System;
using System.Collections.Generic;
using System.Text;

namespace AccesoDatos.Models
{
    public class DetalleAlquiler
    {
        public int Id_detalle { get; set; }    // PK, necesita [Key] o llamarse Id/DetalleAlquilerId
        public int Id_alquiler { get; set; }   // FK -> Alquiler
        public Alquiler Alquiler { get; set; } // navegación
        public int Patente { get; set; }       // FK -> Vehículo
        public Vehículo Vehiculo { get; set; } // navegación
        public int CantidadDias { get; set; }
        public int PrecioPorDia { get; set; }  // foto del precio al momento del alquiler
        public int Subtotal { get; set; }
    }
}
