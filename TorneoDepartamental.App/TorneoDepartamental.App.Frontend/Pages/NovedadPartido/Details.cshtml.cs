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
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioNovedadesPartido _repoNovedadesPartido;
        public NovedadesPartido novedadesPartido { get; set; }
        public DetailsModel(IRepositorioNovedadesPartido repoNovedadesPartido)
        {
            _repoNovedadesPartido = repoNovedadesPartido;
        }
        public IActionResult OnGet(int id)
        {
            novedadesPartido = _repoNovedadesPartido.GetNovedadesPartido(id);
            if (novedadesPartido == null)
            {
                return NotFound();
            }
            else
            {
                return Page();
            }
        }
    }
}
