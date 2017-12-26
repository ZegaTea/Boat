﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace boat.TauService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TauService.ITauthuyenService")]
    public interface ITauthuyenService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITauthuyenService/guiToaDo", ReplyAction="http://tempuri.org/ITauthuyenService/guiToaDoResponse")]
        bool guiToaDo(int id, double vido, double kinhdo, long time);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITauthuyenService/guiToaDo", ReplyAction="http://tempuri.org/ITauthuyenService/guiToaDoResponse")]
        System.Threading.Tasks.Task<bool> guiToaDoAsync(int id, double vido, double kinhdo, long time);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITauthuyenService/themHanhtrinh", ReplyAction="http://tempuri.org/ITauthuyenService/themHanhtrinhResponse")]
        bool themHanhtrinh(string matauthuyen);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITauthuyenService/themHanhtrinh", ReplyAction="http://tempuri.org/ITauthuyenService/themHanhtrinhResponse")]
        System.Threading.Tasks.Task<bool> themHanhtrinhAsync(string matauthuyen);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITauthuyenService/layDanhSachTau", ReplyAction="http://tempuri.org/ITauthuyenService/layDanhSachTauResponse")]
        System.Data.DataSet layDanhSachTau();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITauthuyenService/layDanhSachTau", ReplyAction="http://tempuri.org/ITauthuyenService/layDanhSachTauResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> layDanhSachTauAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITauthuyenService/layMaHanhTrinh", ReplyAction="http://tempuri.org/ITauthuyenService/layMaHanhTrinhResponse")]
        int layMaHanhTrinh();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITauthuyenService/layMaHanhTrinh", ReplyAction="http://tempuri.org/ITauthuyenService/layMaHanhTrinhResponse")]
        System.Threading.Tasks.Task<int> layMaHanhTrinhAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITauthuyenService/huyHanhTrinh", ReplyAction="http://tempuri.org/ITauthuyenService/huyHanhTrinhResponse")]
        bool huyHanhTrinh(int maHanhTrinh);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITauthuyenService/huyHanhTrinh", ReplyAction="http://tempuri.org/ITauthuyenService/huyHanhTrinhResponse")]
        System.Threading.Tasks.Task<bool> huyHanhTrinhAsync(int maHanhTrinh);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITauthuyenService/getListNewestBoat", ReplyAction="http://tempuri.org/ITauthuyenService/getListNewestBoatResponse")]
        System.Data.DataSet getListNewestBoat();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITauthuyenService/getListNewestBoat", ReplyAction="http://tempuri.org/ITauthuyenService/getListNewestBoatResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> getListNewestBoatAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITauthuyenService/layHanhTrinh", ReplyAction="http://tempuri.org/ITauthuyenService/layHanhTrinhResponse")]
        System.Data.DataSet layHanhTrinh(int maHanhTrinh);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITauthuyenService/layHanhTrinh", ReplyAction="http://tempuri.org/ITauthuyenService/layHanhTrinhResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> layHanhTrinhAsync(int maHanhTrinh);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITauthuyenService/layDanhSachTau_v2", ReplyAction="http://tempuri.org/ITauthuyenService/layDanhSachTau_v2Response")]
        System.Data.DataSet layDanhSachTau_v2();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITauthuyenService/layDanhSachTau_v2", ReplyAction="http://tempuri.org/ITauthuyenService/layDanhSachTau_v2Response")]
        System.Threading.Tasks.Task<System.Data.DataSet> layDanhSachTau_v2Async();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITauthuyenService/layVitriFull", ReplyAction="http://tempuri.org/ITauthuyenService/layVitriFullResponse")]
        System.Data.DataSet layVitriFull(string matau);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITauthuyenService/layVitriFull", ReplyAction="http://tempuri.org/ITauthuyenService/layVitriFullResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> layVitriFullAsync(string matau);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITauthuyenService/layChitietTau", ReplyAction="http://tempuri.org/ITauthuyenService/layChitietTauResponse")]
        System.Data.DataSet layChitietTau(string matau);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITauthuyenService/layChitietTau", ReplyAction="http://tempuri.org/ITauthuyenService/layChitietTauResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> layChitietTauAsync(string matau);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITauthuyenService/layVitriCuoi", ReplyAction="http://tempuri.org/ITauthuyenService/layVitriCuoiResponse")]
        System.Data.DataSet layVitriCuoi(string matau);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITauthuyenService/layVitriCuoi", ReplyAction="http://tempuri.org/ITauthuyenService/layVitriCuoiResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> layVitriCuoiAsync(string matau);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITauthuyenService/layVitriCuoiAll", ReplyAction="http://tempuri.org/ITauthuyenService/layVitriCuoiAllResponse")]
        System.Data.DataSet layVitriCuoiAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITauthuyenService/layVitriCuoiAll", ReplyAction="http://tempuri.org/ITauthuyenService/layVitriCuoiAllResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> layVitriCuoiAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITauthuyenService/getListTauDanger", ReplyAction="http://tempuri.org/ITauthuyenService/getListTauDangerResponse")]
        System.Data.DataSet getListTauDanger(string taus);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITauthuyenService/getListTauDanger", ReplyAction="http://tempuri.org/ITauthuyenService/getListTauDangerResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> getListTauDangerAsync(string taus);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITauthuyenServiceChannel : boat.TauService.ITauthuyenService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TauthuyenServiceClient : System.ServiceModel.ClientBase<boat.TauService.ITauthuyenService>, boat.TauService.ITauthuyenService {
        
        public TauthuyenServiceClient() {
        }
        
        public TauthuyenServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TauthuyenServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TauthuyenServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TauthuyenServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool guiToaDo(int id, double vido, double kinhdo, long time) {
            return base.Channel.guiToaDo(id, vido, kinhdo, time);
        }
        
        public System.Threading.Tasks.Task<bool> guiToaDoAsync(int id, double vido, double kinhdo, long time) {
            return base.Channel.guiToaDoAsync(id, vido, kinhdo, time);
        }
        
        public bool themHanhtrinh(string matauthuyen) {
            return base.Channel.themHanhtrinh(matauthuyen);
        }
        
        public System.Threading.Tasks.Task<bool> themHanhtrinhAsync(string matauthuyen) {
            return base.Channel.themHanhtrinhAsync(matauthuyen);
        }
        
        public System.Data.DataSet layDanhSachTau() {
            return base.Channel.layDanhSachTau();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> layDanhSachTauAsync() {
            return base.Channel.layDanhSachTauAsync();
        }
        
        public int layMaHanhTrinh() {
            return base.Channel.layMaHanhTrinh();
        }
        
        public System.Threading.Tasks.Task<int> layMaHanhTrinhAsync() {
            return base.Channel.layMaHanhTrinhAsync();
        }
        
        public bool huyHanhTrinh(int maHanhTrinh) {
            return base.Channel.huyHanhTrinh(maHanhTrinh);
        }
        
        public System.Threading.Tasks.Task<bool> huyHanhTrinhAsync(int maHanhTrinh) {
            return base.Channel.huyHanhTrinhAsync(maHanhTrinh);
        }
        
        public System.Data.DataSet getListNewestBoat() {
            return base.Channel.getListNewestBoat();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> getListNewestBoatAsync() {
            return base.Channel.getListNewestBoatAsync();
        }
        
        public System.Data.DataSet layHanhTrinh(int maHanhTrinh) {
            return base.Channel.layHanhTrinh(maHanhTrinh);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> layHanhTrinhAsync(int maHanhTrinh) {
            return base.Channel.layHanhTrinhAsync(maHanhTrinh);
        }
        
        public System.Data.DataSet layDanhSachTau_v2() {
            return base.Channel.layDanhSachTau_v2();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> layDanhSachTau_v2Async() {
            return base.Channel.layDanhSachTau_v2Async();
        }
        
        public System.Data.DataSet layVitriFull(string matau) {
            return base.Channel.layVitriFull(matau);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> layVitriFullAsync(string matau) {
            return base.Channel.layVitriFullAsync(matau);
        }
        
        public System.Data.DataSet layChitietTau(string matau) {
            return base.Channel.layChitietTau(matau);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> layChitietTauAsync(string matau) {
            return base.Channel.layChitietTauAsync(matau);
        }
        
        public System.Data.DataSet layVitriCuoi(string matau) {
            return base.Channel.layVitriCuoi(matau);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> layVitriCuoiAsync(string matau) {
            return base.Channel.layVitriCuoiAsync(matau);
        }
        
        public System.Data.DataSet layVitriCuoiAll() {
            return base.Channel.layVitriCuoiAll();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> layVitriCuoiAllAsync() {
            return base.Channel.layVitriCuoiAllAsync();
        }
        
        public System.Data.DataSet getListTauDanger(string taus) {
            return base.Channel.getListTauDanger(taus);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> getListTauDangerAsync(string taus) {
            return base.Channel.getListTauDangerAsync(taus);
        }
    }
}
