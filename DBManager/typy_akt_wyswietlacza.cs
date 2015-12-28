namespace DBManager
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class typy_akt_wyswietlacza
    {
        public typy_akt_wyswietlacza()
        {
            aktywacje_wyswietlacza = new HashSet<aktywacje_wyswietlacza>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(20)]
        public string nazwa { get; set; }

        public virtual ICollection<aktywacje_wyswietlacza> aktywacje_wyswietlacza { get; set; }
    }
}
