using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoDepartamental.App.Persistencia;
using TorneoDepartamental.App.Dominio;

namespace TorneoDepartamental.App.Frontend.Pages.Arbitros
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioArbitro _repoArbitro;
        public IEnumerable<Arbitro> Arbitros{get;set;}
        public string bActual {get;set;}
        public string gActual {get; set;}
        public IndexModel(IRepositorioArbitro repoArbitro){
            _repoArbitro = repoArbitro;
        }
        public void OnGet(string b, string g)
        {
            //Search
            if (String.IsNullOrEmpty(b) && String.IsNullOrEmpty(g))
            {
                bActual = "";
                Arbitros = _repoArbitro.GetAllArbitros();
            }
            else if (!String.IsNullOrEmpty(b) && String.IsNullOrEmpty(g))
            {
                bActual = b;
                Arbitros = _repoArbitro.SearchArbitro(b);
            }
            //Filter
            else if (!String.IsNullOrEmpty(g) && g != "-1")
            {
                gActual = g;    
                Arbitros = _repoArbitro.FilterArbitro(g);
            }
            else if (!String.IsNullOrEmpty(g) && g=="-1"){
                gActual = "-1";
                Arbitros = _repoArbitro.GetAllArbitros();
            }
        }
    }
}
