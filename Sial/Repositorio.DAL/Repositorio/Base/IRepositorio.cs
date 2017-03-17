using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Repositorio.DAL.Repositorio.Base
{
    public interface IRepositorio<T> where T : class
    {

        T Inserir(T entity);

        T Excluir(T entity);

        int Count(Expression<Func<T, bool>> predicate);

        ICollection<T> Where(Expression<Func<T, bool>> predicate);

        IQueryable<T> Todos { get; }

    }
}
