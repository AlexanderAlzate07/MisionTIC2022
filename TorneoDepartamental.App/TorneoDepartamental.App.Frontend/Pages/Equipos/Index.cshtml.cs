using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoDepartamental.App.Persistencia;
using TorneoDepartamental.App.Dominio;
namespace TorneoDepartamental.App.Frontend.Pages.Equipos
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioEquipo _repoEquipo;
        private readonly IRepositorioMunicipio _repoMunicipio;
        public IEnumerable<Equipo> Equipos{get;set;}
        public IEnumerable<Municipio> Municipios{get;set;}
        public IndexModel(IRepositorioEquipo repoEquipo,IRepositorioMunicipio repoMunicipio){
            _repoEquipo = repoEquipo;
            _repoMunicipio = repoMunicipio;

        }
        public void OnGet()
        {
            Equipos = _repoEquipo.GetAllEquipos();
            // Municipios = _repoMunicipio.GetAllMunicipios();
            // var muni = _repoMunicipio.GetMunicipio(1);
            // foreach (var equipo in Equipos)
            // {
                
            //     // equipo.Municipio = muni;
            //     System.Console.WriteLine(equipo.Id+" -- "+equipo.Nombre+" -- ");
            //     foreach (var _property in equipo.GetType().GetProperties())
            //     {
            //         var prop = equipo.GetType().GetProperty(_property.Name);
            //         System.Console.WriteLine(prop);
                    
            //     }
            // }
            
        }
    }
}
