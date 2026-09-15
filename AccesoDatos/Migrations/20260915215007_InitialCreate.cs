using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AccesoDatos.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    DNI = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Apellido = table.Column<string>(type: "TEXT", nullable: false),
                    Domicilio = table.Column<string>(type: "TEXT", nullable: false),
                    Telefono = table.Column<string>(type: "TEXT", nullable: false),
                    CorreoElectronico = table.Column<string>(type: "TEXT", nullable: false),
                    LicenciaConducir = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.DNI);
                });

            migrationBuilder.CreateTable(
                name: "Vehiculos",
                columns: table => new
                {
                    Patente = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Marca = table.Column<string>(type: "TEXT", nullable: false),
                    Modelo = table.Column<string>(type: "TEXT", nullable: false),
                    PrecioPorDia = table.Column<int>(type: "INTEGER", nullable: false),
                    CantidadDisponible = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehiculos", x => x.Patente);
                });

            migrationBuilder.CreateTable(
                name: "Alquileres",
                columns: table => new
                {
                    Id_alquiler = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DNI = table.Column<int>(type: "INTEGER", nullable: false),
                    ClienteDNI = table.Column<int>(type: "INTEGER", nullable: false),
                    FechaInicio = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FechaFin = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TotalPagar = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alquileres", x => x.Id_alquiler);
                    table.ForeignKey(
                        name: "FK_Alquileres_Clientes_ClienteDNI",
                        column: x => x.ClienteDNI,
                        principalTable: "Clientes",
                        principalColumn: "DNI",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetalleAlquileres",
                columns: table => new
                {
                    Id_detalle = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Id_alquiler = table.Column<int>(type: "INTEGER", nullable: false),
                    AlquilerId_alquiler = table.Column<int>(type: "INTEGER", nullable: false),
                    Patente = table.Column<int>(type: "INTEGER", nullable: false),
                    VehiculoPatente = table.Column<int>(type: "INTEGER", nullable: false),
                    CantidadDias = table.Column<int>(type: "INTEGER", nullable: false),
                    PrecioPorDia = table.Column<int>(type: "INTEGER", nullable: false),
                    Subtotal = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleAlquileres", x => x.Id_detalle);
                    table.ForeignKey(
                        name: "FK_DetalleAlquileres_Alquileres_AlquilerId_alquiler",
                        column: x => x.AlquilerId_alquiler,
                        principalTable: "Alquileres",
                        principalColumn: "Id_alquiler",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetalleAlquileres_Vehiculos_VehiculoPatente",
                        column: x => x.VehiculoPatente,
                        principalTable: "Vehiculos",
                        principalColumn: "Patente",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alquileres_ClienteDNI",
                table: "Alquileres",
                column: "ClienteDNI");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleAlquileres_AlquilerId_alquiler",
                table: "DetalleAlquileres",
                column: "AlquilerId_alquiler");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleAlquileres_VehiculoPatente",
                table: "DetalleAlquileres",
                column: "VehiculoPatente");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetalleAlquileres");

            migrationBuilder.DropTable(
                name: "Alquileres");

            migrationBuilder.DropTable(
                name: "Vehiculos");

            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
