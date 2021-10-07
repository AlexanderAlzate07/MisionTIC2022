using System.ComponentModel.DataAnnotations;
namespace TorneoDepartamental.App.Dominio
{
    public class Jugador
    {
        public int Id { get; set; }
        [Required(ErrorMessage="El nombre es obligatorio")]
        [Display(Name="Nombre del jugador")]
        public string Nombre { get; set; }
        [Required(ErrorMessage="El número de camiseta es obligatorio")]
        [Display(Name="Nombre del municipio")]
        public string NumeroCamiseta {get; set;}
        [Required(ErrorMessage="La posición es obligatorio")]
        [Display(Name="Posicion campo de juego")]
        public string Posicion {get; set;}
        public Equipo Equipo { get; set; }
    }
}