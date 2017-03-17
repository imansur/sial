using Repositorio.DAL.Repositorio.Base;
using Repositorio.Entidades.Entidades.Sial;
using Repositorio.Service.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Service.Service
{
    class ResponsavelService : IResponsavelService
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(ResponsavelService));
        private readonly IRepositorio<Responsavel> responsavelRep;

        public ResponsavelService(IRepositorio<Responsavel> orgao)
        {
            responsavelRep = orgao;
        }

        public ICollection<Entidades.Entidades.Sial.Responsavel> BuscarTodos()
        {
            return responsavelRep.Todos.ToList();
        }

        public Entidades.Entidades.Sial.Responsavel Inserir(Entidades.Entidades.Sial.Responsavel responsavel)
        {
            return responsavelRep.Inserir(responsavel);
        }

        public Entidades.Entidades.Sial.Responsavel BuscarPorId(int id)
        {
            return responsavelRep.Where(resp => resp.IdResponsavel == id).SingleOrDefault();
        }

        public ICollection<Entidades.Entidades.Sial.Responsavel> Buscar(string busca)
        {
            return responsavelRep.Where(resp => resp.Nome.Contains(busca));
        }
    }
}
