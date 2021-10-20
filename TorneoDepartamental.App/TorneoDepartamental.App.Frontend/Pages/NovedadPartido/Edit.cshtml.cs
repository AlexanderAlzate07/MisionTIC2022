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
    public class EditModel : PageModel
    {
        private readonly IRepositorioNovedadesPartido _repoNovedadesPartido;
        [BindProperty]
        public NovedadesPartido novPartido { get; set; }
        public EditModel(IRepositorioNovedadesPartido repoNovedadesPartido)
        {
            _repoNovedadesPartido = repoNovedadesPartido;
        }
        public IActionResult OnGet(int id)
        {

            novPartido = _repoNovedadesPartido.GetNovedadesPartido(id);
            if (novPartido == null)
                return NotFound();
            return Page();
        }
        public IActionResult OnPost(NovedadesPartido novPartido)
        {
            if (!ModelState.IsValid)
                return Page();
            if (novPartido.Id > 0)
            {
                novPartido = _repoNovedadesPartido.UpdateNovedadesPartido(novPartido);
            }
            else
            {
                _repoNovedadesPartido.AddNovedadesPartido(novPartido);
            }

            return Page();
        }
    }
}
