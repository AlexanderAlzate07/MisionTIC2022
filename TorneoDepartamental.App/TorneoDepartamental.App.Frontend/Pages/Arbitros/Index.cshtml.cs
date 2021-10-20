using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoDepartamental.App.Dominio;
using TorneoDepartamental.App.Persistencia;

namespace TorneoDepartamental.App.Frontend.Pages.Arbitros
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly IRepositorioArbitro _repoArbitro;
        public IEnumerable<Arbitro> arbitros { get; set; }
        public string bActual { get; set; }
        public string gActual { get; set; }
        public IndexModel(IRepositorioArbitro repoArbitro)
        {
            _repoArbitro = repoArbitro;
        }
        public void OnGet(string b, string g)
        {
            //Search
            if (String.IsNullOrEmpty(b) && String.IsNullOrEmpty(g))
            {
                bActual = "";
                arbitros = _repoArbitro.GetAllArbitros();
            }
            else if (!String.IsNullOrEmpty(b) && String.IsNullOrEmpty(g))
            {
                bActual = b;
                arbitros = _repoArbitro.SearchArbitros(b);
            }
            //Filter
            else if (!String.IsNullOrEmpty(g) && g != "-1")
            {
                gActual = g;
                arbitros = _repoArbitro.FilterArbitro(g);
            }
            else if (!String.IsNullOrEmpty(g) && g == "-1")
            {
                gActual = "-1";
                arbitros = _repoArbitro.GetAllArbitros();
            }
        }
    }
}
