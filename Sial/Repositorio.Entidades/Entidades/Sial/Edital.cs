using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repositorio.Entidades.Entidades.Sial
{
    [Table("EDITAL")]
    public class Edital
    {

        [Key]
        [Column("ID_EDITAL")]
        public int IdEdital { get; set; }

        [Column("NUMERO_EDITAL")]
        public string NumeroEdital { get; set; }

        [Column("APELIDO")]
        public string Apelido { get; set; }

        [Column("DATA_HORA_ENTREGA")]
        public DateTime DataHoraEntrega { get; set; }

        [Column("DESTINO")]
        public Int32? Destino { get; set; }

        [Column("LOCAL")]
        public string Local { get; set; }

        [Column("DATA_DESCARTE")]
        public DateTime? DataDescarte { get; set; }

        [Column("OBJETO")]
        public string Objeto { get; set; }

        [Column("OBSERVACAO")]
        public string Observacao { get; set; }

        [Column("ID_ORGAO")]
        public int? IdOrgao { get; set; }

        [Column("ID_RESPONSAVEL")]
        public int? IdResponsavel { get; set; }

        public virtual Orgao Orgao { get; set; }

        public virtual Responsavel Responsavel { get; set; }

        public virtual ICollection<Lote> Lote { get; set; }

        public virtual ICollection<Acompanhamento> Acompanhamento { get; set; }

        public Edital()
        {
            this.Lote = new HashSet<Lote>();
            this.Acompanhamento = new HashSet<Acompanhamento>();
        }

    }
}
