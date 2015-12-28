namespace DBManager
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class siewniki_pkt
    {
        [Key]
        public int id_siewnika_pkt { get; set; }

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

        public double szerokosc { get; set; }

        public int liczba_sekcji { get; set; }

        public virtual klient klient { get; set; }

        public virtual prod_siewniki prod_siewniki { get; set; }
    }
}
