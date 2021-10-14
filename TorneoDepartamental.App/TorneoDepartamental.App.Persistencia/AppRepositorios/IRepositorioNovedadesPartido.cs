using System;
using System.Collections.Generic;
using TorneoDepartamental.App.Dominio;

namespace TorneoDepartamental.App.Persistencia
{
    public interface IRepositorioNovedadesPartido
    {
        NovedadesPartido AddNovedadesPartido(NovedadesPartido novedadPartido);
        NovedadesPartido UpdateNovedadesPartido(NovedadesPartido novedadPartido);
        void DeleteNovedadesPartido(int idNovedadesPartido);
        NovedadesPartido GetNovedadesPartido(int idNovedadesPartido);
        IEnumerable<NovedadesPartido> GetAllNovedadesPartidos();
        Partido AsignarPartido(int idNovedadesPartido,int idPartido);
        Equipo AsignarEquipo(int idNovedadesPartido,int idEquipo);
        Jugador AsignarJugador(int idNovedadesPartido,int idJugador);
        public IEnumerable<NovedadesPartido> SearchNovedadPartido(DateTime dia);
    }
}