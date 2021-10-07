using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoDepartamental.App.Persistencia;
using TorneoDepartamental.App.Dominio;


namespace TorneoDepartamental.App.Frontend.Pages.Arbitros
{
    public class EditModel : PageModel
    {
        private readonly IRepositorioArbitro _repoArbitro;
        [BindProperty]
        public Arbitro arbitro{get;set;}
        public EditModel(IRepositorioArbitro repoArbitro)
        {
            _repoArbitro = repoArbitro;
        }
        public IActionResult OnGet(int id)
        {
            
            arbitro = _repoArbitro.GetArbitro(id);
            if(arbitro == null)
                return NotFound();
            return Page();
        }
        public IActionResult OnPost(Arbitro arbitro)
        {
            if(!ModelState.IsValid)
                return Page();
            if(arbitro.Id>0){
                arbitro = _repoArbitro.UpdateArbitro(arbitro);
            }else{
                _repoArbitro.AddArbitro(arbitro);
            }
            
            return Page();
        }
    }
}
