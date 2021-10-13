using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AcciTransito.App.Persistencia.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AgenteTransito",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<int>(type: "int", nullable: false),
                    NumeroAgente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Grupo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgenteTransito", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Coordenadas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Latitud = table.Column<float>(type: "real", nullable: false),
                    Longitud = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coordenadas", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoDocumento = table.Column<int>(type: "int", nullable: false),
                    NumeroIdentificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumeroCelular = table.Column<long>(type: "bigint", nullable: false),
                    ContactoAlterno = table.Column<long>(type: "bigint", nullable: false),
                    CorreoElectronico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Genero = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Accidentes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroAccidente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TipoAccidente = table.Column<int>(type: "int", nullable: false),
                    Peritaje = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Coordenadasid = table.Column<int>(type: "int", nullable: true),
                    Barrio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgenteTransitoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accidentes", x => x.id);
                    table.ForeignKey(
                        name: "FK_Accidentes_AgenteTransito_AgenteTransitoId",
                        column: x => x.AgenteTransitoId,
                        principalTable: "AgenteTransito",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Accidentes_Coordenadas_Coordenadasid",
                        column: x => x.Coordenadasid,
                        principalTable: "Coordenadas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Vehiculos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Placa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modelo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoVehiculo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LicenciaTransito = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Personaid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehiculos", x => x.id);
                    table.ForeignKey(
                        name: "FK_Vehiculos_Personas_Personaid",
                        column: x => x.Personaid,
                        principalTable: "Personas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Personas_Accidente",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Personaid = table.Column<int>(type: "int", nullable: true),
                    Accidenteid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas_Accidente", x => x.id);
                    table.ForeignKey(
                        name: "FK_Personas_Accidente_Accidentes_Accidenteid",
                        column: x => x.Accidenteid,
                        principalTable: "Accidentes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personas_Accidente_Personas_Personaid",
                        column: x => x.Personaid,
                        principalTable: "Personas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Vehiculos_Accidente",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Accidenteid = table.Column<int>(type: "int", nullable: true),
                    Vehiculoid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehiculos_Accidente", x => x.id);
                    table.ForeignKey(
                        name: "FK_Vehiculos_Accidente_Accidentes_Accidenteid",
                        column: x => x.Accidenteid,
                        principalTable: "Accidentes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vehiculos_Accidente_Vehiculos_Vehiculoid",
                        column: x => x.Vehiculoid,
                        principalTable: "Vehiculos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accidentes_AgenteTransitoId",
                table: "Accidentes",
                column: "AgenteTransitoId");

            migrationBuilder.CreateIndex(
                name: "IX_Accidentes_Coordenadasid",
                table: "Accidentes",
                column: "Coordenadasid");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_Accidente_Accidenteid",
                table: "Personas_Accidente",
                column: "Accidenteid");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_Accidente_Personaid",
                table: "Personas_Accidente",
                column: "Personaid");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_Personaid",
                table: "Vehiculos",
                column: "Personaid");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_Accidente_Accidenteid",
                table: "Vehiculos_Accidente",
                column: "Accidenteid");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_Accidente_Vehiculoid",
                table: "Vehiculos_Accidente",
                column: "Vehiculoid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personas_Accidente");

            migrationBuilder.DropTable(
                name: "Vehiculos_Accidente");

            migrationBuilder.DropTable(
                name: "Accidentes");

            migrationBuilder.DropTable(
                name: "Vehiculos");

            migrationBuilder.DropTable(
                name: "AgenteTransito");

            migrationBuilder.DropTable(
                name: "Coordenadas");

            migrationBuilder.DropTable(
                name: "Personas");
        }
    }
}
