using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoDepartamental.App.Persistencia;
using TorneoDepartamental.App.Dominio;

namespace TorneoDepartamental.App.Frontend.Pages.NovedadesPartidos
{
    public class AddEquipoModel : PageModel
    {
        private readonly IRepositorioEquipo _repoEquipo;
        private readonly IRepositorioNovedadesPartido _repoNovedadesPartido;

        public AddEquipoModel(IRepositorioEquipo repoEquipo, IRepositorioNovedadesPartido repoNovedadesPartido)
        {
            _repoEquipo = repoEquipo;
            _repoNovedadesPartido = repoNovedadesPartido;
        }
        public NovedadesPartido novPartido{get;set;}
        public IEnumerable<Equipo> equipos{get;set;}

        public void OnGet(int id)
        {
            novPartido = _repoNovedadesPartido.GetNovedadesPartido(id);
            equipos = _repoEquipo.GetAllEquipos();
        }
        public IActionResult OnPost(int idNovPartido, int idEquipo)
        {
            if(!ModelState.IsValid){
                return Page();
            }
            _repoNovedadesPartido.AsignarEquipo(idNovPartido,idEquipo);
            return RedirectToPage("Details",new{id=idNovPartido});
        }
    }
}