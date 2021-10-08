using System.ComponentModel.DataAnnotations;

namespace TorneoDepartamental.App.Dominio
{
    public class DirectorTecnico
    {
        public int Id { get; set; }
         [Required(ErrorMessage ="El nombre es obligatorio")]
        [StringLength(50,ErrorMessage ="Maximo 50 caracteres")]
        public string Nombre { get; set; }
         [Required(ErrorMessage ="El Numero de telefono es obligatorio")]
        [StringLength(50,ErrorMessage ="Maximo 50 caracteres")]
        public string Telefono { get; set; }
         [Required(ErrorMessage ="Falta el numero de documento")]
        [StringLength(50,ErrorMessage ="Maximo 50 caracteres")]
        public string Documento { get; set; }
        public Equipo Equipo { get; set; }
    }
}