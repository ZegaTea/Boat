using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BoatService.db;

namespace BoatService.Service.tu
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TauthuyenService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select TauthuyenService.svc or TauthuyenService.svc.cs at the Solution Explorer and start debugging.
    public class TauthuyenService : ITauthuyenService
    {
        ConnectDB db = new ConnectDB();

        public bool guiToaDo(int mahanhtrinh, double vido, double kinhdo, long time)
        {
            bool state = true;
            string query = @"insert into vitritauthuyen(mahanhtrinh, vido, kinhdo, thoigian) 
                            values(" + mahanhtrinh + ", " + vido + ", " + kinhdo + ", " + time + ")";
            state = db.GetStatusExcuteNonQuery(query);

            return state;
        }

        public DataSet layDanhSachTau()
        {
            string query = @"select ma, tentau from tauthuyen";

            DataSet set = db.GetDataSet(query, "tau");

            return set;
        }

        public bool themHanhtrinh(string ma)
        {
            bool state = true;
            string query = @"insert into hanhtrinh(matauthuyen, trangthai)
                            values('" + ma + "', 1)";
            state = db.GetStatusExcuteNonQuery(query);
            return state;
        }

        public int layMaHanhTrinh()
        {
            string query = @"select max(ma) from hanhtrinh";

            //string query1 = @"SELECT IDENT_CURRENT('hanhtrinh')";
            int id = Convert.ToInt32(db.GetValue(query));

            return id;
        }

        public bool huyHanhTrinh(int maHanhTrinh)
        {
            bool state = true;

            string query = @"update hanhtrinh 
                            set trangthai = 0
                            where ma = " + maHanhTrinh;
            state = db.GetStatusExcuteNonQuery(query);

            return state;
        }
        public DataSet getListNewestBoat()
        {
            string query = @"select t.mahanhtrinh, t.matauthuyen, t.tentau, t.MMSI, v.vido, v.kinhdo, t.thoigian
                            from( select h.mahanhtrinh, h.matauthuyen ,t.tentau, t.MMSI,max(v.thoigian) as thoigian
                            from (select max(h.ma) as mahanhtrinh, h.matauthuyen
                            from hanhtrinh h
                            where h.trangthai = 0 and h.matauthuyen not in (select h1.matauthuyen from hanhtrinh h1 where trangthai = 1)
                            group by h.matauthuyen) h
                            join vitritauthuyen v on v.mahanhtrinh = h.mahanhtrinh
                            join tauthuyen t on h.matauthuyen = t.ma
                            group by h.mahanhtrinh, h.matauthuyen ,t.tentau, t.MMSI) t
                            join vitritauthuyen v on t.thoigian = v.thoigian and t.mahanhtrinh = v.mahanhtrinh";
            DataSet ds = db.GetDataSet(query, "tauAll");
            return ds;
        }

        public DataSet layHanhTrinh(int maHanhTrinh)
        {
            string query = @"select t.ma, t.tentau, t.MMSI, v.vido, v.kinhdo, v.thoigian 
                            from vitritauthuyen v
                            join hanhtrinh h on v.mahanhtrinh = h.ma
                            join tauthuyen t on t.ma = h.matauthuyen
                            where v.mahanhtrinh = " + maHanhTrinh + " order by v.thoigian";
            DataSet ds = db.GetDataSet(query, "hanhtrinh");
            return ds;
        }

        public DataSet layDanhSachTau_v2()
        {
            string query = @"select  t.ma, t.tentau, t.MMSI from tauthuyen t";

            DataSet ds = db.GetDataSet(query, "tau_v2");
            return ds;
        }

        public DataSet layVitriFull(string matau)
        {
            string query = @"select h.ma as mahanhtrinh,  v.vido, v.kinhdo, v.thoigian
                            from vitritauthuyen v
                            join hanhtrinh h on h.ma = v.mahanhtrinh
                            where h.matauthuyen = '" + matau + "' order by v.thoigian";
            DataSet ds = db.GetDataSet(query, "vitri");
            return ds;
        }

        public DataSet layChitietTau(string matau)
        {
            string query = @"select t.ma, t.tentau, t.MMSI, q.tenquocgia, l.tenloaitau, t.taitrong
                            from tauthuyen t
                            join quocgia q on t.maquocgia = q.ma
                            join loaitau l on t.maloaitau = l.ma
                            where t.ma = '" + matau + "'";
            DataSet ds = db.GetDataSet(query, "chitietTau");
            return ds;
        }

        public DataSet layVitriCuoi(string matau)
        {
            string query = @"select ht.matauthuyen,vt.vido, vt.kinhdo
                            from (select ht.matauthuyen, max(vt.thoigian) as thoigian
                            from vitritauthuyen vt
                            join hanhtrinh ht on ht.ma = vt.mahanhtrinh
                            group by ht.matauthuyen) t
                            join vitritauthuyen vt on vt.thoigian = t.thoigian
                            join hanhtrinh ht on vt.mahanhtrinh = ht.ma 
                            where ht.matauthuyen = '" + matau + "'";
            return db.GetDataSet(query, "VitriCuoi");
        }

        public DataSet layVitriCuoiAll()
        {
            string query = @"select ht.matauthuyen as ma ,vt.vido, vt.kinhdo, vt.thoigian
                            from (select ht.matauthuyen, max(vt.thoigian) as thoigian
                            from vitritauthuyen vt
                            join hanhtrinh ht on ht.ma = vt.mahanhtrinh
                            group by ht.matauthuyen) t
                            join vitritauthuyen vt on vt.thoigian = t.thoigian
                            join hanhtrinh ht on vt.mahanhtrinh = ht.ma";

            return db.GetDataSet(query, "tauCuoiAll");
        }

        public DataSet getListTauDanger(string taus)
        {
            string query = @"select t.ma, t.tentau, N'Cảnh báo' as canhbao 
                            from tauthuyen t
                            where t.ma in (" + taus + ")";
            return db.GetDataSet(query, "tauDanger");
        }
    }
}
