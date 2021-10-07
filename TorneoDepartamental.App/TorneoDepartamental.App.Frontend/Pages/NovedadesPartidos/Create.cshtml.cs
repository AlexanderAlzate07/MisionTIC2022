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
    public class CreateModel : PageModel
    {
        private readonly IRepositorioNovedadesPartido _repoNovedadesPartido;
        public NovedadesPartido novPartido{get;set;}

        public CreateModel(IRepositorioNovedadesPartido repoNovedadesPartido)
        {
            _repoNovedadesPartido = repoNovedadesPartido;
            
        }
        public void OnGet()
        {
            novPartido = new NovedadesPartido();
        }
        public IActionResult OnPost(NovedadesPartido novPartido)
        {
            if(!ModelState.IsValid){
                return Page();
            }
            _repoNovedadesPartido.AddNovedadesPartido(novPartido);
            return RedirectToPage("Index");
            
        }
    }
}
