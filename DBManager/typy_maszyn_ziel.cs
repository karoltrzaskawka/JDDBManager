namespace DBManager
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class typy_maszyn_ziel
    {
        public typy_maszyn_ziel()
        {
            maszyny_zielonkowe = new HashSet<maszyny_zielonkowe>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(30)]
        public string nazwa { get; set; }

        public virtual ICollection<maszyny_zielonkowe> maszyny_zielonkowe { get; set; }
    }
}
