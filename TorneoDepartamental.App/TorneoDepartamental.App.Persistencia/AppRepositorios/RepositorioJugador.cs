using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TorneoDepartamental.App.Dominio;

namespace TorneoDepartamental.App.Persistencia
{
    public class RepositorioJugador : IRepositorioJugador
    {
        private readonly AppContext _appContext = new AppContext();


        public Jugador AddJugador(Jugador jugador)
        {
            var jugadorAdicionado = _appContext.Jugadores.Add(jugador);
            _appContext.SaveChanges();
            return jugadorAdicionado.Entity;
        }
        public Jugador UpdateJugador(Jugador jugador)
        {
            var jugadorEncontrado = _appContext.Jugadores.FirstOrDefault(j => j.Id == jugador.Id);
            if (jugadorEncontrado != null)
            {
                jugadorEncontrado.Nombre = jugador.Nombre;
                jugadorEncontrado.NumeroCamiseta = jugador.NumeroCamiseta;
                jugadorEncontrado.Posicion = jugador.Posicion;
                jugadorEncontrado.Equipo = jugador.Equipo;
                _appContext.SaveChanges();
            }
            return jugadorEncontrado;
        }
        public void DeleteJugador(int idJugador)
        {
            var jugadorEncontrado = _appContext.Jugadores.FirstOrDefault(j => j.Id == idJugador);
            if (jugadorEncontrado == null)
                return;
            _appContext.Jugadores.Remove(jugadorEncontrado);
            _appContext.SaveChanges();
        }
        public Jugador GetJugador(int idJugador)
        {
            var jugador = _appContext.Jugadores
                    .Where(j => j.Id == idJugador)
                    .Include(j => j.Equipo)
                    .FirstOrDefault();
            return jugador;
        }
        public IEnumerable<Jugador> GetAllJugadores()
        {
            return _appContext.Jugadores;
        }
        public Equipo AsignarEquipo(int idJugador, int idEquipo)
        {
            var jugadorEncontrado = _appContext.Jugadores.FirstOrDefault(j => j.Id == idJugador);
            if (jugadorEncontrado != null)
            {
                var equipoEncontrado = _appContext.Equipos.FirstOrDefault(e => e.Id == idEquipo);
                if (equipoEncontrado != null)
                {
                    jugadorEncontrado.Equipo = equipoEncontrado;
                    _appContext.SaveChanges();
                }
                return equipoEncontrado;
            }
            return null;
        }
        public IEnumerable<Jugador> SearchJugador(string nombre)
        {
            return _appContext.Jugadores
                     .Where(e => e.Nombre.Contains(nombre));
        }
        public IEnumerable<Jugador> FilterJugador(string nombre)
        {
            return _appContext.Jugadores
                     .Where(e => e.Nombre.Equals(nombre)).ToList();
        }
    }

}