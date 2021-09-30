using System.Collections.Generic;
using TorneoDepartamental.App.Dominio;
using System.Linq;

namespace TorneoDepartamental.App.Persistencia
{
    public class RepositorioDirectorTecnico : IRepositorioDirectorTecnico
    {
        private readonly AppContext _appContext = new AppContext();

        public RepositorioDirectorTecnico()
        {    
        }

        public DirectorTecnico AddDirectorTecnico(DirectorTecnico tecnico)
        {
            var tecnicoAdicionado = _appContext.DirectoresTecnicos.Add(tecnico);
            _appContext.SaveChanges();
            return tecnicoAdicionado.Entity;
        }
        public DirectorTecnico UpdateDirectorTecnico(DirectorTecnico tecnico)
        {
            var tecnicoEncontrado = _appContext.DirectoresTecnicos.FirstOrDefault(dt => dt.Id == tecnico.Id);
            if(tecnicoEncontrado != null){
                tecnicoEncontrado.Nombre = tecnico.Nombre;
                tecnicoEncontrado.Telefono = tecnico.Telefono;
                tecnicoEncontrado.Documento = tecnico.Documento;
                tecnicoEncontrado.Equipo = tecnico.Equipo;
                _appContext.SaveChanges();
            }
            return tecnicoEncontrado;
        }
        public void DeleteDirectorTecnico(int idDirectorTecnico)
        {
            var tecnicoEncontrado = _appContext.DirectoresTecnicos.FirstOrDefault(dt => dt.Id == idDirectorTecnico);
            if(tecnicoEncontrado == null)
                return;
            _appContext.DirectoresTecnicos.Remove(tecnicoEncontrado);
            _appContext.SaveChanges();
        }
        public DirectorTecnico GetDirectorTecnico(int idDirectorTecnico)
        {
            return _appContext.DirectoresTecnicos.FirstOrDefault(dt => dt.Id == idDirectorTecnico);
        }
        public IEnumerable<DirectorTecnico> GetAllDirectorTecnicos()
        {
            return _appContext.DirectoresTecnicos;
        }
        public Equipo AsignarEquipo(int idDirectorTecnico,int idEquipo)
        {
            var tecnicoEncontrado = _appContext.DirectoresTecnicos.FirstOrDefault(dt => dt.Id == idDirectorTecnico);
            if(tecnicoEncontrado != null)
            {
                var equipoEncontrado = _appContext.Equipos.FirstOrDefault(e => e.Id == idEquipo);
                if(equipoEncontrado != null)
                {
                    tecnicoEncontrado.Equipo = equipoEncontrado;
                    _appContext.SaveChanges();
                }
                return equipoEncontrado;
            }
            return null;
        }


    }
}