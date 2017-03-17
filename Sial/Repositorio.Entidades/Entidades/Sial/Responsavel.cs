using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Repositorio.Entidades.Entidades.Sial
{
    [Table("RESPONSAVEL")]
    public class Responsavel
    {
        [Key]
        [Column("ID_RESPONSAVEL")]
        public Int32? IdResponsavel { get; set; }

        [Column("NOME")]
        public String Nome { get; set; }
    }
}
