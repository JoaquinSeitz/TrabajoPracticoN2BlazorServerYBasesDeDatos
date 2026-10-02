using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TrabajoPracticoN2BlazorServerYBasesDeDatos.Migrations
{
    /// <inheritdoc />
    public partial class AgregadoDeSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "Id", "Apellido", "Email", "Nombre", "Telefono" },
                values: new object[,]
                {
                    { 1, "Gómez", "laura.gomez@email.com", "Laura", "2954-15223344" },
                    { 2, "Martínez", "sofia.m@email.com", "Sofía", "2954-15667788" }
                });

            migrationBuilder.InsertData(
                table: "Servicios",
                columns: new[] { "Id", "Descripcion", "Nombre", "Precio" },
                values: new object[,]
                {
                    { 1, "Incluye extracción y máscara hidratante", "Limpieza Facial", 15000.00m },
                    { 2, "Sesión de 45 minutos", "Masaje Descontracturante", 12000.00m },
                    { 3, "Esmaltado de larga duración", "Manicura Semipermanente", 8500.00m }
                });

            migrationBuilder.InsertData(
                table: "Turnos",
                columns: new[] { "Id", "ClienteId", "FechaHora", "Observaciones", "ServicioId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2026, 10, 15, 10, 0, 0, 0, DateTimeKind.Unspecified), "Primera visita al centro", 1 },
                    { 2, 2, new DateTime(2026, 10, 15, 11, 30, 0, 0, DateTimeKind.Unspecified), "", 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Servicios",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Turnos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Turnos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Servicios",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Servicios",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
