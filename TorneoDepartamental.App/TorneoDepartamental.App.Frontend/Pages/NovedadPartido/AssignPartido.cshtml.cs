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
    public class AssignPartidoModel : PageModel
    {
        private readonly IRepositorioNovedadesPartido _repoNovedadesPartido;
        private readonly IRepositorioPartido _repoPartido;

        public AssignPartidoModel(IRepositorioNovedadesPartido repoNovedadesPartido, IRepositorioPartido repoPartido)
        {
            _repoNovedadesPartido = repoNovedadesPartido;
            _repoPartido = repoPartido;
        }
        public NovedadesPartido novPartido { get; set; }
        public IEnumerable<Partido> partidos { get; set; }
        public void OnGet(int id)
        {
            novPartido = _repoNovedadesPartido.GetNovedadesPartido(id);
            partidos = _repoPartido.GetAllPartidos();
        }
        public IActionResult OnPost(int idNovPartido, int idPartido)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _repoNovedadesPartido.AsignarPartido(idNovPartido, idPartido);
            return RedirectToPage("Details", new { id = idNovPartido });
        }
    }
}
