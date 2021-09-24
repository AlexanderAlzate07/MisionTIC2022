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
        private static IRepositorioEstadio _repoEstadio = new RepositorioEstadio(new Persistencia.AppContext());
        private static IRepositorioJugador _repoJugador = new RepositorioJugador(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            //------------------------  CRUD MUNICIPIO----------------
            // AddMunicipio("Bello");
            // GetMunicipio(4);
            // GetAllMunicipios();
            // DeleteMunicipio(7);
            // UpdateMunicipio(5,"Bello");
            //--------------------------------------------------------

            //------------------------  CRUD EQUIPO-------------------
            // AddEquipo("Barcelona");
            // AsignarMunicipioAequipo(3,2);
            // UpdateEquipo(10,"Atletico Madrid",1);
            // GetEquipo(10);
            // DeleteEquipo(10);
            //--------------------------------------------------------

            //------------------------  CRUD ESTADIO -----------------
            // AddEstadio("Old Trafford","Calle 38d # 55a-69");
            // GetEstadio(2);
            // DeleteEstadio(5);
            // AsignarMunicipioAestadio(4,5);
            // UpdateEstadio(4,"Old Trafford","Calle 45c # 27-42",5);
            //--------------------------------------------------------

            //------------------------  CRUD JUGADOR -----------------
            // AddJugador("Alexander Alzate","7","volante");
            // GetJugador(1);
            AsignarEquipoAjugador(1,3);
            AsignarEquipoAjugador(2,5);
            // UpdateJugador(3,"Juan Ruiz","23","defensa",1);
            // DeleteJugador(3);

            Console.WriteLine("Hello World!");

        }

        //************************************************************
        //------------------------  CRUD MUNICIPIO    ----------------
        private static void AddMunicipio(string nombreMunicipio)
        {
            var municipio = new Municipio{
                Nombre = nombreMunicipio
            };
            _repoMunicipio.AddMunicipio(municipio);
        }
        private static void GetMunicipio(int idMunicipio)
        {
           var municipio = _repoMunicipio.GetMunicipio(idMunicipio);
           System.Console.WriteLine("Nombre del municipio encontrado: "+municipio.Nombre);
        }

        private static void GetAllMunicipios()
        {
            IEnumerable<Municipio> listaMunicipios = _repoMunicipio.GetAllMunicipios();
            System.Console.WriteLine("Cantidad de municipios: "+listaMunicipios.ToString());
        }
        private static void DeleteMunicipio(int idMunicipio)
        {
            _repoMunicipio.DeleteMunicipio(idMunicipio);
            System.Console.WriteLine("Se borró el municipio con id: "+idMunicipio);
        }
        private static void UpdateMunicipio(int idMunicipio, string nombreNuevo)
        {
            Municipio municipioEncontrado = _repoMunicipio.GetMunicipio(idMunicipio);
            municipioEncontrado.Nombre = nombreNuevo;
            Municipio municipioUpdated = _repoMunicipio.UpdateMunicipio(municipioEncontrado);
        }

        //************************************************************
        //------------------------  CRUD EQUIPO    -------------------

        private static void AddEquipo(string nombreEquipo)
        {
            var equipo = new Equipo{
                Nombre = nombreEquipo
            };
            _repoEquipo.AddEquipo(equipo);
        }
        
        private static void GetEquipo(int idEquipo)
        {
            var equipoEncontrado = _repoEquipo.GetEquipo(idEquipo);
            System.Console.WriteLine("Nombre del equipo encontrado: "+equipoEncontrado.Nombre);
        }
        private static void DeleteEquipo(int idEquipo)
        {
            _repoEquipo.DeleteEquipo(idEquipo);
        }
        private static void UpdateEquipo(int idEquipo, string nombreNuevo, int idMunicipioNuevo)
        {
            var municipioNuevo = _repoMunicipio.GetMunicipio(idMunicipioNuevo);
            if(municipioNuevo != null){
                var equipoEncontrado = _repoEquipo.GetEquipo(idEquipo);
                equipoEncontrado.Nombre = nombreNuevo;
                equipoEncontrado.Municipio = municipioNuevo;
                _repoEquipo.UpdateEquipo(equipoEncontrado);
            }
        }
        private static void AsignarMunicipioAequipo(int idEquipo, int idMunicipio)
        {
            _repoEquipo.AsignarMunicipio(idEquipo,idMunicipio);
        }

        //*************************************************************
        //------------------------  CRUD ESTADIO    -------------------
        private static void AddEstadio(string nombreEstadio, string direccion)
        {
            var estadio = new Estadio{
                Nombre = nombreEstadio,
                Direccion = direccion
            };
            _repoEstadio.AddEstadio(estadio);
        }

        private static void GetEstadio(int idEstadio)
        {
            var estadioEncontrado = _repoEstadio.GetEstadio(idEstadio);
            System.Console.WriteLine("Nombre del estadio encontrado: "+estadioEncontrado.Nombre);
        }

        private static void DeleteEstadio(int idEstadio)
        {
            _repoEstadio.DeleteEstadio(idEstadio);
        }

        private static void UpdateEstadio(int idEstadio, string nombreNuevo, string direccionNueva, int idMunicipioNuevo)
        {
            var municipioNuevo = _repoMunicipio.GetMunicipio(idMunicipioNuevo);
            if(municipioNuevo != null){
                var estadioEncontrado = _repoEstadio.GetEstadio(idEstadio);
                estadioEncontrado.Nombre = nombreNuevo;
                estadioEncontrado.Direccion = direccionNueva;
                estadioEncontrado.Municipio = municipioNuevo;
                _repoEstadio.UpdateEstadio(estadioEncontrado);
            }
        }
        private static void AsignarMunicipioAestadio(int idEstadio, int idMunicipio){
            _repoEstadio.AsignarMunicipio(idEstadio,idMunicipio);
        }

        //*************************************************************
        //------------------------  CRUD JUGADOR    -------------------
        private static void AddJugador(string nombre, string numeroCamiseta, string posicion)
        {
            var jugador = new Jugador{
                Nombre = nombre,
                NumeroCamiseta = numeroCamiseta,
                Posicion = posicion
            };
            _repoJugador.AddJugador(jugador);
        }
        private static void GetJugador(int idJugador)
        {
            var jugadorEncontrado = _repoJugador.GetJugador(idJugador);
            System.Console.WriteLine("Nombre del jugador encontrado: "+jugadorEncontrado.Nombre);
        }

        private static void DeleteJugador(int idJugador)
        {
            _repoJugador.DeleteJugador(idJugador);
        }
        private static void UpdateJugador(int idJugador,string nombreNuevo, string numeroCamisetaNueva, string posicionNueva, int idEquipoNuevo)
        {
            var jugadorEncontrado = _repoJugador.GetJugador(idJugador);
            if(jugadorEncontrado != null)
            {
                var equipoEncontrado = _repoEquipo.GetEquipo(idEquipoNuevo);
                if(equipoEncontrado != null)
                {
                    jugadorEncontrado.Nombre = nombreNuevo;
                    jugadorEncontrado.NumeroCamiseta = numeroCamisetaNueva;
                    jugadorEncontrado.Posicion = posicionNueva;
                    jugadorEncontrado.Equipo = equipoEncontrado;
                    _repoJugador.UpdateJugador(jugadorEncontrado);
                }
            }
        }
        private static void AsignarEquipoAjugador(int idJugador,int idEquipo)
        {
            _repoJugador.AsignarEquipo(idJugador,idEquipo);
        }

    }
}
