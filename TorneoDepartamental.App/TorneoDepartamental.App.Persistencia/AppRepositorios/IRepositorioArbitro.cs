using System.Collections.Generic;
using TorneoDepartamental.App.Dominio;

namespace TorneoDepartamental.App.Persistencia
{
    public interface IRepositorioArbitro
    {
        Arbitro AddArbitro(Arbitro arbitro);
        Arbitro UpdateArbitro(Arbitro arbitro);
        void DeleteArbitro(int idArbitro);
        Arbitro GetArbitro(int idArbitro);
        IEnumerable<Arbitro> GetAllArbitros();

    }
}