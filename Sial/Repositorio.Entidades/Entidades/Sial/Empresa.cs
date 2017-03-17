using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repositorio.Entidades.Entidades.Sial
{
    [Table("EMPRESA")]
    public class Empresa
    {
        [Key]
        [Column("ID_EMPRESA")]
        public Int32? IdEmpresa { get; set; }

        [Column("NOME")]
        public String Nome { get; set; }

        [Column("TELEFONE")]
        public String Telefone { get; set; }

        public virtual ICollection<LoteEmpresa> LoteEmpresa { get; set; }

        public Empresa()
        {
            this.LoteEmpresa = new HashSet<LoteEmpresa>();
        }
    }
}
