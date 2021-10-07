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
    public class CreateModel : PageModel
    {
        private readonly IRepositorioDirectorTecnico _repoDirectorTecnico;
        [BindProperty]
        public DirectorTecnico tecnico{get;set;}

        public CreateModel(IRepositorioDirectorTecnico repoDirectorTecnico)
        {
            _repoDirectorTecnico = repoDirectorTecnico;
            
        }
        public void OnGet()
        {
            tecnico = new DirectorTecnico();
        }
        public IActionResult OnPost(DirectorTecnico tecnico)
        {
            if(!ModelState.IsValid){
                return Page();
            }
            _repoDirectorTecnico.AddDirectorTecnico(tecnico);
            return RedirectToPage("Index");
            
        }
    }
}
