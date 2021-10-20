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
    public class AssingJugadorModel : PageModel
    {
        private readonly IRepositorioNovedadesPartido _repoNovedadesPartido;
        private readonly IRepositorioJugador _repoJugador;

        public AssingJugadorModel(IRepositorioNovedadesPartido repoNovedadesPartido, IRepositorioJugador repoJugador)
        {
            _repoNovedadesPartido = repoNovedadesPartido;
            _repoJugador = repoJugador;
        }

        public NovedadesPartido novPartido { get; set; }
        public IEnumerable<Jugador> jugadores { get; set; }

        public void OnGet(int id)
        {
            novPartido = _repoNovedadesPartido.GetNovedadesPartido(id);
            jugadores = _repoJugador.GetAllJugadores();
        }
        public IActionResult OnPost(int idNovPartido, int idJugador)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _repoNovedadesPartido.AsignarJugador(idNovPartido, idJugador);
            return RedirectToPage("Details", new { id = idNovPartido });
        }
    }
}
