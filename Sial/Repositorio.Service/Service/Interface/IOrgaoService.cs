using Repositorio.Entidades.Entidades.Sial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Service.Service.Interface
{
    public interface IOrgaoService
    {
        ICollection<Orgao> BuscarTodos();
        Orgao Inserir(Orgao orgao);
        Orgao BuscarPorId(int id);
        ICollection<Orgao> Buscar(string busca);
    }
}
