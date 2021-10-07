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
    public class EditModel : PageModel
    {
        private readonly IRepositorioDirectorTecnico _repoDirectorTecnico;
        [BindProperty]
        public DirectorTecnico tecnico{get;set;}

        public EditModel(IRepositorioDirectorTecnico repoDirectorTecnico)
        {
            _repoDirectorTecnico = repoDirectorTecnico;
            
        }
        public IActionResult OnGet(int id)
        {
            tecnico = _repoDirectorTecnico.GetDirectorTecnico(id);
            if(tecnico == null)
                return NotFound();
            return Page();
        }
        public IActionResult OnPost(DirectorTecnico tecnico)
        {
            if(!ModelState.IsValid)
                return Page();
            if(tecnico.Id>0){
                tecnico = _repoDirectorTecnico.UpdateDirectorTecnico(tecnico);
            }else{
                _repoDirectorTecnico.AddDirectorTecnico(tecnico);
            }
            
            return Page();
        }
    }
}
