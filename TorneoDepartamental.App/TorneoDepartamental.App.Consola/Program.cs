using System;
using System.Collections.Generic;
using TorneoDepartamental.App.Dominio;
using TorneoDepartamental.App.Persistencia;

namespace TorneoDepartamental.App.Consola
{
    class Program
    {
        private static IRepositorioMunicipio _repoMunicipio = new RepositorioMunicipio(new Persistencia.AppContext());
        private static IRepositorioEquipo _repoEquipo = new RepositorioEquipo(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            //------------------------  CRUD MUNICIPIO----------------
            // AddMunicipio("Bello");
            // GetMunicipio(4);
            // GetAllMunicipios();
            DeleteMunicipio(8);
            DeleteMunicipio(9);
            // UpdateMunicipio(5);
            //--------------------------------------------------------

            //------------------------  CRUD EQUIPO-------------------
            // AddEquipo("Juventus",1);
            AsignarMunicipio(1,1);
            //--------------------------------------------------------

            Console.WriteLine("Hello World!");

        }

        private static void AddMunicipio(string nombreMunicipio){
            var municipio = new Municipio{
                Nombre = nombreMunicipio
            };
            _repoMunicipio.AddMunicipio(municipio);
        }
        private static void GetMunicipio(int idMunicipio){
           var municipio = _repoMunicipio.GetMunicipio(idMunicipio);
           System.Console.WriteLine("Nombre del municipio encontrado: "+municipio.Nombre);
        }

        private static void GetAllMunicipios(){
            IEnumerable<Municipio> listaMunicipios = _repoMunicipio.GetAllMunicipios();
            System.Console.WriteLine("Cantidad de municipios: "+listaMunicipios.ToString());
        }
        private static void DeleteMunicipio(int idMunicipio){
            _repoMunicipio.DeleteMunicipio(idMunicipio);
            System.Console.WriteLine("Se borró el municipio con id: "+idMunicipio);
        }
        private static void UpdateMunicipio(int idMunicipio, string nombreNuevo){
            Municipio municipioEncontrado = _repoMunicipio.GetMunicipio(idMunicipio);
            municipioEncontrado.Nombre = nombreNuevo;
            Municipio municipioUpdated = _repoMunicipio.UpdateMunicipio(municipioEncontrado);
        }

        private static void AddEquipo(string nombreEquipo, int idMunicipio){
            var municipioEncontrado = _repoMunicipio.GetMunicipio(idMunicipio);
            System.Console.WriteLine("Municipio encontrado: "+municipioEncontrado.Nombre);
            var equipo = new Equipo{
                Nombre = nombreEquipo
            };
            _repoEquipo.AddEquipo(equipo);
        }
        private static void AsignarMunicipio(int idEquipo, int idMunicipio){
            _repoEquipo.AsignarMunicipio(idEquipo,idMunicipio);
        }
    }
}
