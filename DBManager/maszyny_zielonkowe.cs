namespace DBManager
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class maszyny_zielonkowe
    {
        [Key]
        public int id_maszyny_zielonkowej { get; set; }

        public int? id_klienta { get; set; }

        public int? typ { get; set; }

        public int? marka { get; set; }

        [Required]
        [StringLength(20)]
        public string model { get; set; }

        public int rok_produkcji { get; set; }

        [Required]
        [StringLength(20)]
        public string nr_seryjny { get; set; }

        public double szerokosc { get; set; }

        public bool isobus { get; set; }

        public virtual klient klient { get; set; }

        public virtual prod_zielonkowe prod_zielonkowe { get; set; }

        public virtual typy_maszyn_ziel typy_maszyn_ziel { get; set; }
    }
}
