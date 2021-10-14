using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoDepartamental.App.Persistencia;
using TorneoDepartamental.App.Dominio;

namespace TorneoDepartamental.App.Frontend.Pages.Partidos
{
    public class AddArbitroModel : PageModel
    {
        private readonly IRepositorioPartido _repoPartido;
        private readonly IRepositorioArbitro _repoArbitro;

        public AddArbitroModel(IRepositorioPartido repoPartido, IRepositorioArbitro repoArbitro)
        {
            _repoPartido = repoPartido;
            _repoArbitro = repoArbitro;
        }
        public Partido partido{get;set;}
        public IEnumerable<Arbitro> arbitros{get;set;}

        public void OnGet(int id)
        {
            partido = _repoPartido.GetPartido(id);
            arbitros = _repoArbitro.GetAllArbitros();
        }
        public IActionResult OnPost(int idPartido, int idArbitro)
        {
            if(!ModelState.IsValid){
                return Page();
            }
            _repoPartido.AsignarArbitro(idPartido,idArbitro);
            return RedirectToPage("Details",new{id=idPartido});
        }
    }
}
