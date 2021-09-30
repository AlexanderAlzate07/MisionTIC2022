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
    public class IndexModel : PageModel
    {
        private readonly IRepositorioDirectorTecnico _repoDirectorTecnico;
        public IEnumerable<DirectorTecnico> DirectorTecnicos{get;set;}
        public IndexModel(IRepositorioDirectorTecnico repoDirectorTecnico){
            _repoDirectorTecnico = repoDirectorTecnico;
        }
        public void OnGet()
        {
            DirectorTecnicos = _repoDirectorTecnico.GetAllDirectorTecnicos();
        }
    }
}
