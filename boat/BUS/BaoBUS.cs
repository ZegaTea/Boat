using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using boat.BaoService;
using System.Data;

namespace boat.BUS
{
    class BaoBUS
    {
        private BaoServiceClient baoService = new BaoServiceClient();
        public int addToHanhtrinhBao(string ma)
        {
            return baoService.addToHanhtrinhBao(ma);
        }

        public void addToVitriBao(int maht, double vi, double ki, long dt)
        {
            baoService.addToVitriBao(maht, vi, ki, dt);
        }

        public DataSet getListBao()
        {
            return baoService.getListBao();
        }

        public void huyHanhtrinhBao(int ma)
        {
            baoService.huyHanhtrinhBao(ma);
        }

        public DataSet getVitriBao(int maht)
        {
            return baoService.getVitriBao(maht);
        }

        public DataSet getListNewestBao()
        {
            return baoService.getListNewestBao();
        }

        public DataSet layVitriCuoiAll()
        {
            return baoService.layVitriCuoiAll();
        }
    }
}
