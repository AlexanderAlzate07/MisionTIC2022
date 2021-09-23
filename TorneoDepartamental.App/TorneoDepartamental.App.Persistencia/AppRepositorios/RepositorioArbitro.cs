using System.Collections.Generic;
using TorneoDepartamental.App.Dominio;
using System.Linq;

namespace TorneoDepartamental.App.Persistencia
{
    public class RepositorioArbitro : IRepositorioArbitro
    {
        private readonly AppContext _appContext = new AppContext();
        public RepositorioArbitro(AppContext appContext)
        {
        }
        public Arbitro AddArbitro(Arbitro arbitro)
        {
            var arbitroAdicionado = _appContext.Arbitros.Add(arbitro);
            _appContext.SaveChanges();
            return arbitroAdicionado.Entity;
        }
        public Arbitro UpdateArbitro(Arbitro arbitro)
        {
            var arbitroEncontrado = _appContext.Arbitros.FirstOrDefault(a => a.Id == arbitro.Id);
            if(arbitroEncontrado != null){
                arbitroEncontrado.Nombre = arbitro.Nombre;
                arbitroEncontrado.Telefono = arbitro.Telefono;
                arbitroEncontrado.Documento = arbitro.Documento;
                arbitroEncontrado.ColegioArbitro = arbitro.ColegioArbitro;
                _appContext.SaveChanges();
            }
            return arbitroEncontrado;
        }
        public void DeleteArbitro(int idArbitro)
        {
            var arbitroEncontrado = _appContext.Arbitros.FirstOrDefault(a => a.Id == idArbitro);
            if(arbitroEncontrado == null)
                return;
            _appContext.Arbitros.Remove(arbitroEncontrado);
            _appContext.SaveChanges();
        }
        public Arbitro GetArbitro(int idArbitro)
        {
            return _appContext.Arbitros.FirstOrDefault(a => a.Id == idArbitro);
        }
        public IEnumerable<Arbitro> GetAllArbitros()
        {
            return _appContext.Arbitros;
        }
    }
}