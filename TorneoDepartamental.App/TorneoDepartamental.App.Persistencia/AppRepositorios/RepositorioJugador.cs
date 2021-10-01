using System.Collections.Generic;
using TorneoDepartamental.App.Dominio;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace TorneoDepartamental.App.Persistencia
{
    public class RepositorioJugador : IRepositorioJugador
    {
        private readonly AppContext _appContext = new AppContext();

        public RepositorioJugador()
        {
        }

        public Jugador AddJugador(Jugador jugador)
        {
            var jugadorAdicionado = _appContext.Jugadores.Add(jugador);
            _appContext.SaveChanges();
            return jugadorAdicionado.Entity;
        }
        public Jugador UpdateJugador(Jugador jugador)
        {
            var jugadorEncontrado = _appContext.Jugadores.FirstOrDefault(j => j.Id == jugador.Id);
            if(jugadorEncontrado != null){
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
            if(jugadorEncontrado == null)
                return;
            _appContext.Jugadores.Remove(jugadorEncontrado);
            _appContext.SaveChanges();
        }
        public Jugador GetJugador(int idJugador)
        {
            var jugador = _appContext.Jugadores
            .Where(e => e.Id == idJugador)
            .Include(e => e.Equipo)
            .FirstOrDefault();
            return jugador;
            // return _appContext.Jugadores.FirstOrDefault(j => j.Id == idJugador);
        }
        public IEnumerable<Jugador> GetAllJugadores()
        {
            return _appContext.Jugadores;
        }
        public Equipo AsignarEquipo(int idJugador,int idEquipo)
        {
            var jugadorEncontrado = _appContext.Jugadores.FirstOrDefault(j => j.Id == idJugador);
            if(jugadorEncontrado != null)
            {
                var equipoEncontrado = _appContext.Equipos.FirstOrDefault(e => e.Id == idEquipo);
                if(equipoEncontrado != null)
                {
                    jugadorEncontrado.Equipo = equipoEncontrado;
                    _appContext.SaveChanges();
                }
                return equipoEncontrado;
            }
            return null;
        }
    }

}