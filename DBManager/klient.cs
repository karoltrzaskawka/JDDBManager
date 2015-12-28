namespace DBManager
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("klient")]
    public partial class klient
    {
        public klient()
        {
            aktywacje_odbiornika = new HashSet<aktywacje_odbiornika>();
            aktywacje_wyswietlacza = new HashSet<aktywacje_wyswietlacza>();
            ciagnikis = new HashSet<ciagniki>();
            gwarancjes = new HashSet<gwarancje>();
            kombajnies = new HashSet<kombajny>();
            maszyny_zielonkowe = new HashSet<maszyny_zielonkowe>();
            odbiornikis = new HashSet<odbiorniki>();
            opryskiwaczes = new HashSet<opryskiwacze>();
            pokazies = new HashSet<pokazy>();
            rozsiewaczes = new HashSet<rozsiewacze>();
            siewniki_pkt = new HashSet<siewniki_pkt>();
            siewnikis = new HashSet<siewniki>();
            wizyty_platne = new HashSet<wizyty_platne>();
            wyswietlaczes = new HashSet<wyswietlacze>();
            zestawy_uprawowe = new HashSet<zestawy_uprawowe>();
        }

        [Key]
        public int id_klienta { get; set; }

        [Required]
        [StringLength(20)]
        public string imie { get; set; }

        [Required]
        [StringLength(30)]
        public string nazwisko { get; set; }

        [Required]
        [StringLength(20)]
        public string telefon { get; set; }

        [Required]
        [StringLength(6)]
        public string kod_pocztowy { get; set; }

        [Required]
        [StringLength(30)]
        public string adres { get; set; }

        [Required]
        [StringLength(40)]
        public string nazwa_firmy { get; set; }

        [Required]
        [StringLength(30)]
        public string nip { get; set; }

        [Required]
        [StringLength(30)]
        public string email { get; set; }

        [StringLength(10)]
        public string zwrot { get; set; }

        public virtual ICollection<aktywacje_odbiornika> aktywacje_odbiornika { get; set; }

        public virtual ICollection<aktywacje_wyswietlacza> aktywacje_wyswietlacza { get; set; }

        public virtual ICollection<ciagniki> ciagnikis { get; set; }

        public virtual ICollection<gwarancje> gwarancjes { get; set; }

        public virtual ICollection<kombajny> kombajnies { get; set; }

        public virtual ICollection<maszyny_zielonkowe> maszyny_zielonkowe { get; set; }

        public virtual ICollection<odbiorniki> odbiornikis { get; set; }

        public virtual ICollection<opryskiwacze> opryskiwaczes { get; set; }

        public virtual ICollection<pokazy> pokazies { get; set; }

        public virtual ICollection<rozsiewacze> rozsiewaczes { get; set; }

        public virtual ICollection<siewniki_pkt> siewniki_pkt { get; set; }

        public virtual ICollection<siewniki> siewnikis { get; set; }

        public virtual ICollection<wizyty_platne> wizyty_platne { get; set; }

        public virtual ICollection<wyswietlacze> wyswietlaczes { get; set; }

        public virtual ICollection<zestawy_uprawowe> zestawy_uprawowe { get; set; }
    }
}
