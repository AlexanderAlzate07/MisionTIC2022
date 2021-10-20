using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TorneoDepartamental.App.Dominio;

namespace TorneoDepartamental.App.Persistencia
{
    public class RepositorioEquipo : IRepositorioEquipo
    {
        private readonly AppContext _appContext = new AppContext();


        public Equipo AddEquipo(Equipo equipo)
        {
            var equipoAdicionado = _appContext.Equipos.Add(equipo);
            _appContext.SaveChanges();
            return equipoAdicionado.Entity;
        }
        public Equipo UpdateEquipo(Equipo equipo)
        {
            var equipoEncontrado = _appContext.Equipos.FirstOrDefault(e => e.Id == equipo.Id);
            if (equipoEncontrado != null)
            {
                equipoEncontrado.Nombre = equipo.Nombre;
                equipoEncontrado.Municipio = equipo.Municipio;
                _appContext.SaveChanges();
            }
            return equipoEncontrado;
        }
        public void DeleteEquipo(int idEquipo)
        {
            var equipoEncontrado = _appContext.Equipos.FirstOrDefault(e => e.Id == idEquipo);
            if (equipoEncontrado == null)
                return;
            _appContext.Equipos.Remove(equipoEncontrado);
            _appContext.SaveChanges();
        }
        public Equipo GetEquipo(int idEquipo)
        {
            var equipo = _appContext.Equipos
                    .Where(e => e.Id == idEquipo)
                    .Include(t => t.Municipio)
                    .FirstOrDefault();
            return equipo;
        }
        public IEnumerable<Equipo> GetAllEquipos()
        {
            return _appContext.Equipos.Include(m => m.Municipio).ToList();
        }
        public Municipio AsignarMunicipio(int idEquipo, int idMunicipio)
        {
            var equipoEncontrado = _appContext.Equipos.FirstOrDefault(e => e.Id == idEquipo);
            if (equipoEncontrado != null)
            {
                var municipioEncontrado = _appContext.Municipios.FirstOrDefault(m => m.Id == idMunicipio);
                if (municipioEncontrado != null)
                {
                    equipoEncontrado.Municipio = municipioEncontrado;
                    _appContext.SaveChanges();
                }
                return municipioEncontrado;
            }
            return null;
        }

        IEnumerable<Equipo> IRepositorioEquipo.SearchEquipo(string nombre)
        {
            return _appContext.Equipos
                     .Where(e => e.Nombre.Contains(nombre));
        }

        IEnumerable<Equipo> IRepositorioEquipo.FilterEquipo(string nombre)
        {
            return _appContext.Equipos
                     .Where(e => e.Nombre.Equals(nombre)).ToList();
        }

    }
}