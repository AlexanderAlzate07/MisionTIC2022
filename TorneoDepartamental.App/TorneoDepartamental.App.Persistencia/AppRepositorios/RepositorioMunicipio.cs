using System.Collections.Generic;
using TorneoDepartamental.App.Dominio;
using System.Linq;

namespace TorneoDepartamental.App.Persistencia
{
    public class RepositorioMunicipio : IRepositorioMunicipio
    {
        private readonly AppContext _appContext = new AppContext();

        public RepositorioMunicipio(AppContext appContext){

        }
        public Municipio AddMunicipio(Municipio municipio){
            var municipioAdicionado = _appContext.Municipios.Add(municipio);
            _appContext.SaveChanges();
            return municipioAdicionado.Entity;
        }
        public Municipio UpdateMunicipio(Municipio municipio){
            var municipioEncontrado = _appContext.Municipios.FirstOrDefault(m => m.Id == municipio.Id);
            if(municipio != null){
                municipioEncontrado.Nombre = municipio.Nombre;
                _appContext.SaveChanges();
            }
            return municipioEncontrado;
        }
        public void DeleteMunicipio(int idMunicipio){
            var municipioEncontrado = _appContext.Municipios.FirstOrDefault(m => m.Id == idMunicipio);
            if(municipioEncontrado == null)
                return;
            _appContext.Municipios.Remove(municipioEncontrado);
            _appContext.SaveChanges();
        }
        public Municipio GetMunicipio(int idMunicipio){
            return _appContext.Municipios.FirstOrDefault(m => m.Id == idMunicipio);
        }
        public IEnumerable<Municipio> GetAllMunicipios(){
            return _appContext.Municipios;
        }
    }
}