using System;
using System.Collections.Generic;
using System.Text;
using AccesoDatos.Models;
using Microsoft.EntityFrameworkCore;

namespace AccesoDatos.Data
{
    public class AplicationDbContext : DbContext
    {
        public DbSet<Alquiler> Alquileres { get; set; }
    }
}
