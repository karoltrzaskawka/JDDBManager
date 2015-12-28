namespace DBManager
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("gwarancje")]
    public partial class gwarancje
    {
        [Key]
        public int id_gwarancji { get; set; }

        public int? id_klienta { get; set; }

        public int nr_protokolu_gwarancyjnego { get; set; }

        public int nr_protokolu_zd_odb { get; set; }

        [Column(TypeName = "money")]
        public decimal wartosc { get; set; }

        public virtual klient klient { get; set; }
    }
}
