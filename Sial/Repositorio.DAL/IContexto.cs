using System;
using System.Data.Entity;

namespace Repositorio.DAL
{
    public interface IContexto : IDisposable
    {
        int Salvar();
        IDbSet<T> GetDbSet<T>() where T : class;
        void Refresh();
    }
}
