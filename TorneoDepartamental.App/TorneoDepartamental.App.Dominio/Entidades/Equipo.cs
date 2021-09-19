using System;
namespace TorneoDepartamental.App.Dominio
{
    public class Equipo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DirectorTecnico DirectorTecnico { get; set; }
        public System.Collections.Generic.List<Jugador> Jugadores { get; set; }
    }
}