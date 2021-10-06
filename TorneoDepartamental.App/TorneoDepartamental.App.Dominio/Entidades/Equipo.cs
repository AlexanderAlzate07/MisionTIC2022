using System;
using System.ComponentModel.DataAnnotations;
namespace TorneoDepartamental.App.Dominio
{
    public class Equipo
    {
        public int Id { get; set; }
        [Required(ErrorMessage="El nombre es obligatorio")]
        [Display(Name="Nombre del Equipo")]
        public string Nombre { get; set; }
        public Municipio Municipio { get; set; }
    }
}