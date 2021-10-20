using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.DependencyInjection;
using TorneoDepartamental.App.Dominio;
using TorneoDepartamental.App.Persistencia;

namespace TorneoDepartamental.App.Frontend.Pages.DirectoresTecnicos
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly IRepositorioDirectorTecnico _repoTecnico;
        public IEnumerable<DirectorTecnico> directorTecnicos { get; set; }
        public string bActual { get; set; }
        public string gActual { get; set; }
        public IndexModel(IRepositorioDirectorTecnico repoTecnico)
        {
            _repoTecnico = repoTecnico;
        }
        public void OnGet(string b, string g)
        {
            //Search
            if (String.IsNullOrEmpty(b) && String.IsNullOrEmpty(g))
            {
                bActual = "";
                directorTecnicos = _repoTecnico.GetAllDirectorTecnicos();
            }
            else if (!String.IsNullOrEmpty(b) && String.IsNullOrEmpty(g))
            {
                bActual = b;
                directorTecnicos = _repoTecnico.SearchDirector(b);
            }
            //Filter
            else if (!String.IsNullOrEmpty(g) && g != "-1")
            {
                gActual = g;
                directorTecnicos = _repoTecnico.FilterDirectorTecnico(g);
            }
            else if (!String.IsNullOrEmpty(g) && g == "-1")
            {
                gActual = "-1";
                directorTecnicos = _repoTecnico.GetAllDirectorTecnicos();
            }
        }
    }
}
