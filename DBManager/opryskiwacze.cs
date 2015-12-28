namespace DBManager
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("opryskiwacze")]
    public partial class opryskiwacze
    {
        [Key]
        public int id_opryskiwacza { get; set; }

        public int? id_klienta { get; set; }

        public int? marka { get; set; }

        [Required]
        [StringLength(20)]
        public string model { get; set; }

        public int rok_produkcji { get; set; }

        [Required]
        [StringLength(20)]
        public string nr_seryjny { get; set; }

        public bool isobus { get; set; }

        public virtual klient klient { get; set; }

        public virtual prod_opryskiwacze prod_opryskiwacze { get; set; }
    }
}
