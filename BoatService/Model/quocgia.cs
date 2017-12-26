namespace BoatService.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("quocgia")]
    public partial class quocgia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public quocgia()
        {
            tauthuyens = new HashSet<tauthuyen>();
        }

        [Key]
        [StringLength(50)]
        public string ma { get; set; }

        [StringLength(50)]
        public string tenquocgia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tauthuyen> tauthuyens { get; set; }
    }
}
