using System.Collections.Generic;
using TorneoDepartamental.App.Dominio;

namespace TorneoDepartamental.App.Persistencia
{
    public interface IRepositorioDirectorTecnico
    {
        DirectorTecnico AddDirectorTecnico(DirectorTecnico tecnico);
        DirectorTecnico UpdateDirectorTecnico(DirectorTecnico tecnico);
        void DeleteDirectorTecnico(int idDirectorTecnico);
        DirectorTecnico GetDirectorTecnico(int idDirectorTecnico);
        IEnumerable<DirectorTecnico> GetAllDirectorTecnicos();
        Equipo AsignarEquipo(int idDirectorTecnico,int idEquipo);
        IEnumerable<DirectorTecnico> SearchDirector(string nombre);
    }
}