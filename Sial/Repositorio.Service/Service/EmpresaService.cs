using Repositorio.DAL.Repositorio.Base;
using Repositorio.Entidades.Entidades.Sial;
using Repositorio.Service.Service.Interface;
using System.Collections.Generic;
using System.Linq;

namespace Repositorio.Service.Service
{
    public class EmpresaService : IEmpresaService
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(EmpresaService));
        private readonly IRepositorio<Empresa> empresaRep;

        public EmpresaService(IRepositorio<Empresa> empresa)
        {
            empresaRep = empresa;
        }

        public ICollection<Empresa> BuscarTodos()
        {
            return empresaRep.Todos.ToList();
        }

        public Empresa BuscarPorId(int id)
        {
            return empresaRep.Where(emp => emp.IdEmpresa == id).SingleOrDefault();
        }

        public Empresa Inserir(Empresa empresa)
        {
            return empresaRep.Inserir(empresa);
        }

        public ICollection<Empresa> Buscar(string busca)
        {
          
            return empresaRep.Where(emp => emp.Nome.Contains(busca) );
        }
    }
}
