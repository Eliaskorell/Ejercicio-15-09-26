using System;
using System.Collections.Generic;
using System.Text;
using AccesoDatos.Models;
using Microsoft.EntityFrameworkCore;

namespace AccesoDatos.Data
{
    public class AplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=alquileres.db");
        }
        public DbSet<Alquiler> Alquileres { get; set; }
        public DbSet<DetalleAlquiler> DetalleAlquileres { get; set; }
    }
}
