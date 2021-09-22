using System;
using TorneoDepartamental.App.Dominio;
using TorneoDepartamental.App.Persistencia;

namespace TorneoDepartamental.App.Consola
{
    class Program
    {
        private static IRepositorioMunicipio _repoMunicipio = new RepositorioMunicipio(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            // AddMunicipio("Caldas");
            Console.WriteLine("Hello World!. Se agregó municipio");
        }

        private static void AddMunicipio(string nombreMunicipio){
            var municipio = new Municipio{
                Nombre = nombreMunicipio
            };
            _repoMunicipio.AddMunicipio(municipio);
        }
    }
}
