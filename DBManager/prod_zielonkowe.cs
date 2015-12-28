namespace DBManager
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prod_zielonkowe
    {
        public prod_zielonkowe()
        {
            maszyny_zielonkowe = new HashSet<maszyny_zielonkowe>();
        }

        [Key]
        public int id_producenta { get; set; }

        [Required]
        [StringLength(20)]
        public string nazwa { get; set; }

        public virtual ICollection<maszyny_zielonkowe> maszyny_zielonkowe { get; set; }
    }
}
