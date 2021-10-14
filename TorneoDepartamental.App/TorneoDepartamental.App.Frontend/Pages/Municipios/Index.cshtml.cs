using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoDepartamental.App.Persistencia;
using TorneoDepartamental.App.Dominio;

namespace TorneoDepartamental.App.Frontend.Pages.Municipios
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioMunicipio _repoMunicipio;
        public IEnumerable<Municipio> Municipios{get;set;}
        public string bActual {get;set;}
        public IndexModel(IRepositorioMunicipio repoMunicipio){
            _repoMunicipio = repoMunicipio;
        }
        public void OnGet(string b)
        {
            if (String.IsNullOrEmpty(b))
            {
                bActual = "";
                Municipios = _repoMunicipio.GetAllMunicipios();
            }
            else
            {
                bActual = b;
                Municipios = _repoMunicipio.SearchMunicipio(b);
            }
            
        }
    }
}
