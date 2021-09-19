using System;
namespace TorneoDepartamental.App.Dominio
{
    public class Partido
    {
        public int Id { get; set;}
        public Estadio Estadio { get; set;}
        public DateTime FechaPartido  { get; set; } // DateTime.Now.ToString("dd-MM-yyyy")
        public DateTime HoraPartido  { get; set; }  // DateTime.Now.ToString("hh-mm-ss")
        public Equipo EquipoLocal { get; set;}
        public int MarcadorLocal { get; set;}
        public Equipo EquipoVisitante { get; set;}
        public int MarcadorVisitante { get; set;}
        public Arbitro Arbitro { get; set;}
        public System.Collections.Generic.List<NovedadesPartido> NovedadesDelPartido { get; set; } //Puede tener muchas o varias novedades un partiod
    }
}