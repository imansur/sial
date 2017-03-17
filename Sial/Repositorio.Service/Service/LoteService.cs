using Repositorio.DAL.Repositorio.Base;
using Repositorio.Entidades.Entidades.Sial;
using Repositorio.Service.Service.Interface;
using System.Collections.Generic;
using System.Linq;

namespace Repositorio.Service.Service
{
    public class LoteService : ILoteService
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(LoteService));
        private readonly IRepositorio<Lote> loteRep;

        public LoteService(IRepositorio<Lote> lote)
        {
            loteRep = lote;
        }

        public ICollection<Lote> BuscarTodos()
        {
            return loteRep.Todos.ToList();
        }

        public Lote Inserir(Lote lote)
        {
            return loteRep.Inserir(lote);
        }

        public Lote BuscarPorId(int id)
        {
            return loteRep.Where(lote => lote.IdLote == id).SingleOrDefault();
        }

        public ICollection<Lote> BuscarPorIdEdital(int idEdital)
        {
            return loteRep.Where(lote => lote.IdEdital == idEdital).AsQueryable().ToList();
        }

        public ICollection<Lote> Buscar(string busca, bool encerradas)
        {
            if (encerradas)
            {
                return loteRep.Where(lote => (lote.Descricao.Contains(busca) ||
                                             lote.IdLote.ToString().Contains(busca) ||
                                             lote.NumeroLote.Contains(busca) ||
                                             lote.Edital.NumeroEdital.Contains(busca) ||
                                             lote.Edital.Apelido.Contains(busca) ||
                                             lote.Edital.IdEdital.ToString().Contains(busca)) &&
                                             lote.Edital.Destino == 3);
            }
            else
            {
                return loteRep.Where(lote => (lote.Descricao.Contains(busca) ||
                                             lote.IdLote.ToString().Contains(busca) ||
                                             lote.NumeroLote.Contains(busca) ||
                                             lote.Edital.NumeroEdital.Contains(busca) ||
                                             lote.Edital.Apelido.Contains(busca) ||
                                             lote.Edital.IdEdital.ToString().Contains(busca)) &&
                                             lote.Edital.Destino != 3);
            }
        }
    }
}
