using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoDepartamental.App.Dominio;
using TorneoDepartamental.App.Persistencia;

namespace TorneoDepartamental.App.Frontend.Pages.Partidos
{
    public class EditModel : PageModel
    {
        private readonly IRepositorioPartido _repoPartido;
        [BindProperty]
        public Partido partido{get;set;}
        public EditModel(IRepositorioPartido repoPartido)
        {
            _repoPartido = repoPartido;
            
        }
        public IActionResult OnGet(int id)
        {
            
            partido = _repoPartido.GetPartido(id);
            if(partido == null)
                return NotFound();
            return Page();
        }
        public IActionResult OnPost(Partido partido)
        {
            if(!ModelState.IsValid)
                return Page();
            if(partido.Id>0){
                partido = _repoPartido.UpdatePartido(partido);
            }
            else
            {
                _repoPartido.AddPartido(partido);
            }
            
            return RedirectToPage("Index");
        }
    }
}
