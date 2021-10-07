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
    public class EditModel : PageModel
    {
        private readonly IRepositorioEquipo _repoEquipo;
        [BindProperty]
        public Equipo equipo{get;set;}
        public EditModel(IRepositorioEquipo repoEquipo){
            _repoEquipo = repoEquipo;
        }
        public IActionResult OnGet(int id)
        {
            
            equipo = _repoEquipo.GetEquipo(id);
            // System.Console.WriteLine("On get Id equipo: "+equipo.Id);
            if(equipo == null)
                return NotFound();
            return Page();
        }
        public IActionResult OnPost(Equipo equipo)
        {
            // System.Console.WriteLine("Id equipo: "+equipo.Id);
            if(!ModelState.IsValid)
                return Page();
            if(equipo.Id>0){
                equipo = _repoEquipo.UpdateEquipo(equipo);
            }else{
                _repoEquipo.AddEquipo(equipo);
            }
            
            return Page();
        }
    }
}
