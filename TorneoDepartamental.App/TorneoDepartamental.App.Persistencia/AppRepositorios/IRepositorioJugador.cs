using System.Collections.Generic;
using TorneoDepartamental.App.Dominio;

namespace TorneoDepartamental.App.Persistencia
{
    public interface IRepositorioJugador
    {
        Jugador AddJugador(Jugador jugador);
        Jugador UpdateJugador(Jugador jugador);
        void DeleteJugador(int idJugador);
        Jugador GetJugador(int idJugador);
        IEnumerable<Jugador> GetAllJugadores();
        Equipo AsignarEquipo(int idJugador,int idEquipo);
        IEnumerable<Jugador> SearchJugador(string nombre);
    }
}