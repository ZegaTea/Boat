using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BoatService.Service.tuan
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceTauThuyen" in both code and config file together.
    [ServiceContract]
    public interface IServiceTauThuyen
    {
        [OperationContract]
        Tuan_dv_TauThuyenModel GetTauThuyenById(string ma);

        [OperationContract]
        int ThemTauThuyen(Tuan_dv_TauThuyenModel tau);

        [OperationContract]
        int SuaTauThuyen(Tuan_dv_TauThuyenModel tau);

        [OperationContract]
        DataSet layDanhSachTau();
        [OperationContract]
        DataSet layDanhSachLoaiTau();
        [OperationContract]
        DataSet layDanhSachQuocGia();

        [OperationContract]
        int XoaTauThuyen(string maTau);
    }
}
