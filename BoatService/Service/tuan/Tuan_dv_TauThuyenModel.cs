using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BoatService
{ 
    [DataContract]
    public class Tuan_dv_TauThuyenModel
    {
        [DataMember]
        public string ma { get; set; }

        [DataMember]
        public string tentau { get; set; }

        [DataMember]
        public string MMSI { get; set; }

        [DataMember]
        public string maloaitau { get; set; }

        [DataMember]
        public long taitrong { get; set; }

        [DataMember]
        public string maquocgia { get; set; }

        [DataMember]
        public string image { get; set; }
    }
}