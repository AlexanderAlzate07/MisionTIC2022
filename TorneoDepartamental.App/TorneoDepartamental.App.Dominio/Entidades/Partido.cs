using System;
using System.ComponentModel.DataAnnotations;

namespace TorneoDepartamental.App.Dominio
{
    public class Partido
    {
        public int Id { get; set;}
        public Estadio Estadio { get; set;}
        [Required(ErrorMessage ="Ingrese fecha valida")]
        public DateTime FechaPartido  { get; set; } // DateTime.Now.ToString("dd-MM-yyyy")
        [Required(ErrorMessage ="Ingrese hora valida")]
        public DateTime HoraPartido  { get; set; }  // DateTime.Now.ToString("hh-mm-ss")
        public Equipo EquipoLocal { get; set;}
        [Required(ErrorMessage ="Ingrese marcador")]
        public int MarcadorLocal { get; set;}
        public Equipo EquipoVisitante { get; set;}
        [Required(ErrorMessage ="Ingrese marcador")]
        public int MarcadorVisitante { get; set;}
        public Arbitro Arbitro { get; set;}
        // public System.Collections.Generic.List<NovedadesPartido> NovedadesDelPartido { get; set; } //Puede tener una o varias novedades un partido
    }
}