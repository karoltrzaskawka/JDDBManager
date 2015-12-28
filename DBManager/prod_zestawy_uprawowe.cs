namespace DBManager
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prod_zestawy_uprawowe
    {
        public prod_zestawy_uprawowe()
        {
            zestawy_uprawowe = new HashSet<zestawy_uprawowe>();
        }

        [Key]
        public int id_producenta { get; set; }

        [Required]
        [StringLength(20)]
        public string nazwa { get; set; }

        public virtual ICollection<zestawy_uprawowe> zestawy_uprawowe { get; set; }
    }
}
