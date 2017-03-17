using Repositorio.Service.Service.Interface;
using System;

namespace Repositorio.Service.Session.Interface
{
    public interface ISialSession : IDisposable
    {
        IEditalService Edital { get; }
        IEmpresaService Empresa { get; }
        ILoteService Lote { get; }
        ILoteEmpresaService LoteEmpresa { get; }
        IOrgaoService Orgao { get; }
        IResponsavelService Responsavel { get; }
        IAcompanhamentoService Acompanhemento { get; }

        bool Salvar();
    }
}
