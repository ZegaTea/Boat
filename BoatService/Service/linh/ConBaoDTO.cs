using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BoatService.Service.linh
{
    [DataContract]
    public class ConBaoDTO
    {
        [DataMember]
        public string ma { get; set; }

        [DataMember]
        public string ten { get; set; }

        [DataMember]
        public string ghiChu { get; set; }

        [DataMember]
        public long thoiGianHinhThanh { get; set; }

        [DataMember]
        public int maTinhTrang { get; set; }

    }
}