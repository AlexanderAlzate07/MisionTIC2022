using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoDepartamental.App.Dominio;
using TorneoDepartamental.App.Persistencia;

namespace TorneoDepartamental.App.Frontend.Pages.EstadisticasTorneo
{
    public class CreateModel : PageModel
    {
        private readonly IRepositorioEstadisticasTorneo _repoEstadisticas;
        public EstadisticaTorneo estadistica { get; set; }
        public CreateModel(IRepositorioEstadisticasTorneo repoEstadisticas)
        {
            _repoEstadisticas = repoEstadisticas;

        }
        public IActionResult OnPost(EstadisticaTorneo estadistica)
        {
            if (ModelState.IsValid)
            {
                _repoEstadisticas.AddEstadisticasTorneo(estadistica);
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}
