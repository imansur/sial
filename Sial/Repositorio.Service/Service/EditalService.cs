using Repositorio.DAL.Repositorio.Base;
using Repositorio.Entidades.Entidades.Sial;
using Repositorio.Service.Service.Interface;
using System.Collections.Generic;
using System.Linq;

namespace Repositorio.Service.Service
{
    public class EditalService : IEditalService
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(EditalService));
        private readonly IRepositorio<Edital> editalRep;

        public EditalService(IRepositorio<Edital> edital)
        {
            editalRep = edital;
        }

        public ICollection<Edital> BuscarTodos()
        {
            return editalRep.Todos.ToList();
        }

        public Edital Inserir(Edital edital)
        {
            return editalRep.Inserir(edital);
        }

        public Edital BuscarPorId(int id)
        {
            return editalRep.Where(edital => edital.IdEdital == id).SingleOrDefault();
        }

        public ICollection<Edital> Buscar(string busca, bool encerradas)
        {
            if (encerradas)
            {
                return editalRep.Where(edital => (edital.IdEdital.ToString().Contains(busca) ||
                                             edital.Apelido.Contains(busca) ||
                                             edital.Orgao.Nome.Contains(busca) ||
                                             edital.NumeroEdital.Contains(busca)) &&
                                             edital.Destino == 3);
            }
            else
            {
                return editalRep.Where(edital => (edital.IdEdital.ToString().Contains(busca) ||
                                             edital.Apelido.Contains(busca) ||
                                             edital.Orgao.Nome.Contains(busca) ||
                                             edital.NumeroEdital.Contains(busca)) &&
                                             edital.Destino != 3);
            }

        }

        
        public IEnumerable<dynamic> BuscarRelLicitacoes(System.DateTime dataDe, System.DateTime dataAte, int destino)
        {
            ICollection<Edital> editais = editalRep.Todos.ToList();
          

            var result = from e in editais
                         where e.DataHoraEntrega >= dataDe && e.DataHoraEntrega <= dataAte && e.Destino == destino
                         from l in e.Lote
                         from le in l.LoteEmpresa.DefaultIfEmpty()
                         select new
                         {
                             IdEdital = e.IdEdital,
                             NumEdital = e.NumeroEdital,
                             Contratante = e.Orgao.Nome,
                             Situacao = e.Destino,
                             Apelido = e.Apelido,
                             IdLote = l.IdLote,
                             NumLote = l.NumeroLote,
                             ValorLote = l.Orcamento,
                             Vencedor = l.Vencedor,
                             Empresa = le != null ? le.Empresa.Nome : null,
                             ValorProposta = le != null ? le.Proposta : null,
                             DescricaoLote = l.Descricao
                         };

            
            return result;
                                

          
        }


        public IEnumerable<dynamic> BuscarRelLicitacoes(int idEdital)
        {
            Edital edital = BuscarPorId(idEdital);

            var result = from l in edital.Lote
                         from le in l.LoteEmpresa.DefaultIfEmpty()
                         select new
                         {
                             IdEdital = edital.IdEdital,
                             NumEdital = edital.NumeroEdital,
                             Contratante = edital.Orgao.Nome,
                             Situacao = edital.Destino,
                             Apelido = edital.Apelido,
                             IdLote = l.IdLote,
                             NumLote = l.NumeroLote,
                             ValorLote = l.Orcamento,
                             Vencedor = l.Vencedor,
                             Empresa = le != null ? le.Empresa.Nome : null,
                             ValorProposta = le != null ? le.Proposta : null,
                             DescricaoLote = l.Descricao
                         };

            return result;
        }
    }
}
