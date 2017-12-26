using boat.TauService;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boat.BUS
{
    class TauthuyenBUS
    {
        private TauthuyenServiceClient tauSerivce = null;
        public TauthuyenBUS()
        {
            tauSerivce = new TauthuyenServiceClient();
        }

        public bool guiToaDo(int id, double vido, double kinhdo, long time)
        {
            return tauSerivce.guiToaDo(id, vido, kinhdo, time);
        }
        public bool themHanhtrinh(string matauthuyen)
        {
            return tauSerivce.themHanhtrinh(matauthuyen);
        }

        public DataSet layDanhSachTau()
        {
            return tauSerivce.layDanhSachTau();
        }

        public int layMaHanhTrinh()
        {
            return (int)tauSerivce.layMaHanhTrinh();
        }

        public bool huyHanhTrinh(int maHanhTrinh)
        {
            return tauSerivce.huyHanhTrinh(maHanhTrinh);
        }

        public DataSet danhSachTau()
        {
            return tauSerivce.getListNewestBoat();
        }

        public DataSet layHanhTrinh(int maHanhTrinh)
        {
            return tauSerivce.layHanhTrinh(maHanhTrinh);
        }

        public DataSet layVitriCuoi(string matau)
        {
            return tauSerivce.layVitriCuoi(matau);
        }

        public DataSet layVitriCuoiAll()
        {
            return tauSerivce.layVitriCuoiAll();
        }

        public DataSet getListTauDanger(string taus)
        {
            return tauSerivce.getListTauDanger(taus);
        }
    }
}
