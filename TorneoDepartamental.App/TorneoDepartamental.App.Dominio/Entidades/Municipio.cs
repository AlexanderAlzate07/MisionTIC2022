using System.ComponentModel.DataAnnotations;
namespace TorneoDepartamental.App.Dominio
{
    public class Municipio
    {
        public int Id { get; set; }
        [Required(ErrorMessage="El nombre es obligatorio")]
        [Display(Name="Nombre del municipio")]
        public string Nombre { get; set; }
    }
}