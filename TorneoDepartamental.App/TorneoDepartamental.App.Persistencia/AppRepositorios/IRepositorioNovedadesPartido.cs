using System.Collections.Generic;
using TorneoDepartamental.App.Dominio;
using System;

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
         IEnumerable<NovedadesPartido> SearchNovedadPartido(DateTime dia);
        IEnumerable<NovedadesPartido> FilterNovedadPartido(DateTime dia);
    }
}