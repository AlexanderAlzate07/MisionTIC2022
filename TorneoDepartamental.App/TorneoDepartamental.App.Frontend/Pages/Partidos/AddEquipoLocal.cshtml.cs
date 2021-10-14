using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoDepartamental.App.Persistencia;
using TorneoDepartamental.App.Dominio;

namespace TorneoDepartamental.App.Frontend.Pages.Partidos
{
    public class AddEquipoLocalModel : PageModel
    {
        private readonly IRepositorioPartido _repoPartido;
        private readonly IRepositorioEquipo _repoEquipo;

        public AddEquipoLocalModel(IRepositorioPartido repoPartido, IRepositorioEquipo repoEquipo)
        {
            _repoPartido = repoPartido;
            _repoEquipo = repoEquipo;
        }
        public Partido partido{get;set;}
        public IEnumerable<Equipo> equipos{get;set;}

        public void OnGet(int id)
        {
            partido = _repoPartido.GetPartido(id);
            equipos = _repoEquipo.GetAllEquipos();
        }
        public IActionResult OnPost(int idPartido, int idEquipo)
        {
            if(!ModelState.IsValid){
                return Page();
            }
            _repoPartido.AsignarEquipoLocal(idPartido,idEquipo);
            return RedirectToPage("Details",new{id=idPartido});
        }
    }
}
