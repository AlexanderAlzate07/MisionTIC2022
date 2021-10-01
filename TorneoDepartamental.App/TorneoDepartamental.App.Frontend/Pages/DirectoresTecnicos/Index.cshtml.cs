using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.DependencyInjection;
using TorneoDepartamental.App.Dominio;
using TorneoDepartamental.App.Persistencia;

namespace TorneoDepartamental.App.Frontend.Pages.DirectoresTecnicos
{
    public class IndexModel : PageModel
    {
        
        private readonly IRepositorioDirectorTecnico _repoTecnico;
        public IEnumerable<DirectorTecnico> directorTecnicos { get; set; }
        public IndexModel(IRepositorioDirectorTecnico repoTecnico)
        {
            _repoTecnico = repoTecnico;
        }
        public void OnGet()
        {
            directorTecnicos = _repoTecnico.GetAllDirectorTecnicos();
        }
    }
}
