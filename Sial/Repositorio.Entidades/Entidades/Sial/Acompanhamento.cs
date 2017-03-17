using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repositorio.Entidades.Entidades.Sial
{
    [Table("ACOMPANHAMENTO")]
    public class Acompanhamento
    {

        [Key]
        [Column("ID_ACOMPANHAMENTO")]
        public int IdAcompanhamento { get; set; }

        [Column("DATA")]
        public DateTime Data { get; set; }

        [Column("EVENTO")]
        public string Evento { get; set; }

        [Column("OBSERVACAO")]
        public string Observacao { get; set; }

        [Column("ID_EDITAL")]
        public int IdEdital { get; set; }

        public virtual Edital Edital { get; set; }
    }
}
