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
    public class CreateModel : PageModel
    {
        private readonly IRepositorioEstadio _repoEstadio;

        public CreateModel(IRepositorioEstadio repoEstadio)
        {
            _repoEstadio = repoEstadio;
        }

        public Estadio estadio{get;set;}
        public void OnGet()
        {
            estadio = new Estadio();
        }
        public IActionResult OnPost(Estadio estadio)
        {
            if(!ModelState.IsValid){
                return Page();
            }
            _repoEstadio.AddEstadio(estadio);
            return RedirectToPage("Index");
            
        }
        
    }
}
