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
    public class AsignTeamModel : PageModel
    {
        private readonly IRepositorioEstadisticasTorneo _repoEstadistica;
        private readonly IRepositorioEquipo _repoEquipo;
        public EstadisticaTorneo estadistica { get; set; }
        public IEnumerable<Equipo> equipos { get; set; }
        public AsignTeamModel(IRepositorioEstadisticasTorneo repoEstadistica, IRepositorioEquipo repoEquipo)
        {
            _repoEstadistica = repoEstadistica;
            _repoEquipo = repoEquipo;
        }
        public void OnGet(int id)
        {
            estadistica = _repoEstadistica.GetEstadisticasTorneo(id);
            equipos = _repoEquipo.GetAllEquipos();
        }

        public IActionResult OnPost(int idEstadisticasTorneo, int idEquipo)
        {
            _repoEstadistica.AsignarEquipo(idEstadisticasTorneo, idEquipo);
            return RedirectToPage("Index");
        }
    }
}
