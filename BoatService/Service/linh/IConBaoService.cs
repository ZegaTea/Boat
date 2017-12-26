using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BoatService.Service.linh
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IConBaoService" in both code and config file together.
    [ServiceContract]
    public interface IConBaoService
    {
        [OperationContract]
        DataSet layDanhSachBao();

        [OperationContract]
        bool themConBao(String ten, String ghiChu, long thoiGianHinhThanh, int maTinhTrang, int trangThai);

        [OperationContract]
        bool xoaConBao(String ma);

        [OperationContract]
        bool themHanhTrinhBao(String maConBao, int trangThai);

        [OperationContract]
        bool xoaHanhtrinhBao(int maHanhTrinh);

        [OperationContract]
        bool themViTriBao(int maHanhTrinh, float viDo, float kinhDo, long thoiGian, float vanToc);

        [OperationContract]
        bool xoaViTriBao(int ma);

        [OperationContract]
        bool suaViTriBao(int ma, float viDo, float kinhDo, long thoiGian, float vanToc);

        [OperationContract]
        DataSet layTinhTrang();

        [OperationContract]
        DataSet layDSHanhTrinh(String maConBao);

        [OperationContract]
        DataSet layViTriBao(int maHanhTrinh);
    }

}
