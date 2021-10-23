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
        public string bActual {get;set;}
        public string gActual {get; set;}
        public IndexModel(IRepositorioEquipo repoEquipo,IRepositorioMunicipio repoMunicipio){
            _repoEquipo = repoEquipo;
            _repoMunicipio = repoMunicipio;

        }
        public void OnGet(string b, string g)
        {
            //Search
            if (String.IsNullOrEmpty(b) && String.IsNullOrEmpty(g))
            {
                bActual = "";
                Equipos = _repoEquipo.GetAllEquipos();
            }
            else if (!String.IsNullOrEmpty(b) && String.IsNullOrEmpty(g))
            {
                bActual = b;
                Equipos = _repoEquipo.SearchEquipo(b);
            }
            //Filter
            else if (!String.IsNullOrEmpty(g) && g != "-1")
            {
                gActual = g;    
                Equipos = _repoEquipo.FilterEquipo(g);
            }
            else if (!String.IsNullOrEmpty(g) && g=="-1"){
               gActual = "-1";
               Equipos = _repoEquipo.GetAllEquipos();
             }
        }
    }
}
