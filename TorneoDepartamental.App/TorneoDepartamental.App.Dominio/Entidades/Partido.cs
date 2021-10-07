using System;
using System.ComponentModel.DataAnnotations;
namespace TorneoDepartamental.App.Dominio
{
    public class Partido
    {
        public int Id { get; set;}
        public Estadio Estadio { get; set;}
        [Required(ErrorMessage="La FechaPartido es obligatorio")]
        [Display(Name="FechaPartido")]
        public DateTime FechaPartido  { get; set; } // DateTime.Now.ToString("dd-MM-yyyy")
        [Required(ErrorMessage="La Hora del partido es obligatoria")]
        [Display(Name="HoraPartido")]
        public DateTime HoraPartido  { get; set; }  // DateTime.Now.ToString("hh-mm-ss")
        public Equipo EquipoLocal { get; set;}
        [Required(ErrorMessage="El MarcadorLocal es obligatorio")]
        [Display(Name="MarcadorLocal")]
        public int MarcadorLocal { get; set;}
        public Equipo EquipoVisitante { get; set;}
        [Required(ErrorMessage="El MarcadorVisitante es obligatorio")]
        [Display(Name="MarcadorVisitante")]
        public int MarcadorVisitante { get; set;}
        public Arbitro Arbitro { get; set;}
        // public System.Collections.Generic.List<NovedadesPartido> NovedadesDelPartido { get; set; } //Puede tener una o varias novedades un partido
    }
}