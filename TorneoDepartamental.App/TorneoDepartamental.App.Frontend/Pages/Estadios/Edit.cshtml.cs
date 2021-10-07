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
    public class EditModel : PageModel
    {
        private readonly IRepositorioEstadio _repoEstadio;
        [BindProperty]
        public Estadio estadio{get;set;}
        public EditModel(IRepositorioEstadio repoEstadio)
        {
            _repoEstadio = repoEstadio;
        }

        public IActionResult OnGet(int id)
        {
            estadio = _repoEstadio.GetEstadio(id);
            if(estadio == null)
                return NotFound();
            return Page();
        }
        public IActionResult OnPost(Estadio estadio)
        {
            
            if(!ModelState.IsValid)
                return Page();
            if(estadio.Id>0){
                estadio = _repoEstadio.UpdateEstadio(estadio);
            }else{
                _repoEstadio.AddEstadio(estadio);
            }
            
            return Page();
        }
    }
}
