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
        public DateTime gActual {get;set;}

        public void OnGet(DateTime b, DateTime g)
        {
            //Search
            if ((b.Day==1 && b.Month==1 && b.Year == 1) && (g.Day==1 && g.Month==1 && g.Year == 1))
            {
                bActual = new DateTime(0001, 1, 1, 0, 0, 0);
                Partidos = _repoPartido.GetAllPartidos();
            }
            else if (!(b.Day==1 && b.Month==1 && b.Year == 1) && (g.Day==1 && g.Month==1 && g.Year == 1))
            {
                bActual = b;
                Partidos = _repoPartido.SearchPartido(b);
            }
            //Filter
            else if ((b.Day==1 && b.Month==1 && b.Year == 1) && !(g.Day==1 && g.Month==1 && g.Year == 1))
            {
                gActual = g;    
                Partidos = _repoPartido.FilterPartido(g);
            }
            else if ((b.Day==1 && b.Month==1 && b.Year == 1) && (g.Day==1 && g.Month==1 && g.Year == 1)){
                gActual = new DateTime(0001, 1, 1, 0, 0, 0);
                Partidos = _repoPartido.GetAllPartidos();
            }
        }
    }
}
