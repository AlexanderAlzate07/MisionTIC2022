using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoDepartamental.App.Persistencia;
using TorneoDepartamental.App.Dominio;

namespace TorneoDepartamental.App.Frontend.Pages.Estadios
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioEstadio _repoEstadio;
        public IEnumerable<Estadio> Estadios{get;set;}
        public string bActual {get;set;}
        public IndexModel(IRepositorioEstadio repoEstadio){
            _repoEstadio = repoEstadio;
        }
        public void OnGet(string b)
        {
            if (String.IsNullOrEmpty(b))
            {
                bActual = "";
                Estadios = _repoEstadio.GetAllEstadios();
            }
            else
            {
                bActual = b;
                Estadios = _repoEstadio.SearchEstadio(b);
            }
            
        }
    }
}
