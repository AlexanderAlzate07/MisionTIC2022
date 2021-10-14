using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoDepartamental.App.Persistencia;
using TorneoDepartamental.App.Dominio;

namespace TorneoDepartamental.App.Frontend.Pages.NovedadesPartidos
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioNovedadesPartido _repoNovedadesPartido;
        public IEnumerable<NovedadesPartido> NovedadesPartidos{get;set;}
        public DateTime bActual {get;set;}
        public IndexModel(IRepositorioNovedadesPartido repoNovedadesPartido){
            _repoNovedadesPartido = repoNovedadesPartido;
        }
        public void OnGet(DateTime b)
        {
            if (b.Day==1 && b.Month==1 && b.Year == 1)
            {
                bActual = new DateTime(0001, 1, 1, 0, 0, 0);
                NovedadesPartidos = _repoNovedadesPartido.GetAllNovedadesPartidos();
            }
            else
            {
                bActual = b;
                NovedadesPartidos = _repoNovedadesPartido.SearchNovedadPartido(b);
            }
            
            
        }
    }
}
