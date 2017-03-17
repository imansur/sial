using Repositorio.DAL;
using Repositorio.DAL.Contexto.Sial;
using Repositorio.DAL.Repositorio.Base;
using Repositorio.Entidades.Entidades.Sial;
using Repositorio.Service.Service;
using Repositorio.Service.Service.Interface;
using Repositorio.Service.Session.Interface;

namespace Repositorio.Service.Session
{
    public class SialSession : ISialSession
    {
        private IContexto ctx { get; set; }
        private IEditalService iEditalService;
        private IEmpresaService iEmpresaService;
        private ILoteService iLoteService;
        private ILoteEmpresaService iLoteEmpresaService;
        private IOrgaoService iOrgaoService;
        private IResponsavelService iResponsavelService;
        private IAcompanhamentoService iAcompanhamentoService;

        public SialSession()
        {
            ctx = new SialContexto();
        }

        public bool Salvar()
        {
            if (ctx.Salvar() > 0)
            {
                return true;
            }

            return false;
        }

        public void Dispose()
        {
            ctx.Dispose();
        }

        public IEmpresaService Empresa
        {
            get
            {
                if (iEmpresaService == null)
                {
                    iEmpresaService = new EmpresaService(new Repositorio<Empresa>(ctx));
                }

                return iEmpresaService;
            }
        }


        public IEditalService Edital
        {
            get
            {
                if (iEditalService == null)
                {
                    iEditalService = new EditalService(new Repositorio<Edital>(ctx));
                }

                return iEditalService;
            }
        }

        public ILoteService Lote
        {
            get
            {
                if (iLoteService == null)
                {
                    iLoteService = new LoteService(new Repositorio<Lote>(ctx));
                }

                return iLoteService;
            }
        }

        public ILoteEmpresaService LoteEmpresa
        {
            get
            {
                if (iLoteEmpresaService == null)
                {
                    iLoteEmpresaService = new LoteEmpresaService(new Repositorio<LoteEmpresa>(ctx));
                }

                return iLoteEmpresaService;
            }
        }

        public IOrgaoService Orgao
        {
            get
            {
                if (iOrgaoService == null)
                {
                    iOrgaoService = new OrgaoService(new Repositorio<Orgao>(ctx));
                }

                return iOrgaoService;
            }
        }

        public IResponsavelService Responsavel
        {
            get
            {
                if (iResponsavelService == null)
                {
                    iResponsavelService = new ResponsavelService(new Repositorio<Responsavel>(ctx));
                }

                return iResponsavelService;
            }
        }

        public IAcompanhamentoService Acompanhemento
        {
            get
            {
                if (iAcompanhamentoService == null)
                {
                    iAcompanhamentoService = new AcompanhamentoService(new Repositorio<Acompanhamento>(ctx));
                }

                return iAcompanhamentoService;
            }
        }
    }
}
