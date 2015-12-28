namespace DBManager
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class wizyty_platne
    {
        [Key]
        public int id_wizyty { get; set; }

        public int? id_klienta { get; set; }

        [Required]
        [StringLength(20)]
        public string imie { get; set; }

        [Required]
        [StringLength(20)]
        public string nazwisko { get; set; }

        [Column(TypeName = "date")]
        public DateTime data { get; set; }

        public int nr_protokolu { get; set; }

        [Column(TypeName = "money")]
        public decimal wartosc { get; set; }

        public virtual klient klient { get; set; }
    }
}
