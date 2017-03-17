using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Repositorio.Entidades.Entidades.Sial
{
    [Table("ORGAO")]
    public class Orgao
    {
        [Key]
        [Column("ID_ORGAO")]
        public Int32? IdOrgao { get; set; }

        [Column("NOME")]
        public String Nome { get; set; }

    }
}
