namespace DBManager
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class aktywacje_wyswietlacza
    {
        [Key]
        public int id_aktywacji { get; set; }

        public int? id_klienta { get; set; }

        public int? nazwa_aktywacji { get; set; }

        public int? id_wyswietlacza { get; set; }

        [Required]
        [StringLength(20)]
        public string nr_zamowienia { get; set; }

        public virtual klient klient { get; set; }

        public virtual wyswietlacze wyswietlacze { get; set; }

        public virtual typy_akt_wyswietlacza typy_akt_wyswietlacza { get; set; }
    }
}
