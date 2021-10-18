using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.DependencyInjection;
using TorneoDepartamental.App.Dominio;
using TorneoDepartamental.App.Persistencia;

namespace TorneoDepartamental.App.Frontend.Pages.DirectoresTecnicos
{
    [Authorize]
    public class IndexModel : PageModel
    {     
        private readonly IRepositorioDirectorTecnico _repoTecnico;
        public IEnumerable<DirectorTecnico> directorTecnicos { get; set; }
        public string bActual {get;set;}
        public IndexModel(IRepositorioDirectorTecnico repoTecnico)
        {
            _repoTecnico = repoTecnico;
        }
        public void OnGet(string b)
        {
            if (String.IsNullOrEmpty(b))
            {
                bActual = "";
                directorTecnicos = _repoTecnico.GetAllDirectorTecnicos();
            }
            else
            {
                bActual = b;
                directorTecnicos = _repoTecnico.SearchDirector(b);
            }
        }
    }
}
