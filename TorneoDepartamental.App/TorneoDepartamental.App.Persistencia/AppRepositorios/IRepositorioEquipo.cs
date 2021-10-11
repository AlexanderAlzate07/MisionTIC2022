using System.Collections.Generic;
using TorneoDepartamental.App.Dominio;

namespace TorneoDepartamental.App.Persistencia
{
    public interface IRepositorioEquipo
    {
        Equipo AddEquipo(Equipo equipo);
        Equipo UpdateEquipo(Equipo equipo);
        void DeleteEquipo(int idEquipo);
        Equipo GetEquipo(int idEquipo);
        IEnumerable<Equipo> GetAllEquipos();
        Municipio AsignarMunicipio(int idEquipo,int idMunicipio);
        Municipio AsignarMunicipio2(int idEquipo,int idMunicipio);
    }
}