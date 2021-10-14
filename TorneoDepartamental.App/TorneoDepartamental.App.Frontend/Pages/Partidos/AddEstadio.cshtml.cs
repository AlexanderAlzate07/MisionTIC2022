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
    public class AddEstadioModel : PageModel
    {
        private readonly IRepositorioPartido _repoPartido;
        private readonly IRepositorioEstadio _repoEstadio;

        public AddEstadioModel(IRepositorioPartido repoPartido, IRepositorioEstadio repoEstadio)
        {
            _repoPartido = repoPartido;
            _repoEstadio = repoEstadio;
        }

        public Partido partido{get;set;}
        public IEnumerable<Estadio> estadios{get;set;}

        public void OnGet(int id)
        {
            partido = _repoPartido.GetPartido(id);
            estadios = _repoEstadio.GetAllEstadios();
        }
        public IActionResult OnPost(int idPartido, int idEstadio)
        {
            if(!ModelState.IsValid){
                return Page();
            }
            _repoPartido.AsignarEstadio(idPartido,idEstadio);
            return RedirectToPage("Details",new{id=idPartido});
        }
    }
}
