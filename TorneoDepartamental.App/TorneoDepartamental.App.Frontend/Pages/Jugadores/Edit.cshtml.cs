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
    public class EditModel : PageModel
    {
        private readonly IRepositorioJugador _repoJugador;
        [BindProperty]
        public Jugador jugador{get;set;}
        public EditModel(IRepositorioJugador repoJugador){
            _repoJugador = repoJugador;
        }
        public IActionResult OnGet(int id)
        {
            
            jugador = _repoJugador.GetJugador(id);
            if(jugador == null)
                return NotFound();
            return Page();
        }
        public IActionResult OnPost(Jugador jugador)
        {
            if(!ModelState.IsValid)
                return Page();
            if(jugador.Id>0){
                jugador = _repoJugador.UpdateJugador(jugador);
            }else{
                _repoJugador.AddJugador(jugador);
            }
            
            return Page();
        }
    }
}
