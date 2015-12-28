namespace DBManager
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prod_siewniki
    {
        public prod_siewniki()
        {
            siewniki_pkt = new HashSet<siewniki_pkt>();
            siewnikis = new HashSet<siewniki>();
        }

        [Key]
        public int id_producenta { get; set; }

        [Required]
        [StringLength(20)]
        public string nazwa { get; set; }

        public virtual ICollection<siewniki_pkt> siewniki_pkt { get; set; }

        public virtual ICollection<siewniki> siewnikis { get; set; }
    }
}
