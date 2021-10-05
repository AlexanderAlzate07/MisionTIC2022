using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoDepartamental.App.Dominio;
using TorneoDepartamental.App.Persistencia;

namespace TorneoDepartamental.App.Frontend.Pages.DirectoresTecnicos
{
    public class CreateModel : PageModel
    {
        private readonly IRepositorioDirectorTecnico _repoTecnico;
        public DirectorTecnico tecnico { get; set; }
        public CreateModel(IRepositorioDirectorTecnico repoTecnico)
        {
            _repoTecnico = repoTecnico;
        }
        public void OnGet()
        {
            tecnico = new DirectorTecnico();
        }
        public IActionResult OnPost(DirectorTecnico tecnico)
        {
            if (ModelState.IsValid)
            {
                _repoTecnico.AddDirectorTecnico(tecnico);
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}