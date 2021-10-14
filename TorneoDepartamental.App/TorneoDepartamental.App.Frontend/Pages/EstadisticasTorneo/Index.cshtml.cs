using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoDepartamental.App.Persistencia;
using TorneoDepartamental.App.Dominio;

namespace TorneoDepartamental.App.Frontend.Pages.EstadisticasTorneo
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioEstadisticasTorneo _repoEstadisticaTorneo;
        public IEnumerable<EstadisticaTorneo> EstadisticaTorneos{get;set;}
        public string bActual {get;set;}
        public IndexModel(IRepositorioEstadisticasTorneo repoEstadisticaTorneo){
            _repoEstadisticaTorneo = repoEstadisticaTorneo;
        }
        public void OnGet(string b)
        {
            if (String.IsNullOrEmpty(b))
            {
                bActual = "";
                EstadisticaTorneos = _repoEstadisticaTorneo.GetAllEstadisticasTorneos();
            }
            else
            {
                bActual = b;
                EstadisticaTorneos = _repoEstadisticaTorneo.SearchEstadisticasTorneo(b);
            }
            
        }
    }
}
