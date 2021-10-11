using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoDepartamental.App.Persistencia;
using TorneoDepartamental.App.Dominio;

namespace TorneoDepartamental.App.Frontend.Pages.Equipos
{
    public class AddMunicipioModel : PageModel
    {
        private readonly IRepositorioEquipo _repoEquipo;
        private readonly IRepositorioMunicipio _repoMunicipio;

        public AddMunicipioModel(IRepositorioEquipo repoEquipo, IRepositorioMunicipio repoMunicipio)
        {
            _repoEquipo = repoEquipo;
            _repoMunicipio = repoMunicipio;
        }
        [BindProperty]
        public Equipo equipo{get;set;}
        public IEnumerable<Municipio> municipios{get;set;}
        
        public void OnGet(int id)
        {
            equipo = _repoEquipo.GetEquipo(id);
            municipios = _repoMunicipio.GetAllMunicipios();
        }
        public IActionResult OnPost(int idEquipo, int idMunicipio)
        {
            System.Console.WriteLine("On post: "+idEquipo+" - "+idMunicipio);
            if(!ModelState.IsValid){
                return Page();
            }
            var municipio = _repoEquipo.AsignarMunicipio(idEquipo,idMunicipio);
            System.Console.WriteLine("Municipio asignado: "+municipio.Nombre);
            return RedirectToPage("Details",new{id=idEquipo});
        }
    }
}
