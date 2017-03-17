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
    public class AcompanhamentoService : IAcompanhamentoService

    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(AcompanhamentoService));
        private readonly IRepositorio<Acompanhamento> acompanhamentoRep;

        public AcompanhamentoService(IRepositorio<Acompanhamento> acompanhamento)
        {
            acompanhamentoRep = acompanhamento;
        }

        public ICollection<Acompanhamento> BuscarTodos()
        {
            return acompanhamentoRep.Todos.ToList();
        }

        public Acompanhamento Inserir(Acompanhamento acompanhamento)
        {
            return acompanhamentoRep.Inserir(acompanhamento);
        }

        public Acompanhamento BuscarPorId(int id)
        {
            return acompanhamentoRep.Where(acomp => acomp.IdAcompanhamento == id).SingleOrDefault();
        }

        public ICollection<Acompanhamento> BuscarPorIdEdital(int idEdital)
        {
            ICollection<Acompanhamento> retAcompanhamento;
            retAcompanhamento = acompanhamentoRep.Where(acomp => acomp.IdEdital == idEdital).AsQueryable().ToList();
            return retAcompanhamento.OrderBy(acomp => acomp.IdEdital).ThenBy(acomp => acomp.Data).ToList();
        }

        public ICollection<Acompanhamento> Buscar(string busca, bool encerradas)
        {
            ICollection<Acompanhamento> retAcompanhamento;
            
            if (encerradas)
            {
                retAcompanhamento = acompanhamentoRep.Where(acomp => (acomp.IdAcompanhamento.ToString().Contains(busca) ||
                                             acomp.Evento.Contains(busca) ||
                                             acomp.Observacao.Contains(busca) ||
                                             acomp.Edital.IdEdital.ToString().Contains(busca) ||
                                             acomp.Edital.NumeroEdital.Contains(busca) ||
                                             acomp.Edital.Apelido.Contains(busca)) &&
                                             acomp.Edital.Destino == 3);
            }
            else
            {
                retAcompanhamento = acompanhamentoRep.Where(acomp => (acomp.IdAcompanhamento.ToString().Contains(busca) ||
                                             acomp.Evento.Contains(busca) ||
                                             acomp.Observacao.Contains(busca) ||
                                             acomp.Edital.IdEdital.ToString().Contains(busca) ||
                                             acomp.Edital.NumeroEdital.Contains(busca) ||
                                             acomp.Edital.Apelido.Contains(busca)) &&
                                             acomp.Edital.Destino != 3);
            }

            return retAcompanhamento.OrderBy(acomp => acomp.IdEdital).ThenBy(acomp => acomp.Data).ToList();
        }
    }
}
