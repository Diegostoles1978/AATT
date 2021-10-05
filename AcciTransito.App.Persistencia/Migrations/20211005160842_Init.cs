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
                    NumeroAgente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Grupo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumeroCelular = table.Column<int>(type: "int", nullable: false)
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
                name: "Genero",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreGenero = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genero", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroIdentificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumeroCelular = table.Column<int>(type: "int", nullable: false),
                    CorreoElectronico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Generoid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.id);
                    table.ForeignKey(
                        name: "FK_Personas_Genero_Generoid",
                        column: x => x.Generoid,
                        principalTable: "Genero",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Vehiculo",
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
                    table.PrimaryKey("PK_Vehiculo", x => x.id);
                    table.ForeignKey(
                        name: "FK_Vehiculo_Personas_Personaid",
                        column: x => x.Personaid,
                        principalTable: "Personas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Accidente",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroAccidente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Peritaje = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdCoordenadasid = table.Column<int>(type: "int", nullable: true),
                    Vehiculosid = table.Column<int>(type: "int", nullable: true),
                    AgenteTransitoId = table.Column<int>(type: "int", nullable: true),
                    Personaid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accidente", x => x.id);
                    table.ForeignKey(
                        name: "FK_Accidente_AgenteTransito_AgenteTransitoId",
                        column: x => x.AgenteTransitoId,
                        principalTable: "AgenteTransito",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Accidente_Coordenadas_IdCoordenadasid",
                        column: x => x.IdCoordenadasid,
                        principalTable: "Coordenadas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Accidente_Personas_Personaid",
                        column: x => x.Personaid,
                        principalTable: "Personas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Accidente_Vehiculo_Vehiculosid",
                        column: x => x.Vehiculosid,
                        principalTable: "Vehiculo",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Personas_Accidente",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_personaid = table.Column<int>(type: "int", nullable: true),
                    id_accidenteid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas_Accidente", x => x.id);
                    table.ForeignKey(
                        name: "FK_Personas_Accidente_Accidente_id_accidenteid",
                        column: x => x.id_accidenteid,
                        principalTable: "Accidente",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personas_Accidente_Personas_id_personaid",
                        column: x => x.id_personaid,
                        principalTable: "Personas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Vehiculo_Accidente",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_Accidenteid = table.Column<int>(type: "int", nullable: true),
                    id_vehiculoid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehiculo_Accidente", x => x.id);
                    table.ForeignKey(
                        name: "FK_Vehiculo_Accidente_Accidente_id_Accidenteid",
                        column: x => x.id_Accidenteid,
                        principalTable: "Accidente",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vehiculo_Accidente_Vehiculo_id_vehiculoid",
                        column: x => x.id_vehiculoid,
                        principalTable: "Vehiculo",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accidente_AgenteTransitoId",
                table: "Accidente",
                column: "AgenteTransitoId");

            migrationBuilder.CreateIndex(
                name: "IX_Accidente_IdCoordenadasid",
                table: "Accidente",
                column: "IdCoordenadasid");

            migrationBuilder.CreateIndex(
                name: "IX_Accidente_Personaid",
                table: "Accidente",
                column: "Personaid");

            migrationBuilder.CreateIndex(
                name: "IX_Accidente_Vehiculosid",
                table: "Accidente",
                column: "Vehiculosid");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_Generoid",
                table: "Personas",
                column: "Generoid");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_Accidente_id_accidenteid",
                table: "Personas_Accidente",
                column: "id_accidenteid");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_Accidente_id_personaid",
                table: "Personas_Accidente",
                column: "id_personaid");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_Personaid",
                table: "Vehiculo",
                column: "Personaid");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_Accidente_id_Accidenteid",
                table: "Vehiculo_Accidente",
                column: "id_Accidenteid");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_Accidente_id_vehiculoid",
                table: "Vehiculo_Accidente",
                column: "id_vehiculoid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personas_Accidente");

            migrationBuilder.DropTable(
                name: "Vehiculo_Accidente");

            migrationBuilder.DropTable(
                name: "Accidente");

            migrationBuilder.DropTable(
                name: "AgenteTransito");

            migrationBuilder.DropTable(
                name: "Coordenadas");

            migrationBuilder.DropTable(
                name: "Vehiculo");

            migrationBuilder.DropTable(
                name: "Personas");

            migrationBuilder.DropTable(
                name: "Genero");
        }
    }
}
