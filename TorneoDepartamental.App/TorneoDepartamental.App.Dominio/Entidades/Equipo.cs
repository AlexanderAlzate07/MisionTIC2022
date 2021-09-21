using System;
namespace TorneoDepartamental.App.Dominio
{
    public class Equipo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Municipio Municipio { get; set; }
        // public DirectorTecnico directorTecnico { get; set; } //dialogar con el Cristhian
        public System.Collections.Generic.List<Jugador> Jugadores { get; set; }
    }
}