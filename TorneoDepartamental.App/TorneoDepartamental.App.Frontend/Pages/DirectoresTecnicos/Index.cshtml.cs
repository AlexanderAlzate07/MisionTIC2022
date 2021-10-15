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
        public string bActual {get;set;}
        public string gActual {get; set;}
        public void OnGet(string b, string g)
        {
            //Search
            if (String.IsNullOrEmpty(b) && String.IsNullOrEmpty(g))
            {
                bActual = "";
                DirectorTecnicos = _repoDirectorTecnico.GetAllDirectorTecnicos();
            }
            else if (!String.IsNullOrEmpty(b) && String.IsNullOrEmpty(g))
            {
                bActual = b;
                DirectorTecnicos = _repoDirectorTecnico.SearchDirectorTecnico(b);
            }
            //Filter
            else if (!String.IsNullOrEmpty(g) && g != "-1")
            {
                gActual = g;    
                DirectorTecnicos = _repoDirectorTecnico.FilterDirectorTecnico(g);
            }
            else if (!String.IsNullOrEmpty(g) && g=="-1"){
                gActual = "-1";
                DirectorTecnicos = _repoDirectorTecnico.GetAllDirectorTecnicos();
            }
        }
    }
}
