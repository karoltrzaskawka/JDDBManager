namespace DBManager
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class aktywacje_odbiornika
    {
        [Key]
        public int id_aktywacji { get; set; }

        public int? id_klienta { get; set; }

        public int? typ_aktywacji { get; set; }

        public int? id_odbiornika { get; set; }

        [Required]
        [StringLength(20)]
        public string nr_zamowienia { get; set; }

        public virtual klient klient { get; set; }

        public virtual odbiorniki odbiorniki { get; set; }

        public virtual typy_akt_odbiornika typy_akt_odbiornika { get; set; }
    }
}
