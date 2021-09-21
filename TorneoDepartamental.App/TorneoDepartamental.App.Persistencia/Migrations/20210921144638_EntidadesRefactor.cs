using Microsoft.EntityFrameworkCore.Migrations;

namespace TorneoDepartamental.App.Persistencia.Migrations
{
    public partial class EntidadesRefactor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipos_Personas_DirectorTecnicoId",
                table: "Equipos");

            migrationBuilder.DropForeignKey(
                name: "FK_Municipios_Equipos_EquipoId",
                table: "Municipios");

            migrationBuilder.DropForeignKey(
                name: "FK_Municipios_Estadios_EstadioId",
                table: "Municipios");

            migrationBuilder.DropForeignKey(
                name: "FK_Partidos_Personas_ArbitroId",
                table: "Partidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Equipos_EquipoId",
                table: "Personas");

            migrationBuilder.DropIndex(
                name: "IX_Municipios_EquipoId",
                table: "Municipios");

            migrationBuilder.DropIndex(
                name: "IX_Municipios_EstadioId",
                table: "Municipios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Personas",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "EquipoId",
                table: "Municipios");

            migrationBuilder.DropColumn(
                name: "EstadioId",
                table: "Municipios");

            migrationBuilder.DropColumn(
                name: "Apellidos",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "ColegioArbitro",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "DiplomaDT",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Documento",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Rol",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Telefono",
                table: "Personas");

            migrationBuilder.RenameTable(
                name: "Personas",
                newName: "Jugadores");

            migrationBuilder.RenameColumn(
                name: "DirectorTecnicoId",
                table: "Equipos",
                newName: "MunicipioId");

            migrationBuilder.RenameIndex(
                name: "IX_Equipos_DirectorTecnicoId",
                table: "Equipos",
                newName: "IX_Equipos_MunicipioId");

            migrationBuilder.RenameIndex(
                name: "IX_Personas_EquipoId",
                table: "Jugadores",
                newName: "IX_Jugadores_EquipoId");

            migrationBuilder.AddColumn<int>(
                name: "JugadorId",
                table: "NovedadesPartidos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MunicipioId",
                table: "Estadios",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Jugadores",
                table: "Jugadores",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Arbitros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Documento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ColegioArbitro = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arbitros", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DirectoresTecnicos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Documento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EquipoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DirectoresTecnicos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DirectoresTecnicos_Equipos_EquipoId",
                        column: x => x.EquipoId,
                        principalTable: "Equipos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NovedadesPartidos_JugadorId",
                table: "NovedadesPartidos",
                column: "JugadorId");

            migrationBuilder.CreateIndex(
                name: "IX_Estadios_MunicipioId",
                table: "Estadios",
                column: "MunicipioId");

            migrationBuilder.CreateIndex(
                name: "IX_DirectoresTecnicos_EquipoId",
                table: "DirectoresTecnicos",
                column: "EquipoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipos_Municipios_MunicipioId",
                table: "Equipos",
                column: "MunicipioId",
                principalTable: "Municipios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Estadios_Municipios_MunicipioId",
                table: "Estadios",
                column: "MunicipioId",
                principalTable: "Municipios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Jugadores_Equipos_EquipoId",
                table: "Jugadores",
                column: "EquipoId",
                principalTable: "Equipos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NovedadesPartidos_Jugadores_JugadorId",
                table: "NovedadesPartidos",
                column: "JugadorId",
                principalTable: "Jugadores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Partidos_Arbitros_ArbitroId",
                table: "Partidos",
                column: "ArbitroId",
                principalTable: "Arbitros",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipos_Municipios_MunicipioId",
                table: "Equipos");

            migrationBuilder.DropForeignKey(
                name: "FK_Estadios_Municipios_MunicipioId",
                table: "Estadios");

            migrationBuilder.DropForeignKey(
                name: "FK_Jugadores_Equipos_EquipoId",
                table: "Jugadores");

            migrationBuilder.DropForeignKey(
                name: "FK_NovedadesPartidos_Jugadores_JugadorId",
                table: "NovedadesPartidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Partidos_Arbitros_ArbitroId",
                table: "Partidos");

            migrationBuilder.DropTable(
                name: "Arbitros");

            migrationBuilder.DropTable(
                name: "DirectoresTecnicos");

            migrationBuilder.DropIndex(
                name: "IX_NovedadesPartidos_JugadorId",
                table: "NovedadesPartidos");

            migrationBuilder.DropIndex(
                name: "IX_Estadios_MunicipioId",
                table: "Estadios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Jugadores",
                table: "Jugadores");

            migrationBuilder.DropColumn(
                name: "JugadorId",
                table: "NovedadesPartidos");

            migrationBuilder.DropColumn(
                name: "MunicipioId",
                table: "Estadios");

            migrationBuilder.RenameTable(
                name: "Jugadores",
                newName: "Personas");

            migrationBuilder.RenameColumn(
                name: "MunicipioId",
                table: "Equipos",
                newName: "DirectorTecnicoId");

            migrationBuilder.RenameIndex(
                name: "IX_Equipos_MunicipioId",
                table: "Equipos",
                newName: "IX_Equipos_DirectorTecnicoId");

            migrationBuilder.RenameIndex(
                name: "IX_Jugadores_EquipoId",
                table: "Personas",
                newName: "IX_Personas_EquipoId");

            migrationBuilder.AddColumn<int>(
                name: "EquipoId",
                table: "Municipios",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EstadioId",
                table: "Municipios",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Apellidos",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ColegioArbitro",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DiplomaDT",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Documento",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Rol",
                table: "Personas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Telefono",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Personas",
                table: "Personas",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Municipios_EquipoId",
                table: "Municipios",
                column: "EquipoId");

            migrationBuilder.CreateIndex(
                name: "IX_Municipios_EstadioId",
                table: "Municipios",
                column: "EstadioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipos_Personas_DirectorTecnicoId",
                table: "Equipos",
                column: "DirectorTecnicoId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Municipios_Equipos_EquipoId",
                table: "Municipios",
                column: "EquipoId",
                principalTable: "Equipos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Municipios_Estadios_EstadioId",
                table: "Municipios",
                column: "EstadioId",
                principalTable: "Estadios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Partidos_Personas_ArbitroId",
                table: "Partidos",
                column: "ArbitroId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Equipos_EquipoId",
                table: "Personas",
                column: "EquipoId",
                principalTable: "Equipos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
