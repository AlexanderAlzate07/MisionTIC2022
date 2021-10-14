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
        public DateTime bActual {get;set;}
        public void OnGet(DateTime b)
        {
            if (b.Day==1 && b.Month==1 && b.Year == 1)
            {
                bActual = new DateTime(0001, 1, 1, 0, 0, 0);
                Partidos = _repoPartido.GetAllPartidos();
            }
            else
            {
                bActual = b;
                Partidos = _repoPartido.SearchPartido(b);
            }   
            
        }
    }
}
