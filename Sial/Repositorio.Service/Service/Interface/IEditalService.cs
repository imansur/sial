using Repositorio.Entidades.Entidades.Sial;
using System;
using System.Collections.Generic;

namespace Repositorio.Service.Service.Interface
{
    public interface IEditalService
    {
        ICollection<Edital> BuscarTodos();
        Edital Inserir(Edital edital);
        Edital BuscarPorId(int id);
        ICollection<Edital> Buscar(string busca, bool encerradas);
        IEnumerable<dynamic> BuscarRelLicitacoes(System.DateTime dataDe, System.DateTime dataAte, int destino);
        IEnumerable<dynamic> BuscarRelLicitacoes(int idEdital);
    }
}
