namespace DBManager
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prod_rozsiewacze
    {
        public prod_rozsiewacze()
        {
            rozsiewaczes = new HashSet<rozsiewacze>();
        }

        [Key]
        public int id_producenta { get; set; }

        [Required]
        [StringLength(20)]
        public string nazwa { get; set; }

        public virtual ICollection<rozsiewacze> rozsiewaczes { get; set; }
    }
}
