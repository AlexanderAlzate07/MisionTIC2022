using System.Collections.Generic;
using TorneoDepartamental.App.Dominio;

namespace TorneoDepartamental.App.Persistencia
{
    public interface IRepositorioEstadio
    {
        Estadio AddEstadio(Estadio estadio);
        Estadio UpdateEstadio(Estadio estadio);
        void DeleteEstadio(int idEstadio);
        Estadio GetEstadio(int idEstadio);
        IEnumerable<Estadio> GetAllEstadios();
        Municipio AsignarMunicipio(int idEstadio,int idMunicipio);
        IEnumerable<Estadio> SearchEstadio(string nombre);
        IEnumerable<Estadio> FilterEstadio(string nombre);
    }
}