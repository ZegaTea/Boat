namespace BoatService.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vitribao")]
    public partial class vitribao
    {
        [Key]
        public int ma { get; set; }

        public int? mahanhtrinh { get; set; }

        public double? vido { get; set; }

        public double? kinhdo { get; set; }

        public long? thoigian { get; set; }

        public double? vantoc { get; set; }

        public virtual hanhtrinhbao hanhtrinhbao { get; set; }
    }
}
