using Repositorio.DAL.Repositorio.Base;
using Repositorio.Entidades.Entidades.Sial;
using Repositorio.Service.Service.Interface;
using System.Collections.Generic;
using System.Linq;

namespace Repositorio.Service.Service
{
    public class OrgaoService : IOrgaoService
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(OrgaoService));
        private readonly IRepositorio<Orgao> orgaoRep;
        
        public OrgaoService(IRepositorio<Orgao> orgao)
        {
            orgaoRep = orgao;
        }
        
        public ICollection<Entidades.Entidades.Sial.Orgao> BuscarTodos()
        {
            return orgaoRep.Todos.ToList();
        }

        public Entidades.Entidades.Sial.Orgao Inserir(Entidades.Entidades.Sial.Orgao orgao)
        {
            return orgaoRep.Inserir(orgao);
        }

        public Entidades.Entidades.Sial.Orgao BuscarPorId(int id)
        {
            return orgaoRep.Where(orgao => orgao.IdOrgao == id).SingleOrDefault();
        }

        public ICollection<Entidades.Entidades.Sial.Orgao> Buscar(string busca)
        {
            return orgaoRep.Where(orgao => orgao.Nome.Contains(busca));
        }
    }
}
