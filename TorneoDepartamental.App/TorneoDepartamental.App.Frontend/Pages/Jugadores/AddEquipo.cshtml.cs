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
    public class AddEquipoModel : PageModel
    {
        private readonly IRepositorioJugador _repoJugador;
        private readonly IRepositorioEquipo _repoEquipo;

        public AddEquipoModel(IRepositorioJugador repoJugador, IRepositorioEquipo repoEquipo)
        {
            _repoJugador = repoJugador;
            _repoEquipo = repoEquipo;
        }
        public Jugador jugador{get;set;}
        public IEnumerable<Equipo> equipos{get;set;}
        public void OnGet(int id)
        {
            jugador = _repoJugador.GetJugador(id);
            equipos = _repoEquipo.GetAllEquipos();
        }
        public IActionResult OnPost(int idJugador, int idEquipo)
        {
            if(!ModelState.IsValid){
                return Page();
            }
            _repoJugador.AsignarEquipo(idJugador,idEquipo);
            return RedirectToPage("Details",new{id=idJugador});
        }
    }
}
