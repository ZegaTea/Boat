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
using boat.GUI;
using boat.Model.DTO;
using boat.BUS;
using boat.Util;

namespace boat
{
    public partial class frmMain : Form
    {
        private TauthuyenBUS tauBus = new TauthuyenBUS();
        private ConvertUtils con = new ConvertUtils();
        public frmMain()
        {
            InitializeComponent();
            //timer1.Start();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            gmap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gmap.ShowCenter = false;
            gmap.DisableFocusOnMouseEnter = true;
            gmap.DragButton = MouseButtons.Left;

            gmap.Position = new GMap.NET.PointLatLng(16.197737, 108.835373);
            gmap.Zoom = 9;
            //gmap.SetPositionByKeywords("Hue, Vietnam");


            initMap();

            //rtbState. = "1231111111111111111111111111111111111";

            timer1.Start();
        }

        private void initMap()
        {
            GMapOverlay mapOverLay = new GMapOverlay("map1");
            gmap.Overlays.Add(mapOverLay);

            List<TauVItriDTO> lst = con.convertTauVitri(tauBus.danhSachTau().Tables[0]);

            //GMapMarker mark = new GMarkerGoogle(new PointLatLng(11.999697, 113.148193), GMarkerGoogleType.blue_pushpin);
            GMapMarker mark;
            //for (int i = 0; i <= 4; i++)
            //{
            //    mark = new GMarkerGoogle(new PointLatLng(16.702629 + (i * 0.02), 109.083252 + (i * 0.05)), GMarkerGoogleType.blue_pushpin);
            //    mapOverLay.Markers.Add(mark);
            //}
            Global.GlobalVariables.mapHanhTrinhCu = new Dictionary<string, int>();
            Global.GlobalVariables.mapLatLng = new Dictionary<int, LatLng>();
            foreach (TauVItriDTO tau in lst)
            {
                mark = new GMarkerGoogle(new PointLatLng(tau.vido, tau.kinhdo), GMarkerGoogleType.green_small);
                mark.ToolTipText = tau.tentau + " \nvĩ độ : " + tau.vido + "\nkinh độ : " + tau.kinhdo + " \nMMSI : " + tau.MMSI + " \n Lần gửi tín hiệu cuối: " + DateUtils.getDateTime(tau.thoigian);
                mark.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                mapOverLay.Markers.Add(mark);


                Global.GlobalVariables.mapLatLng.Add(tau.mahanhtrinh, new LatLng(tau.vido, tau.kinhdo));
                Global.GlobalVariables.mapHanhTrinhCu.Add(tau.matauthuyen, tau.mahanhtrinh);
            }

            //marker.Markers.Add(mark);


            loadTauDiChuyen();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            gmap.Refresh();
            gmap.Overlays.Clear();
            initMap();
            rtbState.Text = Global.GlobalVariables.messageStates;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmGuiToaDo frm = new frmGuiToaDo();
            frm.Show();
        }

        private void loadTauDiChuyen()
        {
            string msg = "";
            if (Global.GlobalVariables.mapHanhtrinhtau.Count != 0)
            {
                foreach (KeyValuePair<string, int> entry in Global.GlobalVariables.mapHanhtrinhtau)
                {
                    GMapOverlay mapOverlay = new GMapOverlay("hanhtrinh");
                    gmap.Overlays.Add(mapOverlay);
                    List<HanhtrinhDTO> lstHanhTrinh = con.convertHanhtrinh(tauBus.layHanhTrinh(entry.Value).Tables[0]);
                    GMapMarker marker;
                    List<PointLatLng> lstLatLng = new List<PointLatLng>();

                    foreach (HanhtrinhDTO ht in lstHanhTrinh)
                    {
                        msg = ht.tentau + " \nvĩ độ : " + ht.vido + "\nkinh độ : " + ht.kinhdo + " \nMMSI : " + ht.MMSI;
                        //string oldMsg = rtbState.Text;
                        //rtbState.Text = oldMsg + ("Thông tin di chuyển " + i + ": \n" + msg + "\n" + DateTime.Now.ToString() + "\n------------\n");
                        PointLatLng lat = new PointLatLng(ht.vido, ht.kinhdo);
                        marker = new GMarkerGoogle(lat, GMarkerGoogleType.red_small);
                        lstLatLng.Add(lat);
                        marker.ToolTipText = msg;
                        marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                        mapOverlay.Markers.Add(marker);
                    }
                    GMapRoute routers = new GMapRoute(lstLatLng, "hanhtrinh");
                    routers.Stroke = new Pen(Color.BlueViolet, 3);
                    mapOverlay.Routes.Add(routers);

                }
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Global.GlobalVariables.mapHanhtrinhtau.Count != 0)
            {
                foreach (KeyValuePair<string, int> entry in Global.GlobalVariables.mapHanhtrinhtau)
                {
                    tauBus.huyHanhTrinh(entry.Value);
                }
            }

            Application.Exit();
        }

        private void quanlyTSMI_Click(object sender, EventArgs e)
        {
            
            this.Visible = false;
            frmDanhSachTau frm = new frmDanhSachTau();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void baoTSMI_Click(object sender, EventArgs e)
        {
            frmToadoBao toadoBao = new frmToadoBao();
            toadoBao.Show();
        }

        private void quanlyBaoTSMI_Click(object sender, EventArgs e)
        {
            frmQuanlyBao quanlyBao = new frmQuanlyBao();
            quanlyBao.ShowDialog();
        }
    }
}
