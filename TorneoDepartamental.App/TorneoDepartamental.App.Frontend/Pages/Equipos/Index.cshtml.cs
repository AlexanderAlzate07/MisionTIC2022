using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoDepartamental.App.Persistencia;
using TorneoDepartamental.App.Dominio;
namespace TorneoDepartamental.App.Frontend.Pages.Equipos
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioEquipo _repoEquipo;
        private readonly IRepositorioMunicipio _repoMunicipio;
        public IEnumerable<Equipo> Equipos{get;set;}
        public IEnumerable<Municipio> Municipios{get;set;}
        public string bActual {get;set;}
        public string gActual {get; set;}
        public IndexModel(IRepositorioEquipo repoEquipo,IRepositorioMunicipio repoMunicipio){
            _repoEquipo = repoEquipo;
            _repoMunicipio = repoMunicipio;

        }
        public void OnGet(string b, string g)
        {
            System.Console.WriteLine("parametros al inicio OnGet: "+"b: "+b+" - g: "+g);
            //Search
            if (String.IsNullOrEmpty(b) && String.IsNullOrEmpty(g))
            {
                bActual = "";
                Equipos = _repoEquipo.GetAllEquipos();
            }
            else if (!String.IsNullOrEmpty(b) && String.IsNullOrEmpty(g))
            {
                bActual = b;
                Equipos = _repoEquipo.SearchEquipo(b);
            }
            //Filter
            else if (!String.IsNullOrEmpty(g) && g != "-1")
            {
                gActual = g;    
                Equipos = _repoEquipo.FilterEquipo(g);
            }
            else if (!String.IsNullOrEmpty(g) && g=="-1"){
               gActual = "-1";
               Equipos = _repoEquipo.GetAllEquipos();
             }
             System.Console.WriteLine("parametros al final OnGet: "+"bActual: "+bActual+" - gActual: "+gActual);



            // Equipos = _repoEquipo.GetAllEquipos();
            // Municipios = _repoMunicipio.GetAllMunicipios();
            // var muni = _repoMunicipio.GetMunicipio(1);
            // foreach (var equipo in Equipos)
            // {
                
            //     // equipo.Municipio = muni;
            //     System.Console.WriteLine(equipo.Id+" -- "+equipo.Nombre+" -- ");
            //     foreach (var _property in equipo.GetType().GetProperties())
            //     {
            //         var prop = equipo.GetType().GetProperty(_property.Name);
            //         System.Console.WriteLine(prop);
                    
            //     }
            // }
            
        }
    }
}
