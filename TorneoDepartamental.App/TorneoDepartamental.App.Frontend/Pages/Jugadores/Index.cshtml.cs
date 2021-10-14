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
        public IndexModel(IRepositorioJugador repoJugador){
            _repoJugador = repoJugador;
        }
        public void OnGet(string b)
        {
            if (String.IsNullOrEmpty(b))
            {
                bActual = "";
                Jugadores = _repoJugador.GetAllJugadores();
            }
            else
            {
                bActual = b;
                Jugadores = _repoJugador.SearchJugador(b);
            }
            
        }
    }
}
