namespace DBManager
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("odbiorniki")]
    public partial class odbiorniki
    {
        public odbiorniki()
        {
            aktywacje_odbiornika = new HashSet<aktywacje_odbiornika>();
        }

        [Key]
        public int id_odbiornika { get; set; }

        public int? id_klienta { get; set; }

        [Required]
        [StringLength(20)]
        public string model { get; set; }

        [Required]
        [StringLength(20)]
        public string sn_odbiornika { get; set; }

        public bool aktywacje { get; set; }

        public virtual ICollection<aktywacje_odbiornika> aktywacje_odbiornika { get; set; }

        public virtual klient klient { get; set; }
    }
}
