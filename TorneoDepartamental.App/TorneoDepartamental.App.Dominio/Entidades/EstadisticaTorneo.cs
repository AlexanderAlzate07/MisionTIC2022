using System.ComponentModel.DataAnnotations;
namespace TorneoDepartamental.App.Dominio
{
    public class EstadisticaTorneo
    {
        public int Id { get; set; }
        [Required(ErrorMessage="La Cantidad Partidos Jugados es obligatorio")]
        [Display(Name="CantidadPartidosJugados")]
        public int CantidadPartidosJugados { get; set; }
        [Required(ErrorMessage="La Cantidad Partidos Ganados es obligatorio")]
        [Display(Name="CantidadPartidosGanados")]
        public int CantidadPartidosGanados { get; set; }
        [Required(ErrorMessage="La Cantidad Partidos Empatados es obligatorio")]
        [Display(Name="CantidadPartidosEmpatados")]
        public int CantidadPartidosEmpatados { get; set; }
        [Required(ErrorMessage="Los Goles A favor es obligatorio")]
        [Display(Name="GolesAfavor")]
        public int GolesAfavor { get; set; }
        [Required(ErrorMessage="Los Goles En Contra es obligatorio")]
        [Display(Name="GolesEnContra")]
        public int GolesEnContra { get; set; }
        [Required(ErrorMessage="Los Puntos En Contra es obligatorio")]
        [Display(Name="Puntos")]
        public int Puntos { get; set; }
        public Equipo Equipo { get; set; }
         
    }
}