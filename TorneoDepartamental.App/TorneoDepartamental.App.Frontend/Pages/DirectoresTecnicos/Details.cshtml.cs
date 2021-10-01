using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoDepartamental.App.Persistencia;
using TorneoDepartamental.App.Dominio;

namespace TorneoDepartamental.App.Frontend.Pages.DirectoresTecnicos
{
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioDirectorTecnico _repoDirectorTecnico;
        public DirectorTecnico tecnico{get;set;}
        public DetailsModel(IRepositorioDirectorTecnico repoDirectorTecnico){
            _repoDirectorTecnico = repoDirectorTecnico;
        }
        public IActionResult OnGet(int id)
        {
            tecnico = _repoDirectorTecnico.GetDirectorTecnico(id);
            if(tecnico == null){
                return NotFound();
            }else{
                return Page();
            }
        }
    }
}
