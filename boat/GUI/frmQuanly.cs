using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using boat.TauService;
using boat.Model.DTO;
using boat.Util;
namespace boat.GUI
{
    public partial class frmQuanly : Form
    {
        private TauthuyenServiceClient tauService = new TauthuyenServiceClient();
        private ConvertUtils conv = new ConvertUtils();
        private DataSet dsTau = new DataSet();
        private string matau = "";
        private List<VitriDTO> vitri;
        private TauChitietDTO tauChitiet;
        public frmQuanly()
        {
            InitializeComponent();
        }

        private void frmDanhSachTau_Load(object sender, EventArgs e)
        {
            gmap.MapProvider = GMap.NET.MapProviders.BingMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gmap.ShowCenter = false;
            gmap.DisableFocusOnMouseEnter = true;
            gmap.DragButton = MouseButtons.Left;
            gmap.Zoom = 5;
            gmap.SetPositionByKeywords("Hanoi , Vietnam");

            //init
            loadGV();
        }

        private void loadGV()
        {
            dsTau = tauService.layDanhSachTau_v2();
            dgvTau.DataSource = dsTau.Tables[0];
            dgvTau.Columns["ma"].HeaderText = "Mã tàu";
            dgvTau.Columns["tentau"].HeaderText = "Tên tàu";
    
        }

        private void loadMap()
        {
            gmap.ReloadMap();
            gmap.Overlays.Clear();
            vitri = conv.convertVitri(tauService.layVitriFull(matau).Tables[0]);
            gmap.Position = new GMap.NET.PointLatLng(vitri[0].vido, vitri[0].kinhdo);
            gmap.Zoom = 7;

            GMapOverlay mapOverLay = new GMapOverlay("vitri");
            gmap.Overlays.Add(mapOverLay);

            GMapMarker marker;

            List<PointLatLng> lstLatLng = new List<PointLatLng>();
            foreach (VitriDTO vt in vitri)
            {
                PointLatLng latlng = new PointLatLng(vt.vido, vt.kinhdo);
                lstLatLng.Add(latlng);
                marker = new GMarkerGoogle(latlng, GMarkerGoogleType.blue_dot);
                marker.ToolTipText = " \nVĩ độ: " + vt.vido + "\nKinh độ: " + vt.kinhdo + "\nThời gian gửi: " + DateUtils.getDateTime(vt.thoigian);
                marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                mapOverLay.Markers.Add(marker);
            }

            GMapRoute routers = new GMapRoute(lstLatLng, "vitri");
            routers.Stroke = new Pen(Color.Olive, 3);
            mapOverLay.Routes.Add(routers);
            
        }

        private void loadGrb()
        {
            tauChitiet = conv.convertTauChitiet(tauService.layChitietTau(matau).Tables[0]);
            txtMaTau.Text = tauChitiet.ma;
            txtTenTau.Text = tauChitiet.tentau;
            txtMMSI.Text = tauChitiet.MMSI;
            txtLoaiTau.Text = tauChitiet.tenloaitau;
            txtQuocGia.Text = tauChitiet.tenquocgia;
            txtTaitrong.Text = tauChitiet.taitrong.ToString();
        }

        private void quanlytauTSMI_Click(object sender, EventArgs e)
        {
            frmQuanlyTau quanlyTau = new frmQuanlyTau();
            quanlyTau.ShowDialog();
        }

        private void quanlyquocgiaTSMI_Click(object sender, EventArgs e)
        {
            frmQuanlyQuocgia quanlyQuocgia = new frmQuanlyQuocgia();
            quanlyQuocgia.ShowDialog();
        }

        private void quanlyloaitaiTSMI_Click(object sender, EventArgs e)
        {
            frmQuanlyLoaitau quanlyLoaiTau = new frmQuanlyLoaitau();
            quanlyLoaiTau.ShowDialog();
        }

        private void reloadTextBox()
        {
            txtMaTau.Text = txtTenTau.Text = txtMMSI.Text = txtLoaiTau.Text = txtQuocGia.Text = txtTaitrong.Text = "";
        }

        private void dgvTau_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                matau = dgvTau.Rows[e.RowIndex].Cells["ma"].Value.ToString();
                loadGrb();
                loadMap();
            }
            else
            {
                matau = "";
                reloadTextBox();
                gmap.Zoom = 5;
                gmap.Overlays.Clear();
                gmap.SetPositionByKeywords("Hanoi , Vietnam");
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string str = string.Format("ma like '%{0}%' or tentau like '%{0}%' or MMSI like '%{0}%'", txtTimKiem.Text.ToString());
            dsTau.Tables["tau_v2"].DefaultView.RowFilter = str;
        }
    }
}
