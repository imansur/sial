using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repositorio.Entidades.Entidades.Sial
{
    [Table("LOTE_EMPRESA")]
    public class LoteEmpresa
    {
        [Key]
        [Column("ID_LOTE_EMPRESA")]
        public int IdLoteEmpresa { get; set; }

        [Column("ID_LOTE")]
        public int IdLote { get; set; }

        [Column("ID_EMPRESA")]
        public int IdEmpresa { get; set; }

        [Column("PROPOSTA")]
        public decimal? Proposta { get; set; }

        public virtual Empresa Empresa { get; set; }
        public virtual Lote Lote { get; set; }

    }
}
