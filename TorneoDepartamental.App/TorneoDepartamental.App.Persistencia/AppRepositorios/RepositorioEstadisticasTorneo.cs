using System.Collections.Generic;
using TorneoDepartamental.App.Dominio;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace TorneoDepartamental.App.Persistencia
{
    public class RepositorioEstadisticasTorneo : IRepositorioEstadisticasTorneo
    {
        private readonly AppContext _appContext = new AppContext();

        public RepositorioEstadisticasTorneo()
        {
        }

        public EstadisticaTorneo AddEstadisticasTorneo(EstadisticaTorneo estadisticasTorneo)
        {
            var novPartidoAdicionado = _appContext.EstadisticasTorneo.Add(estadisticasTorneo);
            _appContext.SaveChanges();
            return novPartidoAdicionado.Entity;
        }
        public EstadisticaTorneo UpdateEstadisticasTorneo(EstadisticaTorneo estadisticasTorneo)
        {
            var estadisticaTorneoEncontrado = _appContext.EstadisticasTorneo.FirstOrDefault(est => est.Id == estadisticasTorneo.Id);
            if(estadisticaTorneoEncontrado != null){
                estadisticaTorneoEncontrado.CantidadPartidosJugados = estadisticasTorneo.CantidadPartidosJugados;
                estadisticaTorneoEncontrado.CantidadPartidosGanados = estadisticasTorneo.CantidadPartidosGanados;
                estadisticaTorneoEncontrado.CantidadPartidosEmpatados = estadisticasTorneo.CantidadPartidosEmpatados;
                estadisticaTorneoEncontrado.GolesAfavor = estadisticasTorneo.GolesAfavor;
                estadisticaTorneoEncontrado.GolesEnContra = estadisticasTorneo.GolesEnContra;
                estadisticaTorneoEncontrado.Puntos = estadisticasTorneo.Puntos;
                _appContext.SaveChanges();
            }
            return estadisticaTorneoEncontrado;
        }
        public void DeleteEstadisticasTorneo(int idEstadisticasTorneo)
        {
            var estadisticaTorneoEncontrado = _appContext.EstadisticasTorneo.FirstOrDefault(est => est.Id == idEstadisticasTorneo);
            if(estadisticaTorneoEncontrado == null)
                return;
            _appContext.EstadisticasTorneo.Remove(estadisticaTorneoEncontrado);
            _appContext.SaveChanges();
        }
        public EstadisticaTorneo GetEstadisticasTorneo(int idEstadisticasTorneo)
        {
            var estadisticaTorneoEncontrado = _appContext.EstadisticasTorneo
            .Where(e => e.Id == idEstadisticasTorneo)
            .Include(e => e.Equipo)
            .FirstOrDefault();
            return estadisticaTorneoEncontrado;
            // return _appContext.EstadisticasTorneo.FirstOrDefault(est => est.Id == idEstadisticasTorneo);
        }
        public IEnumerable<EstadisticaTorneo> GetAllEstadisticasTorneos()
        {
            return _appContext.EstadisticasTorneo;
        }
        public Equipo AsignarEquipo(int idEstadisticasTorneo,int idEquipo)
        {
            var estadisticaTorneoEncontrado = _appContext.EstadisticasTorneo.FirstOrDefault(est => est.Id == idEstadisticasTorneo);
            if(estadisticaTorneoEncontrado != null)
            {
                var equipoEncontrado = _appContext.Equipos.FirstOrDefault(e => e.Id == idEquipo);
                if(equipoEncontrado != null)
                {
                    estadisticaTorneoEncontrado.Equipo = equipoEncontrado;
                    _appContext.SaveChanges();
                }
                return equipoEncontrado;
            }
            return null;
        }
    }
}