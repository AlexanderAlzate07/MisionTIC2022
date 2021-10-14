using System.Collections.Generic;
using TorneoDepartamental.App.Dominio;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace TorneoDepartamental.App.Persistencia
{
    public class RepositorioEquipo : IRepositorioEquipo
    {
        private readonly AppContext _appContext = new AppContext();
        public RepositorioEquipo()
        {
        }

        public Equipo AddEquipo(Equipo equipo)
        {
            var equipoAdicionado = _appContext.Equipos.Add(equipo);
            _appContext.SaveChanges();
            return equipoAdicionado.Entity;
        }
        public Equipo UpdateEquipo(Equipo equipo)
        {
            var equipoEncontrado = _appContext.Equipos.FirstOrDefault(e => e.Id == equipo.Id);
            if(equipoEncontrado != null){
                equipoEncontrado.Nombre = equipo.Nombre;
                equipoEncontrado.Municipio = equipo.Municipio;
                _appContext.SaveChanges();
            }
            return equipoEncontrado;
        }
        public void DeleteEquipo(int idEquipo)
        {
            var equipoEncontrado = _appContext.Equipos.FirstOrDefault(e => e.Id == idEquipo);
            if(equipoEncontrado == null)
                return;
            _appContext.Equipos.Remove(equipoEncontrado);
            _appContext.SaveChanges();
        }
        public Equipo GetEquipo(int idEquipo)
        {   
            var equipo = _appContext.Equipos
            .Where(e => e.Id == idEquipo)
            .Include(e => e.Municipio)
            .FirstOrDefault();
            return equipo;
            // return _appContext.Equipos.FirstOrDefault(e => e.Id == idEquipo);
        }
        public IEnumerable<Equipo> GetAllEquipos()
        {
            return _appContext.Equipos.Include(m => m.Municipio).ToList();
        }
        public Municipio AsignarMunicipio(int idEquipo,int idMunicipio)
        {
            var equipoEncontrado = _appContext.Equipos.FirstOrDefault(e => e.Id == idEquipo);
            if(equipoEncontrado != null)
            {
                var municipioEncontrado = _appContext.Municipios.FirstOrDefault(m => m.Id == idMunicipio);
                if(municipioEncontrado != null)
                {
                    equipoEncontrado.Municipio = municipioEncontrado;
                    _appContext.SaveChanges();
                }
                return municipioEncontrado;
            }
            return null;
        }
        public Municipio AsignarMunicipio2(int idEquipo,int idMunicipio)
        {
            var equipoEncontrado = _appContext.Equipos.Find(idEquipo);
            if(equipoEncontrado != null)
            {
                var municipioEncontrado = _appContext.Municipios.Find(idMunicipio);
                if(municipioEncontrado != null)
                {
                    equipoEncontrado.Municipio = municipioEncontrado;
                    _appContext.SaveChanges();
                }
                return municipioEncontrado;
            }
            return null;
        }

    }
}