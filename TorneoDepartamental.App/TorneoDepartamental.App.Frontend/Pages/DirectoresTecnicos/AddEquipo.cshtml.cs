using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoDepartamental.App.Persistencia;
using TorneoDepartamental.App.Dominio;

namespace TorneoDepartamental.App.Frontend.Pages.DirectoresTecnicos
{
    public class AddEquipoModel : PageModel
    {
        private readonly IRepositorioEquipo _repoEquipo;
        private readonly IRepositorioDirectorTecnico _repoDirectorTecnico;

        public AddEquipoModel(IRepositorioEquipo repoEquipo, IRepositorioDirectorTecnico repoDirectorTecnico)
        {
            _repoEquipo = repoEquipo;
            _repoDirectorTecnico = repoDirectorTecnico;
        }
        public DirectorTecnico tecnico{get;set;}
        public IEnumerable<Equipo> equipos{get;set;}
        public void OnGet(int id)
        {
            tecnico = _repoDirectorTecnico.GetDirectorTecnico(id);
            equipos = _repoEquipo.GetAllEquipos();
        }
        public IActionResult OnPost(int idDirectorTecnico, int idEquipo)
        {
            if(!ModelState.IsValid){
                return Page();
            }
            _repoDirectorTecnico.AsignarEquipo(idDirectorTecnico,idEquipo);
            return RedirectToPage("Details",new{id=idDirectorTecnico});
        }
    }
}
