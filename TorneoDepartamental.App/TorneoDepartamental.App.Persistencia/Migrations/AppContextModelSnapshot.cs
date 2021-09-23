﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TorneoDepartamental.App.Persistencia;

namespace TorneoDepartamental.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    partial class AppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("TorneoDepartamental.App.Dominio.Arbitro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ColegioArbitro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Documento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Arbitros");
                });

            modelBuilder.Entity("TorneoDepartamental.App.Dominio.DirectorTecnico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Documento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EquipoId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EquipoId");

                    b.ToTable("DirectoresTecnicos");
                });

            modelBuilder.Entity("TorneoDepartamental.App.Dominio.Equipo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("MunicipioId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MunicipioId");

                    b.ToTable("Equipos");
                });

            modelBuilder.Entity("TorneoDepartamental.App.Dominio.Estadio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MunicipioId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MunicipioId");

                    b.ToTable("Estadios");
                });

            modelBuilder.Entity("TorneoDepartamental.App.Dominio.EstadisticaTorneo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CantidadPartidosEmpatados")
                        .HasColumnType("int");

                    b.Property<int>("CantidadPartidosGanados")
                        .HasColumnType("int");

                    b.Property<int>("CantidadPartidosJugados")
                        .HasColumnType("int");

                    b.Property<int?>("EquipoId")
                        .HasColumnType("int");

                    b.Property<int>("GolesAfavor")
                        .HasColumnType("int");

                    b.Property<int>("GolesEnContra")
                        .HasColumnType("int");

                    b.Property<int>("Puntos")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EquipoId");

                    b.ToTable("EstadisticasTorneo");
                });

            modelBuilder.Entity("TorneoDepartamental.App.Dominio.Jugador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("EquipoId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroCamiseta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Posicion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EquipoId");

                    b.ToTable("Jugadores");
                });

            modelBuilder.Entity("TorneoDepartamental.App.Dominio.Municipio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Municipios");
                });

            modelBuilder.Entity("TorneoDepartamental.App.Dominio.NovedadesPartido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("EquipoId")
                        .HasColumnType("int");

                    b.Property<int>("Gol")
                        .HasColumnType("int");

                    b.Property<int?>("JugadorId")
                        .HasColumnType("int");

                    b.Property<string>("MinutoPartido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PartidoId")
                        .HasColumnType("int");

                    b.Property<string>("Tarjeta")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EquipoId");

                    b.HasIndex("JugadorId");

                    b.HasIndex("PartidoId");

                    b.ToTable("NovedadesPartidos");
                });

            modelBuilder.Entity("TorneoDepartamental.App.Dominio.Partido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("ArbitroId")
                        .HasColumnType("int");

                    b.Property<int?>("EquipoLocalId")
                        .HasColumnType("int");

                    b.Property<int?>("EquipoVisitanteId")
                        .HasColumnType("int");

                    b.Property<int?>("EstadioId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaPartido")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("HoraPartido")
                        .HasColumnType("datetime2");

                    b.Property<int>("MarcadorLocal")
                        .HasColumnType("int");

                    b.Property<int>("MarcadorVisitante")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ArbitroId");

                    b.HasIndex("EquipoLocalId");

                    b.HasIndex("EquipoVisitanteId");

                    b.HasIndex("EstadioId");

                    b.ToTable("Partidos");
                });

            modelBuilder.Entity("TorneoDepartamental.App.Dominio.DirectorTecnico", b =>
                {
                    b.HasOne("TorneoDepartamental.App.Dominio.Equipo", "Equipo")
                        .WithMany()
                        .HasForeignKey("EquipoId");

                    b.Navigation("Equipo");
                });

            modelBuilder.Entity("TorneoDepartamental.App.Dominio.Equipo", b =>
                {
                    b.HasOne("TorneoDepartamental.App.Dominio.Municipio", "Municipio")
                        .WithMany()
                        .HasForeignKey("MunicipioId");

                    b.Navigation("Municipio");
                });

            modelBuilder.Entity("TorneoDepartamental.App.Dominio.Estadio", b =>
                {
                    b.HasOne("TorneoDepartamental.App.Dominio.Municipio", "Municipio")
                        .WithMany()
                        .HasForeignKey("MunicipioId");

                    b.Navigation("Municipio");
                });

            modelBuilder.Entity("TorneoDepartamental.App.Dominio.EstadisticaTorneo", b =>
                {
                    b.HasOne("TorneoDepartamental.App.Dominio.Equipo", "Equipo")
                        .WithMany()
                        .HasForeignKey("EquipoId");

                    b.Navigation("Equipo");
                });

            modelBuilder.Entity("TorneoDepartamental.App.Dominio.Jugador", b =>
                {
                    b.HasOne("TorneoDepartamental.App.Dominio.Equipo", "Equipo")
                        .WithMany()
                        .HasForeignKey("EquipoId");

                    b.Navigation("Equipo");
                });

            modelBuilder.Entity("TorneoDepartamental.App.Dominio.NovedadesPartido", b =>
                {
                    b.HasOne("TorneoDepartamental.App.Dominio.Equipo", "Equipo")
                        .WithMany()
                        .HasForeignKey("EquipoId");

                    b.HasOne("TorneoDepartamental.App.Dominio.Jugador", "Jugador")
                        .WithMany()
                        .HasForeignKey("JugadorId");

                    b.HasOne("TorneoDepartamental.App.Dominio.Partido", "Partido")
                        .WithMany("NovedadesDelPartido")
                        .HasForeignKey("PartidoId");

                    b.Navigation("Equipo");

                    b.Navigation("Jugador");

                    b.Navigation("Partido");
                });

            modelBuilder.Entity("TorneoDepartamental.App.Dominio.Partido", b =>
                {
                    b.HasOne("TorneoDepartamental.App.Dominio.Arbitro", "Arbitro")
                        .WithMany()
                        .HasForeignKey("ArbitroId");

                    b.HasOne("TorneoDepartamental.App.Dominio.Equipo", "EquipoLocal")
                        .WithMany()
                        .HasForeignKey("EquipoLocalId");

                    b.HasOne("TorneoDepartamental.App.Dominio.Equipo", "EquipoVisitante")
                        .WithMany()
                        .HasForeignKey("EquipoVisitanteId");

                    b.HasOne("TorneoDepartamental.App.Dominio.Estadio", "Estadio")
                        .WithMany()
                        .HasForeignKey("EstadioId");

                    b.Navigation("Arbitro");

                    b.Navigation("EquipoLocal");

                    b.Navigation("EquipoVisitante");

                    b.Navigation("Estadio");
                });

            modelBuilder.Entity("TorneoDepartamental.App.Dominio.Partido", b =>
                {
                    b.Navigation("NovedadesDelPartido");
                });
#pragma warning restore 612, 618
        }
    }
}
