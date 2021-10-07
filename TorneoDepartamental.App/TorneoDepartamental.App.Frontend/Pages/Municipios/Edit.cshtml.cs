using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoDepartamental.App.Persistencia;
using TorneoDepartamental.App.Dominio;

namespace TorneoDepartamental.App.Frontend.Pages.Municipios
{
    public class EditModel : PageModel
    {
        private readonly IRepositorioMunicipio _repoMunicipio;
        [BindProperty]
        public Municipio municipio{get;set;}
        public EditModel(IRepositorioMunicipio repoMunicipio)
        {
            _repoMunicipio = repoMunicipio;
        }
        
        public IActionResult OnGet(int id)
        {
            municipio = _repoMunicipio.GetMunicipio(id);
            System.Console.WriteLine("On get Id municipio: "+municipio.Id);
            if(municipio == null)
                return NotFound();
            return Page();
        }
        public IActionResult OnPost(Municipio municipio)
        {
            if(!ModelState.IsValid)
                return Page();
            if(municipio.Id>0){
                municipio = _repoMunicipio.UpdateMunicipio(municipio);
            }else{
                _repoMunicipio.AddMunicipio(municipio);
            }
            return Page();
        }
    }
}
