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
    public class EditModel : PageModel
    {
        private readonly IRepositorioDirectorTecnico _repoTecnico;
        public DirectorTecnico tecnico { get; set; }
        public EditModel(IRepositorioDirectorTecnico repoTecnico)
        {
            _repoTecnico = repoTecnico;
        }
        public IActionResult OnGet(int id)
        {
            tecnico = _repoTecnico.GetDirectorTecnico(id);
            if (tecnico == null)
            {
                return NotFound();
            }
            else
            {
                return Page();
            }
        }
        
        public IActionResult OnPost(DirectorTecnico tecnico)
        {
            _repoTecnico.UpdateDirectorTecnico(tecnico);
            return RedirectToPage("Index");
        }

    }
}
