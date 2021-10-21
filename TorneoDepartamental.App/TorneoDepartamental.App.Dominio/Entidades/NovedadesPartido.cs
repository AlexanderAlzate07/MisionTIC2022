using System.ComponentModel.DataAnnotations;

namespace TorneoDepartamental.App.Dominio
{
    public class NovedadesPartido
    {
        public int Id { get; set;}
         [Required(ErrorMessage ="Ingrese todos los campos")]
        public string MinutoPartido { get; set;}
         [Required(ErrorMessage ="Ingrese todos los campos")]
        public string Tarjeta { get; set;}
         [Required(ErrorMessage ="Ingrese todos los campos")]
        public int Gol{ get; set;}
        public Partido Partido { get; set;}
        public Equipo Equipo{ get; set;} //Para saber el jugador del equipo
        public Jugador Jugador{ get; set;}

    }
}
