using Repositorio.DAL.Repositorio.Base;
using Repositorio.Entidades.Entidades.Sial;
using Repositorio.Service.Service.Interface;
using System.Collections.Generic;
using System.Linq;

namespace Repositorio.Service.Service
{
    public class LoteEmpresaService : ILoteEmpresaService
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(LoteEmpresaService));
        private readonly IRepositorio<LoteEmpresa> loteEmpresaRep;

        public LoteEmpresaService(IRepositorio<LoteEmpresa> loteEmpresa)
        {
            loteEmpresaRep = loteEmpresa;
        }

        public ICollection<LoteEmpresa> BuscarTodos()
        {
            return loteEmpresaRep.Todos.ToList();
        }

        public LoteEmpresa Inserir(LoteEmpresa loteEmpresa)
        {
            return loteEmpresaRep.Inserir(loteEmpresa);
        }

        public LoteEmpresa BuscarPorId(int id)
        {
            return loteEmpresaRep.Where(loteEmp => loteEmp.IdLoteEmpresa == id).SingleOrDefault();
        }

        public LoteEmpresa Exluir(LoteEmpresa loteEmpresa)
        {
            return loteEmpresaRep.Excluir(loteEmpresa);
        }

        public LoteEmpresa BuscarPorIdLoteIdEmpresa(int idLote, int idEmpresa)
        {
            return loteEmpresaRep.Where(loteEmp => loteEmp.IdLote == idLote )
                                 .Where(loteEmp => loteEmp.IdEmpresa == idEmpresa)
                                 .SingleOrDefault();
        }
    }
}
