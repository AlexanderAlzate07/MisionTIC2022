using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoDepartamental.App.Persistencia;
using TorneoDepartamental.App.Dominio;

namespace TorneoDepartamental.App.Frontend.Pages.Jugadores
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioJugador _repoJugador;
        public IEnumerable<Jugador> Jugadores{get;set;}
        public string bActual {get;set;}
        public string gActual {get;set;}
        public IndexModel(IRepositorioJugador repoJugador){
            _repoJugador = repoJugador;
        }
        public void OnGet(string b, string g)
        {
            //Search
            if (String.IsNullOrEmpty(b) && String.IsNullOrEmpty(g))
            {
                bActual = "";
                Jugadores = _repoJugador.GetAllJugadores();
            }
            else if (!String.IsNullOrEmpty(b) && String.IsNullOrEmpty(g))
            {
                bActual = b;
                Jugadores = _repoJugador.SearchJugador(b);
            }
            //Filter
            else if (!String.IsNullOrEmpty(g) && g != "-1")
            {
                gActual = g;    
                Jugadores = _repoJugador.FilterJugador(g);
            }
            else if (!String.IsNullOrEmpty(g) && g=="-1"){
                gActual = "-1";
                Jugadores = _repoJugador.GetAllJugadores();
            }
        }
    }
}
