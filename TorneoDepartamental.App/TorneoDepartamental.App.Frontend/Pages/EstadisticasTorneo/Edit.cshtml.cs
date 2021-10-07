using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoDepartamental.App.Persistencia;
using TorneoDepartamental.App.Dominio;


namespace TorneoDepartamental.App.Frontend.Pages.EstadisticasTorneo
{
    public class EditModel : PageModel
    {
        private readonly IRepositorioEstadisticasTorneo _repoEstadisticaTorneo;
        [BindProperty]
        public EstadisticaTorneo estadistica{get;set;}

        public EditModel(IRepositorioEstadisticasTorneo repoEstadisticaTorneo)
        {
            _repoEstadisticaTorneo = repoEstadisticaTorneo;
        }
        public IActionResult OnGet(int id)
        {
            
            estadistica = _repoEstadisticaTorneo.GetEstadisticasTorneo(id);
            if(estadistica == null)
                return NotFound();
            return Page();
        }
        public IActionResult OnPost(EstadisticaTorneo estadistica)
        {
            if(!ModelState.IsValid)
                return Page();
            if(estadistica.Id>0){
                estadistica = _repoEstadisticaTorneo.UpdateEstadisticasTorneo(estadistica);
            }else{
                _repoEstadisticaTorneo.AddEstadisticasTorneo(estadistica);
            }
            
            return Page();
        }
    }
}
