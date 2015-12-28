namespace DBManager
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prod_opryskiwacze
    {
        public prod_opryskiwacze()
        {
            opryskiwaczes = new HashSet<opryskiwacze>();
        }

        [Key]
        public int id_producenta { get; set; }

        [Required]
        [StringLength(20)]
        public string nazwa { get; set; }

        public virtual ICollection<opryskiwacze> opryskiwaczes { get; set; }
    }
}
