using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoDepartamental.App.Dominio;
using TorneoDepartamental.App.Persistencia;


namespace TorneoDepartamental.App.Frontend.Pages.NovedadPartido
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioNovedadesPartido _repoNovedadesPartido;
        public IEnumerable<NovedadesPartido> NovedadesPartidos{get;set;}
        public IndexModel(IRepositorioNovedadesPartido repoNovedadesPartido)
        {
            _repoNovedadesPartido = repoNovedadesPartido;
        }
        public void OnGet()
        {
            NovedadesPartidos = _repoNovedadesPartido.GetAllNovedadesPartidos();
        }
        
    }
}
