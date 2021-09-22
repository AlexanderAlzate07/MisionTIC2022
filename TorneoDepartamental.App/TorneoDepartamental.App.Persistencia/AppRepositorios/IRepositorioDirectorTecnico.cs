using System.Collections.Generic;
using TorneoDepartamental.App.Dominio;

namespace TorneoDepartamental.App.Persistencia
{
    public interface IRepositorioDirectorTecnico
    {
        DirectorTecnico AddDirectorTecnico(DirectorTecnico equipo);
        DirectorTecnico UpdateDirectorTecnico(DirectorTecnico equipo);
        void DeleteDirectorTecnico(int idDirectorTecnico);
        DirectorTecnico GetDirectorTecnico(int idDirectorTecnico);
        IEnumerable<DirectorTecnico> GetAllDirectorTecnicos();
        Equipo AsignarEquipo(int idDirectorTecnico,int idEquipo);
    }
}