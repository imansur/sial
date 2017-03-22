using System;
using System.Data.Entity;
using Repositorio.Entidades.Entidades.Sial;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;

namespace Repositorio.DAL.Contexto.Sial
{
    public class SialContexto : DbContext, IContexto
    {
        public SialContexto()
            : base("SIAL")
        {
            Database.SetInitializer<SialContexto>(null);
        }

        public DbSet<Edital> edital { get; set; }
        public DbSet<Empresa> empresa { get; set; }
        public DbSet<Lote> lote { get; set; }
        public DbSet<LoteEmpresa> loteEmpresa { get; set; }
        public DbSet<Orgao> orgao { get; set; }
        public DbSet<Responsavel> responsavel { get; set; }
        public DbSet<Acompanhamento> acompanhamento { get; set; }


        public int Salvar()
        {
            return this.SaveChanges();
        }

        public IDbSet<T> GetDbSet<T>() where T : class
        {
            return Set<T>();
        }

        public void Refresh()
        {
            foreach (var entity in  this.ChangeTracker.Entries())
            {
                entity.Reload();
            }
        }

    }
}
