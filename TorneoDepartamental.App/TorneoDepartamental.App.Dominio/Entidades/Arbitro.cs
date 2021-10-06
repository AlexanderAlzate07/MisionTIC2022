using System.ComponentModel.DataAnnotations;
namespace TorneoDepartamental.App.Dominio
{
    public class Arbitro
    {
        public int Id { get; set; }
        [Required(ErrorMessage="El nombre es obligatorio")]
        [Display(Name="Nombre del arbitro")]
        public string Nombre { get; set; }
        [Display(Name="Telefono del arbitro")]
        public string Telefono { get; set; }
        [Required(ErrorMessage="El documento es obligatorio")]
        [Display(Name="Documento del arbitro")]
        public string Documento { get; set; }
        [Display(Name="Colegio de arbitros")]
        public string ColegioArbitro {get; set;}
    }
}