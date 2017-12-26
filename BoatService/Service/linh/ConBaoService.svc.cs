using BoatService.db;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BoatService.Service.linh
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ConBaoService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ConBaoService.svc or ConBaoService.svc.cs at the Solution Explorer and start debugging.
    public class ConBaoService : IConBaoService
    {
        private ConnectDB connect = new ConnectDB();


        public DataSet layDanhSachBao()
        {
            string sqlQuery = @"select * from ConBao";

            DataSet dsConBao = connect.GetDataSet(sqlQuery, "dsConBao");

            return dsConBao;
        }

        public DataSet layTinhTrang()
        {
            string sqlQuery = @"select ma, tinhTrang from TinhTrang";

            DataSet dsTinhTrang = connect.GetDataSet(sqlQuery, "tinhtrang");

            return dsTinhTrang;
        }

        
        public bool suaViTriBao(int ma, float viDo, float kinhDo, long thoiGian, float vanToc)
        {
            List<SqlParameter> listParams = new List<SqlParameter>();
            int ret = 0;

            SqlParameter param;

            param = new SqlParameter("@ma", SqlDbType.Int);
            param.Value = ma;
            listParams.Add(param);

            param = new SqlParameter("@viDo", SqlDbType.Float);
            param.Value = viDo;
            listParams.Add(param);

            param = new SqlParameter("@kinhDo", SqlDbType.Float);
            param.Value = kinhDo;
            listParams.Add(param);

            param = new SqlParameter("@thoiGian", SqlDbType.BigInt);
            param.Value = thoiGian;
            listParams.Add(param);

            param = new SqlParameter("@vanToc", SqlDbType.Float);
            param.Value = vanToc;
            listParams.Add(param);

            ret = connect.doStoredProceduce("suaViTriBao", listParams.ToArray());
            if (ret < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool themConBao(string ten, string ghiChu, long thoiGianHinhThanh, int maTinhTrang, int trangThai)
        {
            List<SqlParameter> listParams = new List<SqlParameter>();
            int ret = 0;

            SqlParameter param;

            param = new SqlParameter("@ma", SqlDbType.VarChar);
            param.Value = "CB_"+thoiGianHinhThanh;
            listParams.Add(param);

            param = new SqlParameter("@tenConBao", SqlDbType.NVarChar);
            param.Value = ten;
            listParams.Add(param);

            param = new SqlParameter("@ghiChu", SqlDbType.NVarChar);
            param.Value = ghiChu;
            listParams.Add(param);

            param = new SqlParameter("@thoiGianHinhThanh", SqlDbType.BigInt);
            param.Value = thoiGianHinhThanh;
            listParams.Add(param);

            param = new SqlParameter("@maTinhTrang", SqlDbType.Int);
            param.Value = maTinhTrang;
            listParams.Add(param);

            param = new SqlParameter("@trangThai", SqlDbType.Int);
            param.Value = maTinhTrang;
            listParams.Add(param);

            ret = connect.doStoredProceduce("themConBao", listParams.ToArray());
            if (ret < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool themHanhTrinhBao(string maConBao, int trangThai)
        {

            string sqlCommand = "insert into HanhTrinhBao(maConbao, trangThai) values('" + maConBao + "'," + trangThai + ")";
            List<SqlParameter> listParams = new List<SqlParameter>();
            int ret = 0;

            SqlParameter param;

            param = new SqlParameter("@maConBao", SqlDbType.VarChar);
            param.Value = maConBao;
            listParams.Add(param);

            param = new SqlParameter("@trangThai", SqlDbType.NVarChar);
            param.Value = trangThai;
            listParams.Add(param);

            ret = connect.doSQL(sqlCommand, listParams.ToArray());
            if (ret < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool themViTriBao(int maHanhTrinh, float viDo, float kinhDo, long thoiGian, float vanToc)
        {
            List<SqlParameter> listParams = new List<SqlParameter>();
            int ret = 0;

            SqlParameter param;

            param = new SqlParameter("@maHanhTrinh", SqlDbType.Int);
            param.Value = maHanhTrinh;
            listParams.Add(param);

            param = new SqlParameter("@viDo", SqlDbType.Float);
            param.Value = viDo;
            listParams.Add(param);

            param = new SqlParameter("@kinhDo", SqlDbType.Float);
            param.Value = kinhDo;
            listParams.Add(param);

            param = new SqlParameter("@thoiGian", SqlDbType.BigInt);
            param.Value = thoiGian;
            listParams.Add(param);

            param = new SqlParameter("@vanToc", SqlDbType.Float);
            param.Value = vanToc;
            listParams.Add(param);

            ret = connect.doStoredProceduce("themVitriBao", listParams.ToArray());
            if (ret < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool xoaConBao(string ma)
        {
            bool state = true;

            string query = @"delete conBao 
                            where ma = " + ma;
            state = connect.GetStatusExcuteNonQuery(query);

            return state;
        }

        public bool xoaHanhtrinhBao(int maHanhTrinh)
        {
            List<SqlParameter> listParams = new List<SqlParameter>();
            int ret = 0;

            SqlParameter param;

            param = new SqlParameter("@maHanhTrinh", SqlDbType.Int);
            param.Value = maHanhTrinh;
            listParams.Add(param);

            ret = connect.doStoredProceduce("xoaHanhTrinhBao", listParams.ToArray());
            if (ret < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool xoaViTriBao(int ma)
        {
            bool state = true;

            string query = @"delete vitriBao 
                            where ma = " + ma;
            state = connect.GetStatusExcuteNonQuery(query);

            return state;

        }

        public DataSet layViTriBao(int maHanhTrinh)
        {
            string sqlQuery = @"select ma, kinhdo, vido, thoigian, vantoc from vitribao where maHanhTrinh = "+maHanhTrinh;

            DataSet dsViTri = connect.GetDataSet(sqlQuery, "dsViTriBao");

            return dsViTri;
        }

        public DataSet layDSHanhTrinh(String maConBao)
        {
            string sqlQuery = @"select ma, trangthai from hanhtrinhbao where maConBao = '" + maConBao+"'";

            DataSet dsHanhTrinh = connect.GetDataSet(sqlQuery, "dsHanhTrinh");

            return dsHanhTrinh;
        }
    }
}
