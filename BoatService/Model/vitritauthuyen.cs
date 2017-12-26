namespace BoatService.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vitritauthuyen")]
    public partial class vitritauthuyen
    {
        [Key]
        public int ma { get; set; }

        public int? mahanhtrinh { get; set; }

        public double? vido { get; set; }

        public double? kinhdo { get; set; }

        public long? thoigian { get; set; }

        public virtual hanhtrinh hanhtrinh { get; set; }
    }
}
