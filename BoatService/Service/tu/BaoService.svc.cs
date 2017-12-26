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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "BaoService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select BaoService.svc or BaoService.svc.cs at the Solution Explorer and start debugging.
    public class BaoService : IBaoService
    {
        private ConnectDB db = new ConnectDB();

        public int addToHanhtrinhBao(string ma)
        {
            string query = @"insert into hanhtrinhbao(maconbao, trangthai) 
                             values ('" + ma + "', 1)";
            db.ExcuteNonQuery(query);
            string queryMAX = @"select MAX(ma) from hanhtrinhbao";
            int maht = Convert.ToInt32(db.GetValue(queryMAX));
            return maht;
        }

        public void addToVitriBao(int maht, double vi, double ki, long dt)
        {
            string query = @"insert into vitribao(mahanhtrinh, vido, kinhdo, thoigian) 
                            values(" + maht + ", " + vi + ", " + ki + ", " + dt + ")";
            db.ExcuteNonQuery(query);
        }

        public void DoWork()
        {
        }

        public DataSet getListBao()
        {
            string query = @"select ma, tenconbao from conbao";
            DataSet dt = db.GetDataSet(query, "tenbao");
            return dt;
        }

        public void huyHanhtrinhBao(int ma)
        {
            string query = @"update hanhtrinhbao 
                            set trangthai = 0 
                            where ma = " + ma + "";
            db.ExcuteNonQuery(query);
        }

        public DataSet getVitriBao(int maht)
        {
            string query = @"select cb.ma, cb.tenconbao, tt.tinhtrang, vtb.vido, vtb.kinhdo, vtb.thoigian
                            from hanhtrinhbao htb
                            join vitribao vtb on htb.ma = vtb.mahanhtrinh
                            join conbao cb on cb.ma = htb.maconbao
                            join tinhtrang tt on tt.ma = cb.matinhtrang
                            where htb.ma = " + maht + " order by vtb.thoigian";
            DataSet ds = db.GetDataSet(query, "vtb");
            return ds;
        }

        public DataSet getListNewestBao()
        {
            string query = @"select cb.ma, cb.tenconbao ,vtb.vido, vtb.kinhdo, g.thoigian
                            from (select htb.maconbao , max(vtb.thoigian) as thoigian
                            from vitribao vtb
                            join hanhtrinhbao htb on htb.ma = vtb.mahanhtrinh
                            group by htb.maconbao) g
                            join vitribao vtb on g.thoigian = vtb.thoigian
                            join hanhtrinhbao htb on htb.ma = vtb.mahanhtrinh
                            join conbao cb on cb.ma = htb.maconbao";
            return db.GetDataSet(query, "baoAll");
        }

        public DataSet layVitriCuoiAll()
        {
            string query = @"select htb.maconbao as ma,vtb.vido, vtb.kinhdo, g.thoigian
                            from (select htb.maconbao , max(vtb.thoigian) as thoigian
                            from vitribao vtb
                            join hanhtrinhbao htb on htb.ma = vtb.mahanhtrinh
                            group by htb.maconbao) g
                            join vitribao vtb on g.thoigian = vtb.thoigian
                            join hanhtrinhbao htb on htb.ma = vtb.mahanhtrinh";
            return db.GetDataSet(query, "baoCuoiAll");
        }
    }
}
