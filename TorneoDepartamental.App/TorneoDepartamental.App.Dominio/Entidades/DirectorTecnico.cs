using System.ComponentModel.DataAnnotations;
namespace TorneoDepartamental.App.Dominio
{
    public class DirectorTecnico
    {
        public int Id { get; set; }
        [Required(ErrorMessage="El nombre es obligatorio")]
        [Display(Name="Nombre del tecnico")]
        public string Nombre { get; set; }
        [Required(ErrorMessage="El Telefono es obligatorio")]
        [Display(Name="Telefono del director tecnico")]
        public string Telefono { get; set; }
        [Required(ErrorMessage="El Documento es obligatorio")]
        [Display(Name="Documento del director tecnico")]
        public string Documento { get; set; }
        public Equipo Equipo { get; set; }
    }
}