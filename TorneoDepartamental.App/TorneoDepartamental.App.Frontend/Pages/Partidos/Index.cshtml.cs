using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoDepartamental.App.Persistencia;
using TorneoDepartamental.App.Dominio;

namespace TorneoDepartamental.App.Frontend.Pages.Partidos
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioPartido _repoPartido;
        public IEnumerable<Partido> Partidos{get;set;}
        public IndexModel(IRepositorioPartido repoPartido){
            _repoPartido = repoPartido;
        }
        public void OnGet()
        {
            Partidos = _repoPartido.GetAllPartidos();
        }
    }
}
