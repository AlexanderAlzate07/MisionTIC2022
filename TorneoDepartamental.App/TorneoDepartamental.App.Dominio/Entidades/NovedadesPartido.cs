using System.ComponentModel.DataAnnotations;
namespace TorneoDepartamental.App.Dominio
{
    public class NovedadesPartido
    {
        public int Id { get; set;}
        [Required(ErrorMessage="El MinutoPartido es obligatorio")]
        [Display(Name="MinutoPartido")]
        public string MinutoPartido { get; set;}
        [Display(Name="Tarjeta")]
        public string Tarjeta { get; set;}
        [Display(Name="Gol")]
        public int Gol{ get; set;}
        public Partido Partido { get; set;}
        public Equipo Equipo{ get; set;} //Para saber el jugador del equipo
        public Jugador Jugador{ get; set;}

    }
}
