using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoDepartamental.App.Dominio;
using TorneoDepartamental.App.Persistencia;

namespace TorneoDepartamental.App.Frontend.Pages.EstadisticasTorneo
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly IRepositorioEstadisticasTorneo _repoEstadisticaTorneo;
        public IEnumerable<EstadisticaTorneo> EstadisticaTorneos { get; set; }
        public string bActual { get; set; }
        public string gActual { get; set; }
        public IndexModel(IRepositorioEstadisticasTorneo repoEstadisticaTorneo)
        {
            _repoEstadisticaTorneo = repoEstadisticaTorneo;
        }
        public void OnGet(string b, string g)
        {
            //Search
            if (String.IsNullOrEmpty(b) && String.IsNullOrEmpty(g))
            {
                bActual = "";
                EstadisticaTorneos = _repoEstadisticaTorneo.GetAllEstadisticasTorneos();
            }
            else if (!String.IsNullOrEmpty(b) && String.IsNullOrEmpty(g))
            {
                bActual = b;
                EstadisticaTorneos = _repoEstadisticaTorneo.SearchEstadisticasTorneo(b);
            }
            //Filter
            else if (!String.IsNullOrEmpty(g) && g != "-1")
            {
                gActual = g;
                EstadisticaTorneos = _repoEstadisticaTorneo.FilterEstadisticasTorneo(g);
            }
            else if (!String.IsNullOrEmpty(g) && g == "-1")
            {
                gActual = "-1";
                EstadisticaTorneos = _repoEstadisticaTorneo.GetAllEstadisticasTorneos();
            }
        }
    }
}
