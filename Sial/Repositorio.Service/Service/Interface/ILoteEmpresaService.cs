using Repositorio.Entidades.Entidades.Sial;
using System.Collections.Generic;

namespace Repositorio.Service.Service.Interface
{
    public interface ILoteEmpresaService
    {
        ICollection<LoteEmpresa> BuscarTodos();
        LoteEmpresa Inserir(LoteEmpresa loteEmpresa);
        LoteEmpresa Exluir(LoteEmpresa loteEmpresa);
        LoteEmpresa BuscarPorId(int id);
        LoteEmpresa BuscarPorIdLoteIdEmpresa(int idLote, int idEmpresa);
    }
}
