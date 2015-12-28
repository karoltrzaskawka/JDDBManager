namespace DBManager
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class typy_akt_odbiornika
    {
        public typy_akt_odbiornika()
        {
            aktywacje_odbiornika = new HashSet<aktywacje_odbiornika>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(20)]
        public string nazwa { get; set; }

        public virtual ICollection<aktywacje_odbiornika> aktywacje_odbiornika { get; set; }
    }
}
