using Repositorio.Entidades.Entidades.Sial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Service.Service.Interface
{
    public interface IResponsavelService
    {
        ICollection<Responsavel> BuscarTodos();
        Responsavel Inserir(Responsavel responsavel);
        Responsavel BuscarPorId(int id);
        ICollection<Responsavel> Buscar(string busca);
    }
}
