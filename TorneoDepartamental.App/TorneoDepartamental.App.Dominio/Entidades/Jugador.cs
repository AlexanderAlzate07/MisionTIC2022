using System.ComponentModel.DataAnnotations;

namespace TorneoDepartamental.App.Dominio
{
    public class Jugador
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="El nombre es obligatorio")]
        [StringLength(50,ErrorMessage ="Maximo 50 caracteres")]
        public string Nombre { get; set; }
        [Required(ErrorMessage ="El nombre es obligatorio")]
        [StringLength(50,ErrorMessage ="Maximo 50 caracteres")]
        public string NumeroCamiseta {get; set;}
        [Required(ErrorMessage ="El nombre es obligatorio")]
        [StringLength(50,ErrorMessage ="Maximo 50 caracteres")]
        public string Posicion {get; set;}
        public Equipo Equipo { get; set; }
    }
}