using System.Collections.Generic;
using TorneoDepartamental.App.Dominio;

namespace TorneoDepartamental.App.Persistencia
{
    public interface IRepositorioMunicipio
    {
        Municipio AddMunicipio(Municipio municipio);
        Municipio UpdateMunicipio(Municipio municipio);
        void DeleteMunicipio(int idMunicipio);
        Municipio GetMunicipio(int idMunicipio);
        IEnumerable<Municipio> GetAllMunicipios();
    }
}