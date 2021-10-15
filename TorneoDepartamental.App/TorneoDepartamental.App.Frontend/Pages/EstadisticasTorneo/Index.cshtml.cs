using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoDepartamental.App.Dominio;
using TorneoDepartamental.App.Persistencia;

namespace TorneoDepartamental.App.Frontend.Pages.EstadisticasTorneo
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioEstadisticasTorneo _repoEstadisticasTorneo;
        public IEnumerable<EstadisticaTorneo> estadisticaTorneos {get;set;}
        public IndexModel(IRepositorioEstadisticasTorneo repoEstadisticaTorneo)
        {
            _repoEstadisticasTorneo = repoEstadisticaTorneo;
        }
        public void OnGet()
        {
            estadisticaTorneos = _repoEstadisticasTorneo.GetAllEstadisticasTorneos();
        }
    }
}
