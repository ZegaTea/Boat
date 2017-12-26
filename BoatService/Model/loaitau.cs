namespace BoatService.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("loaitau")]
    public partial class loaitau
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public loaitau()
        {
            tauthuyens = new HashSet<tauthuyen>();
        }

        [Key]
        [StringLength(50)]
        public string ma { get; set; }

        [StringLength(50)]
        public string tenloaitau { get; set; }

        [StringLength(50)]
        public string kieutau { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tauthuyen> tauthuyens { get; set; }
    }
}
