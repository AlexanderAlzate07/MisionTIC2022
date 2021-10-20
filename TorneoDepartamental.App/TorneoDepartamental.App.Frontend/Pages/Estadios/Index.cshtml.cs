using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoDepartamental.App.Dominio;
using TorneoDepartamental.App.Persistencia;

namespace TorneoDepartamental.App.Frontend.Pages.Estadios
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly IRepositorioEstadio _repoEstadio;
        public IEnumerable<Estadio> Estadios { get; set; }
        public string bActual { get; set; }
        public string gActual { get; set; }
        public IndexModel(IRepositorioEstadio repoEstadio)
        {
            _repoEstadio = repoEstadio;

        }

        public void OnGet(string b, string g)
        {
            //Search
            if (String.IsNullOrEmpty(b) && String.IsNullOrEmpty(g))
            {
                bActual = "";
                Estadios = _repoEstadio.GetAllEstadios();
            }
            else if (!String.IsNullOrEmpty(b) && String.IsNullOrEmpty(g))
            {
                bActual = b;
                Estadios = _repoEstadio.SearchEstadio(b);
            }
            //Filter
            else if (!String.IsNullOrEmpty(g) && g != "-1")
            {
                gActual = g;
                Estadios = _repoEstadio.FilterEstadio(g);
            }
            else if (!String.IsNullOrEmpty(g) && g == "-1")
            {
                gActual = "-1";
                Estadios = _repoEstadio.GetAllEstadios();
            }
        }
    }
}
