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
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioEstadisticasTorneo _repoEstadisticaTorneo;
        public EstadisticaTorneo estadistica{get;set;}
        public DetailsModel(IRepositorioEstadisticasTorneo repoEstadisticaTorneo){
            _repoEstadisticaTorneo = repoEstadisticaTorneo;
        }
        public IActionResult OnGet(int id)
        {
            estadistica = _repoEstadisticaTorneo.GetEstadisticasTorneo(id);
            if(estadistica == null){
                return NotFound();
            }else{
                return Page();
            }
        }
    }
}
