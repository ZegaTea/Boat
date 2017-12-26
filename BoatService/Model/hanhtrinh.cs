namespace BoatService.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("hanhtrinh")]
    public partial class hanhtrinh
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public hanhtrinh()
        {
            vitritauthuyens = new HashSet<vitritauthuyen>();
        }

        [Key]
        public int ma { get; set; }

        [StringLength(50)]
        public string matauthuyen { get; set; }

        public int? trangthai { get; set; }

        public virtual tauthuyen tauthuyen { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<vitritauthuyen> vitritauthuyens { get; set; }
    }
}
