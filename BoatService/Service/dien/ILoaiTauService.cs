using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BoatService.Model;

namespace BoatService.Service.dien
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ILoaiTauService" in both code and config file together.
    [ServiceContract]
    public interface ILoaiTauService
    {
        [OperationContract]
        DataSet getListTypesShip1();
        [OperationContract]
        int InsertTypesShip(loaitau _loaitau);
        [OperationContract]
        int UpdateTypesShip(loaitau _loaitau);
    }
}
