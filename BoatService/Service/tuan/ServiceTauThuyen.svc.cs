using BoatService.db;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BoatService.Service.tuan
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceTauThuyen" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceTauThuyen.svc or ServiceTauThuyen.svc.cs at the Solution Explorer and start debugging.
    public class ServiceTauThuyen : IServiceTauThuyen
    {
      
        public Tuan_dv_TauThuyenModel GetTauThuyenById(string ma)
        {
            DataTable dt = Tuan_dv_DataAccess.ExecQuery("Select * from tauthuyen where ma='" + ma+"'").Tables[0];
            Tuan_dv_TauThuyenModel sv = new Tuan_dv_TauThuyenModel();
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];

                sv.ma = dr[0].ToString();
                sv.tentau = dr[1].ToString();
                sv.MMSI = dr[2].ToString();
                sv.maloaitau = dr[3].ToString();
                sv.taitrong = dr[4].ToString() == "" ? -1 : int.Parse(dr[4].ToString());
                sv.maquocgia = dr[5].ToString();
                sv.image = dr[6].ToString();              
            }
            return sv;
        }

        public DataSet layDanhSachTau()
        {
            return Tuan_dv_DataAccess.ExecQuery("select t.image, t.ma as MaTau,tentau as TenTau,MMSI,l.tenloaitau as LoaiTau,taitrong,q.tenquocgia from tauthuyen t left join loaitau l on t.maloaitau = l.ma left join quocgia q on t.maquocgia = q.ma");
        }
        public DataSet layDanhSachLoaiTau()
        {
            return Tuan_dv_DataAccess.ExecQuery("select ma,tenloaitau from loaitau");
        }
        public DataSet layDanhSachQuocGia()
        {
            return Tuan_dv_DataAccess.ExecQuery("select * from quocgia");
        }

        public int SuaTauThuyen(Tuan_dv_TauThuyenModel tau)
        {
            SqlParameter[] sp = new SqlParameter[7];

            sp[0] = new SqlParameter("@ma", SqlDbType.VarChar, 50);
            sp[1] = new SqlParameter("@maloaitau", SqlDbType.VarChar);
            sp[2] = new SqlParameter("@maquocgia", SqlDbType.VarChar, 50);
            sp[3] = new SqlParameter("@MMSI", SqlDbType.VarChar, 50);
            sp[4] = new SqlParameter("@taitrong", SqlDbType.BigInt, 50);
            sp[5] = new SqlParameter("@tentau", SqlDbType.VarChar, 50);
            sp[6] = new SqlParameter("@image", SqlDbType.VarChar, 150);

            sp[0].Value = tau.ma;
            sp[1].Value = tau.maloaitau;
            sp[2].Value = tau.maquocgia;
            sp[3].Value = tau.MMSI;
            sp[4].Value = tau.taitrong;
            sp[5].Value = tau.tentau;
            sp[6].Value = tau.image;

            return Tuan_dv_DataAccess.ExecNonQuery("update tauthuyen set maloaitau=@maloaitau,maquocgia=@maquocgia,MMSI=@MMSI,taitrong=@taitrong,tentau=@tentau,image=@image where ma=@ma", sp);
        }

        public int ThemTauThuyen(Tuan_dv_TauThuyenModel tau)
        {
            SqlParameter[] sp = new SqlParameter[7];

            sp[0] = new SqlParameter("@ma", SqlDbType.VarChar, 50);
            sp[1] = new SqlParameter("@maloaitau", SqlDbType.VarChar);
            sp[2] = new SqlParameter("@maquocgia", SqlDbType.VarChar, 50);
            sp[3] = new SqlParameter("@MMSI", SqlDbType.VarChar, 50);
            sp[4] = new SqlParameter("@taitrong", SqlDbType.BigInt, 50);
            sp[5] = new SqlParameter("@tentau", SqlDbType.VarChar, 50);
            sp[6] = new SqlParameter("@image", SqlDbType.VarChar, 150);

            sp[0].Value = tau.ma;
            sp[1].Value = tau.maloaitau;
            sp[2].Value = tau.maquocgia;
            sp[3].Value = tau.MMSI;
            sp[4].Value = tau.taitrong;
            sp[5].Value = tau.tentau;
            sp[6].Value = tau.image;
            
            return Tuan_dv_DataAccess.ExecNonQuery("insert into tauthuyen values(@ma,@tentau,@MMSI,@maloaitau,@taitrong,@maquocgia,@image)", sp);
        }

        public int XoaTauThuyen(string maTau)
        {
            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("@ma", SqlDbType.VarChar, 50);
            sp[0].Value = maTau;
            SqlParameter[] sp1 = new SqlParameter[1];
            sp1[0] = new SqlParameter("@ma", SqlDbType.VarChar, 50);
            sp1[0].Value = maTau;
            return Tuan_dv_DataAccess.ExecNonQuery("delete tauthuyen where ma=@ma", sp)+ Tuan_dv_DataAccess.ExecNonQuery("delete hanhtrinh where matauthuyen=@ma", sp1);
        }
    }
}
