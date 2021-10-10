using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using TorneoDepartamental.App.Dominio;
using TorneoDepartamental.App.Persistencia;

namespace TorneoDepartamental.App.Frontend.Pages.Partidos
{
    public class AddArbitroModel : PageModel
    {
        public readonly IRepositorioPartido _repoPartido;
        public readonly IRepositorioArbitro _repoArbitro;
        public Partido partido {get;set;}
        public IEnumerable<Arbitro>arbitros {get;set;}
        public AddArbitroModel(IRepositorioPartido repoPartido, IRepositorioArbitro repoArbitro)
        {
            _repoPartido = repoPartido;
            _repoArbitro = repoArbitro;
        }
        public void OnGet(int id)
        {
            partido = _repoPartido.GetPartido(id);
            arbitros = _repoArbitro.GetAllArbitros();
        }

        public IActionResult OnPost(int idPartido, int idArbitro)
        {
            _repoPartido.AsignarArbitro(idPartido, idArbitro);
            return RedirectToPage("Index");
        }
    }
}
