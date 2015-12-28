namespace DBManager
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prod_ciagniki
    {
        public prod_ciagniki()
        {
            ciagnikis = new HashSet<ciagniki>();
        }

        [Key]
        public int id_producenta { get; set; }

        [Required]
        [StringLength(20)]
        public string nazwa { get; set; }

        public virtual ICollection<ciagniki> ciagnikis { get; set; }
    }
}
