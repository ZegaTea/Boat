using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using BoatService.db;
using BoatService.Model;

namespace BoatService.Service.dien
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "LoaiTauService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select LoaiTauService.svc or LoaiTauService.svc.cs at the Solution Explorer and start debugging.
    public class LoaiTauService : ILoaiTauService
    {
        ConnectDB db = new ConnectDB();

        public DataSet getListTypesShip1()
        {
            string query = @"select * from loaitau";
            return db.GetDataSet(query, "loaitau");
        }


        public int InsertTypesShip(loaitau _loaitau)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@maloaitau", _loaitau.ma),
                new SqlParameter("@tenloaitau", _loaitau.tenloaitau),
                new SqlParameter("@kieutau", _loaitau.kieutau),
            };
            return db.doStoredProceduce("themloaitau", para);
        }


        public int UpdateTypesShip(loaitau _loaitau)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@IDShipType", _loaitau.ma),
                new SqlParameter("@NameShipType", _loaitau.tenloaitau),
                new SqlParameter("@ShipType", _loaitau.kieutau),
            };
            return db.doStoredProceduce("updateShipType", para);
        }
    }
}
