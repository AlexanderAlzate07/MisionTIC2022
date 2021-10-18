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
    public class EditModel : PageModel
    {
        private readonly IRepositorioEstadisticasTorneo _repoEstadistica;
        public EstadisticaTorneo estadistica { get; set; }
        public EditModel(IRepositorioEstadisticasTorneo repoEstadistica)
        {
            _repoEstadistica = repoEstadistica;
        }
        public IActionResult OnGet(int id)
        {
            estadistica = _repoEstadistica.GetEstadisticasTorneo(id);
            if (estadistica == null)
            {
                return NotFound();
            }
            else
            {
                return Page();
            }
        }
        
        public IActionResult OnPost(EstadisticaTorneo estadistica)
        {
            _repoEstadistica.UpdateEstadisticasTorneo(estadistica);
            return RedirectToPage("Index");
        }
    }
}
