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
    public class IndexModel : PageModel
    {
        private readonly IRepositorioArbitro _repoArbitro;
        public IEnumerable<Arbitro> Arbitros{get;set;}
        public IndexModel(IRepositorioArbitro repoArbitro){
            _repoArbitro = repoArbitro;
        }
        public void OnGet()
        {
            Arbitros = _repoArbitro.GetAllArbitros();
        }
    }
}
