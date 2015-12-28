namespace DBManager
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("wyswietlacze")]
    public partial class wyswietlacze
    {
        public wyswietlacze()
        {
            aktywacje_wyswietlacza = new HashSet<aktywacje_wyswietlacza>();
        }

        [Key]
        public int id_wyswietlacza { get; set; }

        public int? id_klienta { get; set; }

        [Required]
        [StringLength(20)]
        public string model { get; set; }

        public int rok_produkcji { get; set; }

        [Required]
        [StringLength(20)]
        public string nr_seryjny { get; set; }

        public virtual ICollection<aktywacje_wyswietlacza> aktywacje_wyswietlacza { get; set; }

        public virtual klient klient { get; set; }
    }
}
