using Repositorio.Entidades.Entidades.Sial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Service.Service.Interface
{
    public interface IAcompanhamentoService
    {
        ICollection<Acompanhamento> BuscarTodos();
        Acompanhamento Inserir(Acompanhamento acompanhamento);
        Acompanhamento BuscarPorId(int id);
        ICollection<Acompanhamento> BuscarPorIdEdital(int idEdital);
        ICollection<Acompanhamento> Buscar(string busca, bool encerradas);
    }
}
