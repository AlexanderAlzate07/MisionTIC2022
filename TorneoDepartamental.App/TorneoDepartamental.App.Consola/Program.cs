using System;
using System.Collections.Generic;
using TorneoDepartamental.App.Dominio;
using TorneoDepartamental.App.Persistencia;

namespace TorneoDepartamental.App.Consola
{
    class Program
    {
        private static IRepositorioMunicipio _repoMunicipio = new RepositorioMunicipio();
        private static IRepositorioEquipo _repoEquipo = new RepositorioEquipo(new Persistencia.AppContext());
        private static IRepositorioEstadio _repoEstadio = new RepositorioEstadio(new Persistencia.AppContext());
        private static IRepositorioJugador _repoJugador = new RepositorioJugador(new Persistencia.AppContext());
        private static IRepositorioDirectorTecnico _repoTecnico = new RepositorioDirectorTecnico(new Persistencia.AppContext());
        private static IRepositorioArbitro _repoArbitro = new RepositorioArbitro(new Persistencia.AppContext());
        private static IRepositorioPartido _repoPartido = new RepositorioPartido(new Persistencia.AppContext());
        private static IRepositorioNovedadesPartido _repoNovPartido = new RepositorioNovedadesPartido(new Persistencia.AppContext());
        private static IRepositorioEstadisticasTorneo _repoEstTorneo = new RepositorioEstadisticasTorneo(new Persistencia.AppContext());
        static void Main(string[] args)
        {
              Console.WriteLine("Hello World!");
            //------------------------  CRUD MUNICIPIO----------------
            // AddMunicipio("Bello");
            // GetMunicipio(4);
            // GetAllMunicipios();
            // DeleteMunicipio(7);
            // UpdateMunicipio(5,"Bello");
            //--------------------------------------------------------

            //------------------------  CRUD EQUIPO-------------------
            // AddEquipo("Barcelona");
            // AsignarMunicipioAequipo(1,1);
            // UpdateEquipo(10,"Atletico Madrid",1);
            // GetEquipo(10);
            // DeleteEquipo(10);
            //--------------------------------------------------------

            //------------------------  CRUD ESTADIO -----------------
            // AddEstadio("Pascual Guerreo","cra 39 # 5 -38");
            // GetEstadio(2);
            // DeleteEstadio(5);
            // AsignarMunicipioAestadio(1,1);
            // UpdateEstadio(4,"Old Trafford","Calle 45c # 27-42",5);
            //--------------------------------------------------------

            //------------------------  CRUD JUGADOR -----------------
            //AddJugador("Cristhian Gonzalez","9","Delantero");
            //GetJugador(2);
            // AsignarEquipoAjugador(1,1);
            // AsignarEquipoAjugador(2,1);
            // UpdateJugador(3,"Juan Ruiz","23","defensa",1);
            // DeleteJugador(3);

            //------------------------  CRUD DIRECTOR TECNICO -----------------
            // AddDirectorTecnico("Javier Hernandez","167854412","3125547785");
            // AsignarEquipoAtecnico(2,4);
            // UpdateDirectorTecnico(4,"Alfredo Arias","23452345","1235465",5);
            // GetDirectorTecnico(1);
            // DeleteDirectorTecnico(5);

            //------------------------  CRUD ARBITRO -------------------------
            //AddArbitro("Federico Rivera","167882145","3124557899","Universidad FIFA de Colombia");
            // UpdateArbitro(4,"Alexander Alzate Zapata","32462534","234653547","FIFA");
            // GetArbitro(1);
            // DeleteArbitro(5);

            //------------------------ CRUD PARTIDO --------------------------
            // DateTime fecha_partido = DateTime.Now.Date;
            // DateTime hora_partido = DateTime.Now;
            // System.Console.WriteLine(fecha_partido +"--"+hora_partido);
            // AddPartido(DateTime.Now,DateTime.Now,0,0);
            // AsignarEquipoLocalApartido(3,1);
            // AsignarEquipoVisitanteApartido(3,3);
            // AsignarEstadioApartido(3,1);
            // AsignarArbitroApartido(3,1);
            // GetPartido(3);
            // DeletePartido(2);
            // UpdatePartido(3,fecha_partido,hora_partido,0,0);

            //------------------------ CRUD NOVEDADES PARTIDO--------------------------
            // AddNovedadesPartido("59'","Amarilla",1);
            // AsignarJugadorAnovedad(1,1);
            // AsignarEquipoAnovedad(1,1);
            // AsignarPartidoAnovedad(1,3);

            //------------------------ CRUD ESTADISTICAS TORNEO--------------------------
            // AddEstadisticasTorneo();
            //AsignarEquipoAestTorneo(1,1);
            
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
            System.Console.WriteLine("Nombre del jugador encontrado: "+jugadorEncontrado.Nombre+" Posicion: "+jugadorEncontrado.Posicion+" Numero Camiseta: "+ jugadorEncontrado.NumeroCamiseta);
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

        //****************************************************************
        //------------------------CRUD DIRECTOR TECNICO-------------------
        private static void AddDirectorTecnico(string nombre, string telefono, string documento)
        {
            var tecnico = new DirectorTecnico{
                Nombre = nombre,
                Telefono = telefono,
                Documento = documento
            };
            _repoTecnico.AddDirectorTecnico(tecnico);
        }

        private static void GetDirectorTecnico(int idDirectorTecnico)
        {
            var tecnicoEncontrado = _repoTecnico.GetDirectorTecnico(idDirectorTecnico);
            System.Console.WriteLine("Nombre del tecnico encontrado: "+tecnicoEncontrado.Nombre);
        }
        private static void DeleteDirectorTecnico(int idDirectorTecnico)
        {
            _repoTecnico.DeleteDirectorTecnico(idDirectorTecnico);
        }

        private static void UpdateDirectorTecnico(int idDirectorTecnico, string nombreNuevo, string telefonoNuevo, string documentoNuevo, int idEquipoNuevo)
        {
            var tecnicoEncontrado = _repoTecnico.GetDirectorTecnico(idDirectorTecnico);
            if(tecnicoEncontrado != null)
            {
                var equipoEncontrado = _repoEquipo.GetEquipo(idEquipoNuevo);
                if(equipoEncontrado != null)
                {
                    tecnicoEncontrado.Nombre = nombreNuevo;
                    tecnicoEncontrado.Telefono = telefonoNuevo;
                    tecnicoEncontrado.Documento = documentoNuevo;
                    tecnicoEncontrado.Equipo = equipoEncontrado;
                    _repoTecnico.UpdateDirectorTecnico(tecnicoEncontrado);
                }
            }
        }
        private static void AsignarEquipoAtecnico(int idDirectorTecnico,int idEquipo)
        {
            _repoTecnico.AsignarEquipo(idDirectorTecnico,idEquipo);
        }

        //****************************************************************
        //----------------------- CRUD ARBITRO ---------------------------
        private static void AddArbitro(string nombre, string telefono, string documento, string colegioArbitro)
        {
            var arbitro = new Arbitro{
                Nombre = nombre,
                Telefono = telefono,
                Documento = documento,
                ColegioArbitro = colegioArbitro
            };
            _repoArbitro.AddArbitro(arbitro);
        }
        private static void GetArbitro(int idArbitro)
        {
            var arbitroEncontrado = _repoArbitro.GetArbitro(idArbitro);
            System.Console.WriteLine("Nombre del arbitro encontrado: "+arbitroEncontrado.Nombre);
        }
        private static void DeleteArbitro(int idArbitro)
        {
            _repoArbitro.DeleteArbitro(idArbitro);
        }
        private static void UpdateArbitro(int idArbitro, string nombreNuevo, string telefonoNuevo, string documentoNuevo, string colegioArbitroNuevo)
        {
            var arbitroEncontrado = _repoArbitro.GetArbitro(idArbitro);
            if(arbitroEncontrado != null)
            {
                arbitroEncontrado.Nombre = nombreNuevo;
                arbitroEncontrado.Telefono = telefonoNuevo;
                arbitroEncontrado.Documento = documentoNuevo;
                arbitroEncontrado.ColegioArbitro = colegioArbitroNuevo;
                _repoArbitro.UpdateArbitro(arbitroEncontrado);
            }
        }

        //****************************************************************
        //----------------------- CRUD PARTIDO ---------------------------
        private static void AddPartido(DateTime fechaPartido, DateTime horaPartido, int marcadorLocal, int marcadorVisitante)
        {
            var partido = new Partido{
                FechaPartido = fechaPartido,
                HoraPartido = horaPartido,
                MarcadorLocal = marcadorLocal,
                MarcadorVisitante = marcadorVisitante
            };
            _repoPartido.AddPartido(partido);
        }

        private static void GetPartido(int idPartido)
        {
            var partidoEncontrado = _repoPartido.GetPartido(idPartido);
            System.Console.WriteLine("Id del partido encontrado: "+partidoEncontrado.Id);
        }
        private static void DeletePartido(int idPartido)
        {
            _repoPartido.DeletePartido(idPartido);
        }
        private static void UpdatePartido(int idPartido, DateTime fechaPartido, DateTime horaPartido, int marcadorLocal, int marcadorVisitante)
        {
            var partidoEncontrado = _repoPartido.GetPartido(idPartido);
            if(partidoEncontrado != null)
            {
                partidoEncontrado.FechaPartido = fechaPartido;
                partidoEncontrado.HoraPartido = horaPartido;
                partidoEncontrado.MarcadorLocal = marcadorLocal;
                partidoEncontrado.MarcadorVisitante = marcadorVisitante;
                _repoPartido.UpdatePartido(partidoEncontrado);
            }
        }
        private static void AsignarEquipoLocalApartido(int idPartido,int idEquipo)
        {
            _repoPartido.AsignarEquipoLocal(idPartido,idEquipo);
        }
        private static void AsignarEquipoVisitanteApartido(int idPartido,int idEquipo)
        {
            _repoPartido.AsignarEquipoVisitante(idPartido,idEquipo);
        }
        private static void AsignarEstadioApartido(int idPartido,int idEstadio)
        {
            _repoPartido.AsignarEstadio(idPartido,idEstadio);
        }
        private static void AsignarArbitroApartido(int idPartido,int idArbitro)
        {
            _repoPartido.AsignarArbitro(idPartido,idArbitro);
        }

        //**************************************************************************
        //----------------------- CRUD NOVEDADES PARTIDO ---------------------------
        private static void AddNovedadesPartido(string minutoPartido, string tarjeta, int gol)
        {
            var novedadPartido = new NovedadesPartido{
                MinutoPartido = minutoPartido,
                Tarjeta = tarjeta,
                Gol = gol
            };
            _repoNovPartido.AddNovedadesPartido(novedadPartido);
        }
        private static void AsignarPartidoAnovedad(int idNovedadPartido, int idPartido)
        {
            _repoNovPartido.AsignarPartido(idNovedadPartido,idPartido);
        }
        private static void AsignarEquipoAnovedad(int idNovedadPartido, int idEquipo)
        {
            _repoNovPartido.AsignarEquipo(idNovedadPartido,idEquipo);
        }
        private static void AsignarJugadorAnovedad(int idNovedadPartido, int idJugador)
        {
            _repoNovPartido.AsignarJugador(idNovedadPartido,idJugador);
        }

        //****************************************************************************
        //----------------------- CRUD ESTADÍSTICAS TORNEO ---------------------------
        private static void AddEstadisticasTorneo()
        {
            var estadisticaTorneo = new EstadisticaTorneo
            {
                CantidadPartidosJugados = 1,
                CantidadPartidosGanados = 0,
                CantidadPartidosEmpatados = 1,
                GolesAfavor = 2,
                GolesEnContra = 0,
                Puntos = 1
            };
            _repoEstTorneo.AddEstadisticasTorneo(estadisticaTorneo);
        }
        private static void AsignarEquipoAestTorneo(int idEstadisticasTorneo, int idEquipo)
        {
            _repoEstTorneo.AsignarEquipo(idEstadisticasTorneo,idEquipo);
        }

    }
}
