namespace DBManager
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Mechanik")]
    public partial class Mechanik
    {
        [Key]
        public int Id_mechanika { get; set; }

        [StringLength(20)]
        public string Imie { get; set; }

        [StringLength(30)]
        public string Nazwisko { get; set; }
    }
}
