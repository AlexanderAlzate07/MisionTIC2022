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
        public IndexModel(IRepositorioEstadisticasTorneo repoEstadisticaTorneo){
            _repoEstadisticaTorneo = repoEstadisticaTorneo;
        }
        public void OnGet()
        {
            EstadisticaTorneos = _repoEstadisticaTorneo.GetAllEstadisticasTorneos();
        }
    }
}
