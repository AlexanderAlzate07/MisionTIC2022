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
    
    
    public class AddEquipoModel : PageModel
    {
        private readonly IRepositorioEquipo _repoEquipo;
        private readonly IRepositorioEstadisticasTorneo _repoEstadisticaTorneo;

        public AddEquipoModel(IRepositorioEquipo repoEquipo, IRepositorioEstadisticasTorneo repoEstadisticaTorneo)
        {
            _repoEquipo = repoEquipo;
            _repoEstadisticaTorneo = repoEstadisticaTorneo;
        }
        public EstadisticaTorneo estadistica{get;set;}
        public IEnumerable<Equipo> equipos{get;set;}

        public void OnGet(int id)
        {
            estadistica = _repoEstadisticaTorneo.GetEstadisticasTorneo(id);
            equipos = _repoEquipo.GetAllEquipos();
        }
        public IActionResult OnPost(int idEstadistica, int idEquipo)
        {
            if(!ModelState.IsValid){
                return Page();
            }
            _repoEstadisticaTorneo.AsignarEquipo(idEstadistica,idEquipo);
            return RedirectToPage("Details",new{id=idEstadistica});
        }
    }
}
