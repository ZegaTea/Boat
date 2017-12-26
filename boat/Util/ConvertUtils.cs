using boat.Model.DTO;
using BoatService.Service.linh;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boat.Util
{
    class ConvertUtils
    {
        public List<TauVItriDTO> convertTauVitri(DataTable dt)
        {
            List<TauVItriDTO> lst = new List<TauVItriDTO>();
            //lst = dt.Rows.OfType<TauVItriDTO>().ToList();
            foreach (DataRow dr in dt.Rows)
            {
                TauVItriDTO tau = new TauVItriDTO();
                tau.mahanhtrinh = dr.Field<int>("mahanhtrinh");
                tau.matauthuyen = dr.Field<string>("matauthuyen");
                tau.tentau = dr.Field<string>("tentau");
                tau.MMSI = dr.Field<string>("MMSI");
                tau.vido = dr.Field<double>("vido");
                tau.kinhdo = dr.Field<double>("kinhdo");
                tau.thoigian = dr.Field<long>("thoigian");
                lst.Add(tau);
            }

            return lst;
        }

        public List<HanhtrinhDTO> convertHanhtrinh(DataTable dt)
        {
            List<HanhtrinhDTO> ls = new List<HanhtrinhDTO>();
            foreach(DataRow dr in dt.Rows)
            {
                HanhtrinhDTO ht = new HanhtrinhDTO();
                ht.matau = dr.Field<string>("ma");
                ht.tentau = dr.Field<string>("tentau");
                ht.MMSI = dr.Field<string>("MMSI");
                ht.vido = dr.Field<double>("vido");
                ht.kinhdo = dr.Field<double>("kinhdo");
                ht.thoigian = dr.Field<long>("thoigian");
                ls.Add(ht);
            }
            return ls;
        }

        public List<VitriDTO> convertVitri(DataTable dt)
        {
            List<VitriDTO> ls = new List<VitriDTO>();
            foreach(DataRow dr in dt.Rows)
            {
                VitriDTO vt = new VitriDTO();
                vt.mahanhtrinh = dr.Field<int>("mahanhtrinh");
                vt.vido = dr.Field<double>("vido");
                vt.kinhdo = dr.Field<double>("kinhdo");
                vt.thoigian = dr.Field<long>("thoigian");
                ls.Add(vt);
            }

            return ls;
        }

        public TauChitietDTO convertTauChitiet(DataTable dt)
        {
            TauChitietDTO t = new TauChitietDTO();
            t.ma = dt.Rows[0].Field<string>("ma");
            t.tentau = dt.Rows[0].Field<string>("tentau");
            t.MMSI = dt.Rows[0].Field<string>("MMSI");
            t.tenloaitau = dt.Rows[0].Field<string>("tenloaitau");
            t.tenquocgia = dt.Rows[0].Field<string>("tenquocgia");
            t.taitrong = dt.Rows[0].Field<long>("taitrong");

            return t;
        }

        public List<BaoVitriDTO> convertBaoVitri(DataTable dt)
        {
            List<BaoVitriDTO> result = new List<BaoVitriDTO>();
            foreach (DataRow dr in dt.Rows)
            {
                BaoVitriDTO bao = new BaoVitriDTO();
                bao.ma = dr.Field<string>("ma");
                bao.tenbao = dr.Field<string>("tenconbao");
                bao.vido = dr.Field<double>("vido");
                bao.kinhdo = dr.Field<double>("kinhdo");
                bao.thoigian = dr.Field<long>("thoigian");
                try
                {
                    bao.trangthai = dr.Field<string>("trangthai");
                } catch(Exception ex)
                {
                    bao.trangthai = "null";
                }
                result.Add(bao);
            }
            return result;
        }

        public List<PairDTO> convertPair(DataTable dt)
        {
            List<PairDTO> result = new List<PairDTO>();
            foreach (DataRow dr in dt.Rows)
            {
                PairDTO pair = new PairDTO();
                pair.ma = dr.Field<string>("ma");
                pair.vido = dr.Field<double>("vido");
                pair.kinhdo = dr.Field<double>("kinhdo");
                pair.thoigian = dr.Field<long>("thoigian");
                result.Add(pair);
            }
            return result;
        }

        public static List<ViTriBaoDTO> convertViTriBao(DataTable dt)
        {
            List<ViTriBaoDTO> lst = new List<ViTriBaoDTO>();
            foreach (DataRow dr in dt.Rows)
            {
                ViTriBaoDTO viTri = new ViTriBaoDTO();
                viTri.vido = dr.Field<double>("vido");
                viTri.kinhdo = dr.Field<double>("kinhdo");
                viTri.vanToc = dr.Field<double>("vantoc");
                viTri.thoigian = dr.Field<long>("thoigian");
                lst.Add(viTri);
            }

            return lst;
        }
    }
}
