using System.Collections.Generic;
using TorneoDepartamental.App.Dominio;

namespace TorneoDepartamental.App.Persistencia
{
    public interface IRepositorioPartido
    {
        Partido AddPartido(Partido partido);
        Partido UpdatePartido(Partido partido);
        void DeletePartido(int idPartido);
        Partido GetPartido(int idPartido);
        IEnumerable<Partido> GetAllPartidos();
        Estadio AsignarEstadio(int idPartido,int idEstadio);
        Equipo AsignarEquipoLocal(int idPartido,int idEquipo);
        Equipo AsignarEquipoVisitante(int idPartido,int idEquipo);
        Arbitro AsignarArbitro(int idPartido,int idArbitro);

    }
}