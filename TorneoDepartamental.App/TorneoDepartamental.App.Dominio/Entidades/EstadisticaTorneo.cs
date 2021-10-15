using System.ComponentModel.DataAnnotations;

namespace TorneoDepartamental.App.Dominio
{
    public class EstadisticaTorneo
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Rellene el campo")]
        [Display(Name = "Partidos Jugados")]
        public int CantidadPartidosJugados { get; set; }
        [Display(Name = "Partidos Ganados")]
        [Required(ErrorMessage = "Rellene el campo")]
        public int CantidadPartidosGanados { get; set; }
        [Display(Name = "Partidos Empatados")]
        [Required(ErrorMessage = "Rellene el campo")]
        public int CantidadPartidosEmpatados { get; set; }
        [Display(Name = "Goles A favor")]
        [Required(ErrorMessage = "Rellene el campo")]
        public int GolesAfavor { get; set; }
        [Display(Name = "Goles En Contra")]
        [Required(ErrorMessage = "Rellene el campo")]
        public int GolesEnContra { get; set; }
        [Display(Name = "Puntos")]
        [Required(ErrorMessage = "Rellene el campo")]
        public int Puntos { get; set; }
        public Equipo Equipo { get; set; }

    }
}