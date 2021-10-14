using System.Collections.Generic;
using TorneoDepartamental.App.Dominio;

namespace TorneoDepartamental.App.Persistencia
{
    public interface IRepositorioEstadisticasTorneo
    {
        EstadisticaTorneo AddEstadisticasTorneo(EstadisticaTorneo estadisticasTorneo);
        EstadisticaTorneo UpdateEstadisticasTorneo(EstadisticaTorneo estadisticasTorneo);
        void DeleteEstadisticasTorneo(int idEstadisticasTorneo);
        EstadisticaTorneo GetEstadisticasTorneo(int idEstadisticasTorneo);
        IEnumerable<EstadisticaTorneo> GetAllEstadisticasTorneos();
        Equipo AsignarEquipo(int idEstadisticasTorneo,int idEquipo);
        IEnumerable<EstadisticaTorneo> SearchEstadisticasTorneo(string nombre);
    }
}