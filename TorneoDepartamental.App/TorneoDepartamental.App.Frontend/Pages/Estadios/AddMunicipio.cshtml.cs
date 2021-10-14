using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoDepartamental.App.Persistencia;
using TorneoDepartamental.App.Dominio;

namespace TorneoDepartamental.App.Frontend.Pages.Estadios
{
    public class AddMunicipioModel : PageModel
    {
        private readonly IRepositorioEstadio _repoEstadio;
        private readonly IRepositorioMunicipio _repoMunicipio;

        public AddMunicipioModel(IRepositorioEstadio repoEstadio, IRepositorioMunicipio repoMunicipio)
        {
            _repoEstadio = repoEstadio;
            _repoMunicipio = repoMunicipio;
        }
        public Estadio estadio{get;set;}
        public IEnumerable<Municipio> municipios{get;set;}
        public void OnGet(int id)
        {
            estadio = _repoEstadio.GetEstadio(id);
            municipios = _repoMunicipio.GetAllMunicipios();
        }
        public IActionResult OnPost(int idEstadio, int idMunicipio)
        {
            System.Console.WriteLine("On post: "+idEstadio+" - "+idMunicipio);
            
            if(!ModelState.IsValid){
                return Page();
            }
            var municipio = _repoEstadio.AsignarMunicipio(idEstadio,idMunicipio);
            System.Console.WriteLine("Municipio asignado: "+municipio.Nombre);
            return RedirectToPage("Details",new{id=idEstadio});
        }
    }
}
