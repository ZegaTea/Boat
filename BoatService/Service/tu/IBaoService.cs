using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BoatService.Service.tu
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IBaoService" in both code and config file together.
    [ServiceContract]
    public interface IBaoService
    {
        [OperationContract]
        void DoWork();
        [OperationContract]
        DataSet getListBao();
        [OperationContract]
        int addToHanhtrinhBao(string ma);
        [OperationContract]
        void huyHanhtrinhBao(int ma);
        [OperationContract]
        void addToVitriBao(int maht, double vi, double ki, long dt);
        [OperationContract]
        DataSet getVitriBao(int maht);
        [OperationContract]
        DataSet getListNewestBao();
        [OperationContract]
        DataSet layVitriCuoiAll();
    }
}
