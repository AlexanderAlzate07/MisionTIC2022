using System.ComponentModel.DataAnnotations;
namespace TorneoDepartamental.App.Dominio
{
    public class Estadio
    {
        public int Id { get; set; }
        [Required(ErrorMessage="El nombre es obligatorio")]
        [Display(Name="Nombre del Estadio")]
        public string Nombre { get; set; }
        [Required(ErrorMessage="La dirección es obligatoria")]
        [Display(Name="Nombre del municipio")]
        public string Direccion { get; set; }
        public Municipio Municipio { get; set; }
    }
}