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
    public class CreateModel : PageModel
    {
        private readonly IRepositorioEstadisticasTorneo _repoEstadisticaTorneo;
        public EstadisticaTorneo estadistica{get;set;}

        public CreateModel(IRepositorioEstadisticasTorneo repoEstadisticaTorneo)
        {
            _repoEstadisticaTorneo = repoEstadisticaTorneo;
        }
        public void OnGet()
        {
            estadistica = new EstadisticaTorneo();
        }
        public IActionResult OnPost(EstadisticaTorneo estadistica)
        {
            if(!ModelState.IsValid){
                return Page();
            }
            _repoEstadisticaTorneo.AddEstadisticasTorneo(estadistica);
            return RedirectToPage("Index");
            
        }
    }
}
