namespace BoatService.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("hanhtrinhbao")]
    public partial class hanhtrinhbao
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public hanhtrinhbao()
        {
            vitribaos = new HashSet<vitribao>();
        }

        [Key]
        public int ma { get; set; }

        [StringLength(50)]
        public string maconbao { get; set; }

        public int? trangthai { get; set; }

        public virtual conbao conbao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<vitribao> vitribaos { get; set; }
    }
}
