using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repositorio.Entidades.Entidades.Sial
{
    [Table("LOTE")]
    public class Lote
    {

        [Key]
        [Column("ID_LOTE")]
        public int IdLote { get; set; }

        [Column("NUMERO_LOTE")]
        public string NumeroLote { get; set; }

        [Column("DESCRICAO")]
        public string Descricao { get; set; }

        [Column("PRAZO_EXECUCAO")]
        public Int32? PrazoExecucao { get; set; }

        [Column("ORCAMENTO")]
        public decimal? Orcamento { get; set; }

        [Column("VENCEDOR")]
        public bool Vencedor { get; set; }

        [Column("ID_EDITAL")]
        public int IdEdital { get; set; }

        public virtual Edital Edital { get; set; }
        public virtual ICollection<LoteEmpresa> LoteEmpresa { get; set; }

        public Lote()
        {
            this.LoteEmpresa = new HashSet<LoteEmpresa>();
        }
    }
}
