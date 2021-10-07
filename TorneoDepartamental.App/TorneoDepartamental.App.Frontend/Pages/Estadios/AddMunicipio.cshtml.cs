using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoDepartamental.App.Dominio;
using TorneoDepartamental.App.Persistencia;

namespace TorneoDepartamental.App.Frontend.Pages.Estadios
{
    public class AddMunicipioModel : PageModel
    {
         private readonly IRepositorioEstadio _repoEstadio;
        private readonly IRepositorioMunicipio _repoMunicipio;
        public Estadio estadio { get; set; }
        public IEnumerable<Municipio> municipios { get; set; }
        public AddMunicipioModel(IRepositorioEstadio repoEstadio, IRepositorioMunicipio repoMuncipio)
        {
            _repoEstadio = repoEstadio;
            _repoMunicipio = repoMuncipio;
        }
        public void OnGet(int id)
        {
            
            estadio = _repoEstadio.GetEstadio(id);
            municipios = _repoMunicipio.GetAllMunicipios();
        }

        public IActionResult OnPost(int idEstadio, int idMunicipio)
        {
            _repoEstadio.AsignarMunicipio(idEstadio, idMunicipio);
            return RedirectToPage("Index");
        }
    }
}
