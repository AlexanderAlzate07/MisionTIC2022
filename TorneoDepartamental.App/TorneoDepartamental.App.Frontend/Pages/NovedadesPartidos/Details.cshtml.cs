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
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioNovedadesPartido _repoNovedadesPartido;
        public NovedadesPartido novPartido{get;set;}
        public DetailsModel(IRepositorioNovedadesPartido repoNovedadesPartido){
            _repoNovedadesPartido = repoNovedadesPartido;
        }
        public IActionResult OnGet(int id)
        {
            novPartido = _repoNovedadesPartido.GetNovedadesPartido(id);
            if(novPartido == null){
                return NotFound();
            }else{
                return Page();
            }
        }
    }
}
