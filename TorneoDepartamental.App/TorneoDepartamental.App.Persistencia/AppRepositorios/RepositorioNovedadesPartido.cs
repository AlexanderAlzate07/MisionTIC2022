using System.Collections.Generic;
using TorneoDepartamental.App.Dominio;
using System.Linq;

namespace TorneoDepartamental.App.Persistencia
{
    public class RepositorioNovedadesPartido : IRepositorioNovedadesPartido 
    {
        private readonly AppContext _appContext = new AppContext();
        public RepositorioNovedadesPartido(AppContext appContext)
        {
        }

        public NovedadesPartido AddNovedadesPartido(NovedadesPartido novedadPartido)
        {
            var novPartidoAdicionado = _appContext.NovedadesPartidos.Add(novedadPartido);
            _appContext.SaveChanges();
            return novPartidoAdicionado.Entity;
        }
        public NovedadesPartido UpdateNovedadesPartido(NovedadesPartido novedadPartido)
        {
            var novPartidoEncontrado = _appContext.NovedadesPartidos.FirstOrDefault(p => p.Id == novedadPartido.Id);
            if(novPartidoEncontrado != null){
                novPartidoEncontrado.MinutoPartido = novedadPartido.MinutoPartido;
                novPartidoEncontrado.Tarjeta = novedadPartido.Tarjeta;
                novPartidoEncontrado.Gol = novedadPartido.Gol;
                _appContext.SaveChanges();
            }
            return novPartidoEncontrado;
        }
        public void DeleteNovedadesPartido(int idNovedadesPartido)
        {
            var novPartidoEncontrado = _appContext.NovedadesPartidos.FirstOrDefault(np => np.Id == idNovedadesPartido);
            if(novPartidoEncontrado == null)
                return;
            _appContext.NovedadesPartidos.Remove(novPartidoEncontrado);
            _appContext.SaveChanges();
        }
        public NovedadesPartido GetNovedadesPartido(int idNovedadesPartido)
        {
            return  _appContext.NovedadesPartidos.FirstOrDefault(np => np.Id == idNovedadesPartido);
        }
        public IEnumerable<NovedadesPartido> GetAllNovedadesPartidos()
        {
            return _appContext.NovedadesPartidos;
        }
        public Partido AsignarPartido(int idNovedadesPartido,int idPartido)
        {
            var novPartidoEncontrado = _appContext.NovedadesPartidos.FirstOrDefault(np => np.Id == idNovedadesPartido);
            if(novPartidoEncontrado != null)
            {
                var partidoEncontrado = _appContext.Partidos.FirstOrDefault(e => e.Id == idPartido);
                if(partidoEncontrado != null)
                {
                    novPartidoEncontrado.Partido = partidoEncontrado;
                    _appContext.SaveChanges();
                }
                return partidoEncontrado;
            }
            return null;
        }
        public Equipo AsignarEquipo(int idNovedadesPartido,int idEquipo)
        {
            var novPartidoEncontrado = _appContext.NovedadesPartidos.FirstOrDefault(np => np.Id == idNovedadesPartido);
            if(novPartidoEncontrado != null)
            {
                var equipoEncontrado = _appContext.Equipos.FirstOrDefault(e => e.Id == idEquipo);
                if(equipoEncontrado != null)
                {
                    novPartidoEncontrado.Equipo = equipoEncontrado;
                    _appContext.SaveChanges();
                }
                return equipoEncontrado;
            }
            return null;
        }
        public Jugador AsignarJugador(int idNovedadesPartido,int idJugador)
        {
            var novPartidoEncontrado = _appContext.NovedadesPartidos.FirstOrDefault(np => np.Id == idNovedadesPartido);
            if(novPartidoEncontrado != null)
            {
                var jugadorEncontrado = _appContext.Jugadores.FirstOrDefault(e => e.Id == idJugador);
                if(jugadorEncontrado != null)
                {
                    novPartidoEncontrado.Jugador = jugadorEncontrado;
                    _appContext.SaveChanges();
                }
                return jugadorEncontrado;
            }
            return null;
        }
    }
}