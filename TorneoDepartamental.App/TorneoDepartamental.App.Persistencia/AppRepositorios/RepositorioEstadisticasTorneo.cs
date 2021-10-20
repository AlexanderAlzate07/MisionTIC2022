using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TorneoDepartamental.App.Dominio;

namespace TorneoDepartamental.App.Persistencia
{
    public class RepositorioEstadisticasTorneo : IRepositorioEstadisticasTorneo
    {
        private readonly AppContext _appContext = new AppContext();


        public EstadisticaTorneo AddEstadisticasTorneo(EstadisticaTorneo estadisticasTorneo)
        {
            var novPartidoAdicionado = _appContext.EstadisticasTorneo.Add(estadisticasTorneo);
            _appContext.SaveChanges();
            return novPartidoAdicionado.Entity;
        }
        public EstadisticaTorneo UpdateEstadisticasTorneo(EstadisticaTorneo estadisticasTorneo)
        {
            var estadisticaTorneoEncontrado = _appContext.EstadisticasTorneo.FirstOrDefault(est => est.Id == estadisticasTorneo.Id);
            if (estadisticaTorneoEncontrado != null)
            {
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
            if (estadisticaTorneoEncontrado == null)
                return;
            _appContext.EstadisticasTorneo.Remove(estadisticaTorneoEncontrado);
            _appContext.SaveChanges();
        }
        public EstadisticaTorneo GetEstadisticasTorneo(int idEstadisticasTorneo)
        {
            var estadisticaTorneo = _appContext.EstadisticasTorneo
           .Where(e => e.Id == idEstadisticasTorneo)
           .Include(e => e.Equipo)
           .FirstOrDefault();
            return estadisticaTorneo;
        }
        public IEnumerable<EstadisticaTorneo> GetAllEstadisticasTorneos()
        {
            return _appContext.EstadisticasTorneo.Include(et => et.Equipo).ToList();
        }
        public Equipo AsignarEquipo(int idEstadisticasTorneo, int idEquipo)
        {
            var estadisticaTorneoEncontrado = _appContext.EstadisticasTorneo.FirstOrDefault(est => est.Id == idEstadisticasTorneo);
            if (estadisticaTorneoEncontrado != null)
            {
                var equipoEncontrado = _appContext.Equipos.FirstOrDefault(e => e.Id == idEquipo);
                if (equipoEncontrado != null)
                {
                    estadisticaTorneoEncontrado.Equipo = equipoEncontrado;
                    _appContext.SaveChanges();
                }
                return equipoEncontrado;
            }
            return null;
        }

        public IEnumerable<EstadisticaTorneo> SearchEstadisticasTorneo(string nombre)
        {
            return _appContext.EstadisticasTorneo.Include(e => e.Equipo)
                     .Where(e => e.Equipo.Nombre.Contains(nombre));
        }
        public IEnumerable<EstadisticaTorneo> FilterEstadisticasTorneo(string nombre)
        {
            return _appContext.EstadisticasTorneo.Include(e => e.Equipo)
                     .Where(e => e.Equipo.Nombre.Equals(nombre)).ToList();
        }

    }
}