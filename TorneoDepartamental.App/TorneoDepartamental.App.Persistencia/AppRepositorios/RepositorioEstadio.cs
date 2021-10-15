using System.Collections.Generic;
using TorneoDepartamental.App.Dominio;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace TorneoDepartamental.App.Persistencia
{
    public class RepositorioEstadio : IRepositorioEstadio
    {
        private readonly AppContext _appContext = new AppContext();

    

        public Estadio AddEstadio(Estadio estadio)
        {
            var estadioAdicionado = _appContext.Estadios.Add(estadio);
            _appContext.SaveChanges();
            return estadioAdicionado.Entity;
        }
        public Estadio UpdateEstadio(Estadio estadio)
        {
            var estadioEncontrado = _appContext.Estadios.FirstOrDefault(e => e.Id == estadio.Id);
            if(estadioEncontrado != null){
                estadioEncontrado.Nombre = estadio.Nombre;
                estadioEncontrado.Direccion = estadio.Direccion;
                estadioEncontrado.Municipio = estadio.Municipio;
                _appContext.SaveChanges();
            }
            return estadioEncontrado;
        }
        public void DeleteEstadio(int idEstadio)
        {
            var estadioEncontrado = _appContext.Estadios.FirstOrDefault(e => e.Id == idEstadio);
            if(estadioEncontrado == null)
                return;
            _appContext.Estadios.Remove(estadioEncontrado);
            _appContext.SaveChanges();
        }
        public Estadio GetEstadio(int idEstadio)
        {
            var estadio = _appContext.Estadios
                    .Where(t => t.Id == idEstadio)
                    .Include(t => t.Municipio)
                    .FirstOrDefault();
            return estadio;
        }
        public IEnumerable<Estadio> GetAllEstadios()
        {
            return _appContext.Estadios;
        }
        public Municipio AsignarMunicipio(int idEstadio,int idMunicipio)
        {
            var estadioEncontrado = _appContext.Estadios.FirstOrDefault(e => e.Id == idEstadio);
            if(estadioEncontrado != null)
            {
                var municipioEncontrado = _appContext.Municipios.FirstOrDefault(m => m.Id == idMunicipio);
                if(municipioEncontrado != null)
                {
                    estadioEncontrado.Municipio = municipioEncontrado;
                    _appContext.SaveChanges();
                }
                return municipioEncontrado;
            }
            return null;
        }

        IEnumerable<Estadio>IRepositorioEstadio.SearchEstadio(string nombre)
        {
            return _appContext.Estadios.Where(e => e.Nombre.Contains(nombre));
        }
    }
}