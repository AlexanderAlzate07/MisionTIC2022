using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoDepartamental.App.Dominio;
using TorneoDepartamental.App.Persistencia;

namespace TorneoDepartamental.App.Frontend.Pages.Equipos
{
    public class CreateModel : PageModel
    {
        private readonly IRepositorioEquipo _repoEquipo;
        public Equipo equipo { get; set; }
        public CreateModel(IRepositorioEquipo repoEquipo)
        {
            _repoEquipo = repoEquipo;
        }
         public IActionResult OnPost(Equipo equipo)
        {
            if (ModelState.IsValid)
            {
                _repoEquipo.AddEquipo(equipo);
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
    }
}
}
