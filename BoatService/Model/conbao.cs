namespace BoatService.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("conbao")]
    public partial class conbao
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public conbao()
        {
            hanhtrinhbaos = new HashSet<hanhtrinhbao>();
        }

        [Key]
        [StringLength(50)]
        public string ma { get; set; }

        [StringLength(50)]
        public string tenconbao { get; set; }

        public string ghichu { get; set; }

        public long? thoigianhinhthanh { get; set; }

        public int? matinhtrang { get; set; }

        public virtual tinhtrang tinhtrang { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hanhtrinhbao> hanhtrinhbaos { get; set; }
    }
}
