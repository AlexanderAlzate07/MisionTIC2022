using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoDepartamental.App.Dominio;
using TorneoDepartamental.App.Persistencia;

namespace TorneoDepartamental.App.Frontend.Pages.DirectoresTecnicos
{
    public class AddEquipoModel : PageModel
    {
         private readonly IRepositorioDirectorTecnico _repoTecnico;
        private readonly IRepositorioEquipo _repoEquipo;
        public DirectorTecnico tecnico { get; set; }
        public IEnumerable<Equipo> equipos { get; set; }
        public AddEquipoModel(IRepositorioDirectorTecnico repoTecnico, IRepositorioEquipo repoEquipo)
        {
            _repoTecnico = repoTecnico;
            _repoEquipo = repoEquipo;
        }
        public void OnGet(int id)
        {
            tecnico = _repoTecnico.GetDirectorTecnico(id);
            equipos = _repoEquipo.GetAllEquipos();
        }

        public IActionResult OnPost(int idDirectorTecnico, int idEquipo)
        {
            _repoTecnico.AsignarEquipo(idDirectorTecnico, idEquipo);
            return RedirectToPage("Index");
        }
    }
}
