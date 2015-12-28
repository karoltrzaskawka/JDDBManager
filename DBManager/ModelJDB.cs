namespace DBManager
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelJDB : DbContext
    {
        public ModelJDB()
            : base("name=ModelJDB")
        {
        }

        public virtual DbSet<aktywacje_odbiornika> aktywacje_odbiornika { get; set; }
        public virtual DbSet<aktywacje_wyswietlacza> aktywacje_wyswietlacza { get; set; }
        public virtual DbSet<ciagniki> ciagnikis { get; set; }
        public virtual DbSet<gwarancje> gwarancjes { get; set; }
        public virtual DbSet<klient> klients { get; set; }
        public virtual DbSet<kombajny> kombajnies { get; set; }
        public virtual DbSet<maszyny_zielonkowe> maszyny_zielonkowe { get; set; }
        public virtual DbSet<Mechanik> Mechaniks { get; set; }
        public virtual DbSet<odbiorniki> odbiornikis { get; set; }
        public virtual DbSet<opryskiwacze> opryskiwaczes { get; set; }
        public virtual DbSet<pokazy> pokazies { get; set; }
        public virtual DbSet<prod_ciagniki> prod_ciagniki { get; set; }
        public virtual DbSet<prod_kombajny> prod_kombajny { get; set; }
        public virtual DbSet<prod_opryskiwacze> prod_opryskiwacze { get; set; }
        public virtual DbSet<prod_rozsiewacze> prod_rozsiewacze { get; set; }
        public virtual DbSet<prod_siewniki> prod_siewniki { get; set; }
        public virtual DbSet<prod_zestawy_uprawowe> prod_zestawy_uprawowe { get; set; }
        public virtual DbSet<prod_zielonkowe> prod_zielonkowe { get; set; }
        public virtual DbSet<rozsiewacze> rozsiewaczes { get; set; }
        public virtual DbSet<siewniki> siewnikis { get; set; }
        public virtual DbSet<siewniki_pkt> siewniki_pkt { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<typy_akt_odbiornika> typy_akt_odbiornika { get; set; }
        public virtual DbSet<typy_akt_wyswietlacza> typy_akt_wyswietlacza { get; set; }
        public virtual DbSet<typy_maszyn_ziel> typy_maszyn_ziel { get; set; }
        public virtual DbSet<wizyty_platne> wizyty_platne { get; set; }
        public virtual DbSet<wyswietlacze> wyswietlaczes { get; set; }
        public virtual DbSet<zestawy_uprawowe> zestawy_uprawowe { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<aktywacje_odbiornika>()
                .Property(e => e.nr_zamowienia)
                .IsUnicode(false);

            modelBuilder.Entity<aktywacje_wyswietlacza>()
                .Property(e => e.nr_zamowienia)
                .IsUnicode(false);

            modelBuilder.Entity<ciagniki>()
                .Property(e => e.model)
                .IsUnicode(false);

            modelBuilder.Entity<ciagniki>()
                .Property(e => e.nr_seryjny)
                .IsUnicode(false);

            modelBuilder.Entity<gwarancje>()
                .Property(e => e.wartosc)
                .HasPrecision(19, 4);

            modelBuilder.Entity<klient>()
                .Property(e => e.imie)
                .IsUnicode(false);

            modelBuilder.Entity<klient>()
                .Property(e => e.kod_pocztowy)
                .IsUnicode(false);

            modelBuilder.Entity<klient>()
                .Property(e => e.adres)
                .IsUnicode(false);

            modelBuilder.Entity<klient>()
                .Property(e => e.nazwa_firmy)
                .IsUnicode(false);

            modelBuilder.Entity<klient>()
                .Property(e => e.nip)
                .IsUnicode(false);

            modelBuilder.Entity<klient>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<klient>()
                .Property(e => e.zwrot)
                .IsUnicode(false);

            modelBuilder.Entity<kombajny>()
                .Property(e => e.model)
                .IsUnicode(false);

            modelBuilder.Entity<kombajny>()
                .Property(e => e.nr_seryjny)
                .IsUnicode(false);

            modelBuilder.Entity<maszyny_zielonkowe>()
                .Property(e => e.model)
                .IsUnicode(false);

            modelBuilder.Entity<maszyny_zielonkowe>()
                .Property(e => e.nr_seryjny)
                .IsUnicode(false);

            modelBuilder.Entity<odbiorniki>()
                .Property(e => e.model)
                .IsUnicode(false);

            modelBuilder.Entity<odbiorniki>()
                .Property(e => e.sn_odbiornika)
                .IsUnicode(false);

            modelBuilder.Entity<opryskiwacze>()
                .Property(e => e.model)
                .IsUnicode(false);

            modelBuilder.Entity<opryskiwacze>()
                .Property(e => e.nr_seryjny)
                .IsUnicode(false);

            modelBuilder.Entity<pokazy>()
                .Property(e => e.imie)
                .IsUnicode(false);

            modelBuilder.Entity<pokazy>()
                .Property(e => e.nazwisko)
                .IsUnicode(false);

            modelBuilder.Entity<prod_ciagniki>()
                .Property(e => e.nazwa)
                .IsUnicode(false);

            modelBuilder.Entity<prod_ciagniki>()
                .HasMany(e => e.ciagnikis)
                .WithOptional(e => e.prod_ciagniki)
                .HasForeignKey(e => e.marka);

            modelBuilder.Entity<prod_kombajny>()
                .Property(e => e.nazwa)
                .IsUnicode(false);

            modelBuilder.Entity<prod_kombajny>()
                .HasMany(e => e.kombajnies)
                .WithOptional(e => e.prod_kombajny)
                .HasForeignKey(e => e.marka);

            modelBuilder.Entity<prod_opryskiwacze>()
                .Property(e => e.nazwa)
                .IsUnicode(false);

            modelBuilder.Entity<prod_opryskiwacze>()
                .HasMany(e => e.opryskiwaczes)
                .WithOptional(e => e.prod_opryskiwacze)
                .HasForeignKey(e => e.marka);

            modelBuilder.Entity<prod_rozsiewacze>()
                .Property(e => e.nazwa)
                .IsUnicode(false);

            modelBuilder.Entity<prod_rozsiewacze>()
                .HasMany(e => e.rozsiewaczes)
                .WithOptional(e => e.prod_rozsiewacze)
                .HasForeignKey(e => e.marka);

            modelBuilder.Entity<prod_siewniki>()
                .Property(e => e.nazwa)
                .IsUnicode(false);

            modelBuilder.Entity<prod_siewniki>()
                .HasMany(e => e.siewniki_pkt)
                .WithOptional(e => e.prod_siewniki)
                .HasForeignKey(e => e.marka);

            modelBuilder.Entity<prod_siewniki>()
                .HasMany(e => e.siewnikis)
                .WithOptional(e => e.prod_siewniki)
                .HasForeignKey(e => e.marka);

            modelBuilder.Entity<prod_zestawy_uprawowe>()
                .Property(e => e.nazwa)
                .IsUnicode(false);

            modelBuilder.Entity<prod_zestawy_uprawowe>()
                .HasMany(e => e.zestawy_uprawowe)
                .WithOptional(e => e.prod_zestawy_uprawowe)
                .HasForeignKey(e => e.marka);

            modelBuilder.Entity<prod_zielonkowe>()
                .Property(e => e.nazwa)
                .IsUnicode(false);

            modelBuilder.Entity<prod_zielonkowe>()
                .HasMany(e => e.maszyny_zielonkowe)
                .WithOptional(e => e.prod_zielonkowe)
                .HasForeignKey(e => e.marka);

            modelBuilder.Entity<rozsiewacze>()
                .Property(e => e.model)
                .IsUnicode(false);

            modelBuilder.Entity<rozsiewacze>()
                .Property(e => e.nr_seryjny)
                .IsUnicode(false);

            modelBuilder.Entity<siewniki>()
                .Property(e => e.model)
                .IsUnicode(false);

            modelBuilder.Entity<siewniki>()
                .Property(e => e.nr_seryjny)
                .IsUnicode(false);

            modelBuilder.Entity<siewniki_pkt>()
                .Property(e => e.model)
                .IsUnicode(false);

            modelBuilder.Entity<siewniki_pkt>()
                .Property(e => e.nr_seryjny)
                .IsUnicode(false);

            modelBuilder.Entity<typy_akt_odbiornika>()
                .Property(e => e.nazwa)
                .IsUnicode(false);

            modelBuilder.Entity<typy_akt_odbiornika>()
                .HasMany(e => e.aktywacje_odbiornika)
                .WithOptional(e => e.typy_akt_odbiornika)
                .HasForeignKey(e => e.typ_aktywacji);

            modelBuilder.Entity<typy_akt_wyswietlacza>()
                .Property(e => e.nazwa)
                .IsUnicode(false);

            modelBuilder.Entity<typy_akt_wyswietlacza>()
                .HasMany(e => e.aktywacje_wyswietlacza)
                .WithOptional(e => e.typy_akt_wyswietlacza)
                .HasForeignKey(e => e.nazwa_aktywacji);

            modelBuilder.Entity<typy_maszyn_ziel>()
                .Property(e => e.nazwa)
                .IsUnicode(false);

            modelBuilder.Entity<typy_maszyn_ziel>()
                .HasMany(e => e.maszyny_zielonkowe)
                .WithOptional(e => e.typy_maszyn_ziel)
                .HasForeignKey(e => e.typ);

            modelBuilder.Entity<wizyty_platne>()
                .Property(e => e.imie)
                .IsUnicode(false);

            modelBuilder.Entity<wizyty_platne>()
                .Property(e => e.nazwisko)
                .IsUnicode(false);

            modelBuilder.Entity<wizyty_platne>()
                .Property(e => e.wartosc)
                .HasPrecision(19, 4);

            modelBuilder.Entity<wyswietlacze>()
                .Property(e => e.model)
                .IsUnicode(false);

            modelBuilder.Entity<wyswietlacze>()
                .Property(e => e.nr_seryjny)
                .IsUnicode(false);

            modelBuilder.Entity<zestawy_uprawowe>()
                .Property(e => e.model)
                .IsUnicode(false);

            modelBuilder.Entity<zestawy_uprawowe>()
                .Property(e => e.nr_seryjny)
                .IsUnicode(false);
        }
    }
}
