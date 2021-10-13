using System;
using System.ComponentModel.DataAnnotations;

namespace TorneoDepartamental.App.Dominio
{
    public class Arbitro
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage ="El nombre es obligatorio")]
        [StringLength(50,ErrorMessage ="Maximo 50 caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage ="El Telefono es obligatorio")]
        [StringLength(20,ErrorMessage ="Maximo 20 caracteres")]
        public string Telefono { get; set; }

        [Required(ErrorMessage ="El documento es obligatorio")]
        [StringLength(20,ErrorMessage ="Maximo 20 caracteres")]
        public string Documento { get; set; }
        
        [Display(Name ="Colegio del Arbitro")]
        [Required(ErrorMessage ="El nombre del colegio es obligatorio")]
        [StringLength(50,ErrorMessage ="Maximo 50 caracteres")]
        public string ColegioArbitro {get; set;}


    }
}