using Repositorio.Entidades.Entidades.Sial;
using System.Collections.Generic;

namespace Repositorio.Service.Service.Interface
{
    public interface ILoteService
    {
        ICollection<Lote> BuscarTodos();
        Lote Inserir(Lote lote);
        Lote BuscarPorId(int id);
        ICollection<Lote> BuscarPorIdEdital(int idEdital);
        ICollection<Lote> Buscar(string busca, bool encerradas);
    }
}
