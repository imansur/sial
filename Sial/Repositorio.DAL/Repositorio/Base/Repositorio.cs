using System;
using System.Linq;
using System.Linq.Expressions;

namespace Repositorio.DAL.Repositorio.Base
{
    public class Repositorio<T> : IRepositorio<T> where T : class
    {
        private readonly IContexto ctx;

        public Repositorio(IContexto context)
        {
            ctx = context;
        }

        public T Inserir(T entity)
        {
            var entidade = ctx.GetDbSet<T>();
            return entidade.Add(entity);
        }

        public int Count(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            var entidade = ctx.GetDbSet<T>();
            return entidade.Count(predicate);
        }

        public System.Collections.Generic.ICollection<T> Where(Expression<Func<T, bool>> predicate)
        {
            var entidade = ctx.GetDbSet<T>();
            return entidade.Where(predicate).ToList();
        }

        public IQueryable<T> Todos
        {
            get
            {
                var entidade = ctx.GetDbSet<T>();
                return entidade.AsQueryable();
            }
        }

        public T Excluir(T entity)
        {
            var entidade = ctx.GetDbSet<T>();
            return entidade.Remove(entity);
        }
    }
}
