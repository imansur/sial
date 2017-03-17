using Repositorio.Entidades.Entidades.Sial;
using System.Collections.Generic;

namespace Repositorio.Service.Service.Interface
{
    public interface IEmpresaService
    {
        ICollection<Empresa> BuscarTodos();
        Empresa BuscarPorId(int id);
        Empresa Inserir(Empresa empresa);
        ICollection<Empresa> Buscar(string busca);
    }
}
