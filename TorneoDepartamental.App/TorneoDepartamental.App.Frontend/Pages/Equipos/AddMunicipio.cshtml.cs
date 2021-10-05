using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoDepartamental.App.Dominio;
using TorneoDepartamental.App.Persistencia;

namespace TorneoDepartamental.App.Frontend.Pages.Equipos
{
    public class AddMunicipioModel : PageModel
    {
        private readonly IRepositorioEquipo _repoEquipo;
        private readonly IRepositorioMunicipio _repoMunicipio;
        public Equipo equipo { get; set; }
        public IEnumerable<Municipio> municipios { get; set; }
        public AddMunicipioModel(IRepositorioEquipo repoEquipo, IRepositorioMunicipio repoMuncipio)
        {
            _repoEquipo = repoEquipo;
            _repoMunicipio = repoMuncipio;
        }
        public void OnGet(int id)
        {
            equipo = _repoEquipo.GetEquipo(id);
            municipios = _repoMunicipio.GetAllMunicipios();
        }

        public IActionResult OnPost(int idEquipo, int idMunicipio)
        {
            _repoEquipo.AsignarMunicipio(idEquipo, idMunicipio);
            return RedirectToPage("Index");
        }
    }
}
