namespace DBManager
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("pokazy")]
    public partial class pokazy
    {
        [Key]
        public int id_pokazu { get; set; }

        public int? id_klienta { get; set; }

        [Required]
        [StringLength(20)]
        public string imie { get; set; }

        [Required]
        [StringLength(20)]
        public string nazwisko { get; set; }

        [Column(TypeName = "date")]
        public DateTime data { get; set; }

        public int nr_protokolu_roboczego { get; set; }

        public int nr_protokolu_zd_odb { get; set; }

        public virtual klient klient { get; set; }
    }
}
