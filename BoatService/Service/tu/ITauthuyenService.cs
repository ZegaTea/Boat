using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;


namespace BoatService.Service.tu
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ITauthuyenService" in both code and config file together.
    [ServiceContract]
    public interface ITauthuyenService
    {

        [OperationContract]
        bool guiToaDo(int id, double vido, double kinhdo, long time);

        [OperationContract]
        bool themHanhtrinh(string matauthuyen);

        [OperationContract]
        DataSet layDanhSachTau();

        [OperationContract]
        int layMaHanhTrinh();

        [OperationContract]
        bool huyHanhTrinh(int maHanhTrinh);
        [OperationContract]
        DataSet getListNewestBoat();
        [OperationContract]
        DataSet layHanhTrinh(int maHanhTrinh);
        [OperationContract]
        DataSet layDanhSachTau_v2();
        [OperationContract]
        DataSet layVitriFull(string matau);
        [OperationContract]
        DataSet layChitietTau(string matau);
        [OperationContract]
        DataSet layVitriCuoi(string matau);
        [OperationContract]
        DataSet layVitriCuoiAll();
        [OperationContract]
        DataSet getListTauDanger(string taus);
    }
}
