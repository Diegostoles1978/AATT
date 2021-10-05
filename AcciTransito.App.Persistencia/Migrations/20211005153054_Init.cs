﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace AcciTransito.App.Persistencia.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "IX_Personas_Accidente_id_accidenteid",
                table: "Personas_Accidente",
                column: "id_accidenteid");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_Accidente_id_personaid",
                table: "Personas_Accidente",
                column: "id_personaid");

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
        }
    }
}
