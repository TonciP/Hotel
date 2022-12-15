using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Reserva.Infraestructure.Ef.Migrations
{
    public partial class InitialStructureWrite : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cliente",
                columns: table => new
                {
                    clienteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    nombres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    apellidos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cliente", x => x.clienteId);
                });

            migrationBuilder.CreateTable(
                name: "estadia",
                columns: table => new
                {
                    estadiaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    fechaIngreso = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fechaSalida = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_estadia", x => x.estadiaId);
                });

            migrationBuilder.CreateTable(
                name: "TipoHabitacion",
                columns: table => new
                {
                    habitacionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    nombreHabitacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cantidadDisponible = table.Column<int>(type: "int", nullable: false),
                    costo = table.Column<decimal>(type: "decimal(14,2)", precision: 14, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoHabitacion", x => x.habitacionId);
                });

            migrationBuilder.CreateTable(
                name: "Tracking",
                columns: table => new
                {
                    trackingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    hash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duracion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tracking", x => x.trackingId);
                });

            migrationBuilder.CreateTable(
                name: "Reservas",
                columns: table => new
                {
                    reservaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    trackingId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    habitacionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstadiaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    clienteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservas", x => x.reservaId);
                    table.ForeignKey(
                        name: "FK_Reservas_estadia_EstadiaId",
                        column: x => x.EstadiaId,
                        principalTable: "estadia",
                        principalColumn: "estadiaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_EstadiaId",
                table: "Reservas",
                column: "EstadiaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cliente");

            migrationBuilder.DropTable(
                name: "Reservas");

            migrationBuilder.DropTable(
                name: "TipoHabitacion");

            migrationBuilder.DropTable(
                name: "Tracking");

            migrationBuilder.DropTable(
                name: "estadia");
        }
    }
}
