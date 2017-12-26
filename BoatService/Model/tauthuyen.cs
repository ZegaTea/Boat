namespace BoatService.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tauthuyen")]
    public partial class tauthuyen
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tauthuyen()
        {
            hanhtrinhs = new HashSet<hanhtrinh>();
        }

        [Key]
        [StringLength(50)]
        public string ma { get; set; }

        [StringLength(50)]
        public string tentau { get; set; }

        [StringLength(50)]
        public string MMSI { get; set; }

        [StringLength(50)]
        public string maloaitau { get; set; }

        public long? taitrong { get; set; }

        [StringLength(50)]
        public string maquocgia { get; set; }

        public string image { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hanhtrinh> hanhtrinhs { get; set; }

        public virtual loaitau loaitau { get; set; }

        public virtual quocgia quocgia { get; set; }
    }
}
