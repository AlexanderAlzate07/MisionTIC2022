using System.Collections.Generic;
using TorneoDepartamental.App.Dominio;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace TorneoDepartamental.App.Persistencia
{
    public class RepositorioPartido : IRepositorioPartido
    {
        private readonly AppContext _appContext = new AppContext();

        public RepositorioPartido()
        {
        }

        public Partido AddPartido(Partido partido)
        {
            var partidoAdicionado = _appContext.Partidos.Add(partido);
            _appContext.SaveChanges();
            return partidoAdicionado.Entity;
        
        }
        public Partido UpdatePartido(Partido partido)
        {
            var partidoEncontrado = _appContext.Partidos.FirstOrDefault(p => p.Id == partido.Id);
            if(partidoEncontrado != null){
                partidoEncontrado.Estadio = partido.Estadio;
                partidoEncontrado.FechaPartido = partido.FechaPartido;
                partidoEncontrado.HoraPartido = partido.HoraPartido;
                partidoEncontrado.EquipoLocal = partido.EquipoLocal;
                partidoEncontrado.MarcadorLocal = partido.MarcadorLocal;
                partidoEncontrado.EquipoVisitante = partido.EquipoVisitante;
                partidoEncontrado.MarcadorVisitante = partido.MarcadorVisitante;
                partidoEncontrado.Arbitro = partido.Arbitro;
                _appContext.SaveChanges();
            }
            return partidoEncontrado;
        }
        public void DeletePartido(int idPartido)
        {
            var partidoEncontrado = _appContext.Partidos.FirstOrDefault(p => p.Id == idPartido);
            if(partidoEncontrado == null)
                return;
            _appContext.Partidos.Remove(partidoEncontrado);
            _appContext.SaveChanges();
        }
        public Partido GetPartido(int idPartido)
        {
            var partido = _appContext.Partidos
            .Where(e => e.Id == idPartido)
            .Include(e => e.Estadio)
            .Include(e => e.EquipoLocal)
            .Include(e => e.EquipoVisitante)
            .Include(e => e.Arbitro)
            .FirstOrDefault();
            return partido;
            // return _appContext.Partidos.FirstOrDefault(p => p.Id == idPartido);
        }
        public IEnumerable<Partido> GetAllPartidos()
        {
            return _appContext.Partidos
            .Include(e => e.Estadio)
            .Include(e => e.EquipoLocal)
            .Include(e => e.EquipoVisitante)
            .Include(e => e.Arbitro).ToList();
        }
        public Estadio AsignarEstadio(int idPartido,int idEstadio)
        {
            var partidoEncontrado = _appContext.Partidos.FirstOrDefault(p => p.Id == idPartido);
            if(partidoEncontrado != null)
            {
                var estadioEncontrado = _appContext.Estadios.FirstOrDefault(e => e.Id == idEstadio);
                if(estadioEncontrado != null)
                {
                    partidoEncontrado.Estadio = estadioEncontrado;
                    _appContext.SaveChanges();
                }
                return estadioEncontrado;
            }
            return null;
        }
        public Equipo AsignarEquipoLocal(int idPartido,int idEquipo)
        {
            var partidoEncontrado = _appContext.Partidos.FirstOrDefault(p => p.Id == idPartido);
            if(partidoEncontrado != null)
            {
                var equipoEncontrado = _appContext.Equipos.FirstOrDefault(e => e.Id == idEquipo);
                if(equipoEncontrado != null)
                {
                    partidoEncontrado.EquipoLocal = equipoEncontrado;
                    _appContext.SaveChanges();
                }
                return equipoEncontrado;
            }
            return null;
        }
        public Equipo AsignarEquipoVisitante(int idPartido,int idEquipo)
        {
            var partidoEncontrado = _appContext.Partidos.FirstOrDefault(p => p.Id == idPartido);
            if(partidoEncontrado != null)
            {
                var equipoEncontrado = _appContext.Equipos.FirstOrDefault(e => e.Id == idEquipo);
                if(equipoEncontrado != null)
                {
                    partidoEncontrado.EquipoVisitante = equipoEncontrado;
                    _appContext.SaveChanges();
                }
                return equipoEncontrado;
            }
            return null;
        }
        public Arbitro AsignarArbitro(int idPartido,int idArbitro)
        {
            var partidoEncontrado = _appContext.Partidos.FirstOrDefault(p => p.Id == idPartido);
            if(partidoEncontrado != null)
            {
                var arbitroEncontrado = _appContext.Arbitros.FirstOrDefault(e => e.Id == idArbitro);
                if(arbitroEncontrado != null)
                {
                    partidoEncontrado.Arbitro = arbitroEncontrado;
                    _appContext.SaveChanges();
                }
                return arbitroEncontrado;
            }
            return null;
        }
    }
}