using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;
using System;
using System.Collections.Generic;
using System.Device.Location;
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
using boat.Global;

namespace boat
{
    public partial class frmMain : Form
    {
        private TauthuyenBUS tauBus = new TauthuyenBUS();
        private BaoBUS baoBus = new BaoBUS();
        private ConvertUtils con = new ConvertUtils();
        private List<string> lstTauDanger = new List<string>();

        private int theodoi = 0;
        public frmMain()
        {
            InitializeComponent();
            //timer1.Start();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            dgvTauDanger.RowHeadersVisible = false;
            this.WindowState = FormWindowState.Maximized;
            gmap.MapProvider = GMap.NET.MapProviders.BingSatelliteMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
            gmap.ShowCenter = false;
            gmap.DisableFocusOnMouseEnter = true;
            gmap.DragButton = MouseButtons.Left;

            gmap.Position = new GMap.NET.PointLatLng(16.197737, 108.835373);
            gmap.Zoom = 7;
            //gmap.SetPositionByKeywords("Hue, Vietnam");

            DataSet tau = tauBus.layDanhSachTau();
            cmbTau.DataSource = tau.Tables["tau"];
            cmbTau.DisplayMember = "tentau";
            cmbTau.ValueMember = "ma";

            initMap();

            timer1.Start();
        }

        private void initMap()
        {
            GMapOverlay mapOverLay = new GMapOverlay("map1");
            gmap.Overlays.Add(mapOverLay);

            List<TauVItriDTO> lst = con.convertTauVitri(tauBus.danhSachTau().Tables[0]);
            List<BaoVitriDTO> lstBao = con.convertBaoVitri(baoBus.getListNewestBao().Tables[0]);

            lstTauDanger = new List<string>();

            //GMapMarker mark = new GMarkerGoogle(new PointLatLng(11.999697, 113.148193), GMarkerGoogleType.blue_pushpin);
            GMapMarker mark;
            GMapMarker mark2;

            Global.GlobalVariables.mapHanhTrinhCu = new Dictionary<string, int>();
            Global.GlobalVariables.mapLatLng = new Dictionary<int, LatLng>();


            int reload = 1;
            // Tàu
            for (int i = 0; i < lst.Count; i++)
            {
                int danger = 0;

                TauVItriDTO tau = lst.ElementAt(i);

                if (i == 0)
                {
                    // Bão
                    GlobalVariables.mapHanhtrinhBaoCu = new System.Collections.Concurrent.ConcurrentDictionary<string, LatLng>();
                }

                foreach (BaoVitriDTO bao in lstBao)
                {
                    if (i == 0)
                    {
                        mark2 = new GMarkerGoogle(new PointLatLng(bao.vido, bao.kinhdo), Properties.Resources.icons8_Hunt_16);
                        mark2.ToolTipText = bao.tenbao
                            + " \nvĩ độ : " + bao.vido
                            + " \nkinh độ : " + bao.kinhdo
                            + " \n Lần gửi tín hiệu cuối: " + DateUtils.getDateTime(bao.thoigian);
                        mark2.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                        mapOverLay.Markers.Add(mark2);

                        CreateCircle(bao, 1143.899431 * 50);

                        var latlng = new LatLng(bao.vido, bao.kinhdo);
                        GlobalVariables.mapHanhtrinhBaoCu.AddOrUpdate(bao.ma, latlng, (key, oldValue) => latlng);
                    }

                    if (danger == 0)
                    {
                        var sCoord = new GeoCoordinate(tau.vido, tau.kinhdo);
                        var eCoord = new GeoCoordinate(bao.vido, bao.kinhdo);
                        var x = sCoord.GetDistanceTo(eCoord);
                        if (x <= Constant.DANGER_RANGE)
                        {
                            danger = 1;
                            lstTauDanger.Add("'" + tau.matauthuyen + "'");
                        }
                    }
                }

                if (danger == 0)
                {
                    mark = new GMarkerGoogle(new PointLatLng(tau.vido, tau.kinhdo), GMarkerGoogleType.green_small);
                }
                else
                {
                    mark = new GMarkerGoogle(new PointLatLng(tau.vido, tau.kinhdo), GMarkerGoogleType.red);
                    //rtbDanger.AppendText("\nCảnh báo lúc: " + DateTime.Now.ToString("dd-MM-yyyy  HH:mm:ss")
                    //    + "\n+Tàu " + tau.matauthuyen + " đang trong vùng nguy hiểm \n-------------------");
                    //rtbDanger.Focus();
                    rtbDanger.Text += "\nCảnh báo lúc: " + DateTime.Now.ToString("dd-MM-yyyy  HH:mm:ss")
                        + "\n+Tàu " + tau.matauthuyen + " đang trong vùng nguy hiểm \n-------------------";


                }

                mark.ToolTipText = tau.tentau
                    + " \nvĩ độ : " + tau.vido
                    + " \nkinh độ : " + tau.kinhdo
                    + " \nMMSI : " + tau.MMSI
                    + " \n Lần gửi tín hiệu cuối: " + DateUtils.getDateTime(tau.thoigian);
                mark.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                mapOverLay.Markers.Add(mark);


                Global.GlobalVariables.mapLatLng.Add(tau.mahanhtrinh, new LatLng(tau.vido, tau.kinhdo));
                Global.GlobalVariables.mapHanhTrinhCu.Add(tau.matauthuyen, tau.mahanhtrinh);

            }
            //marker.Markers.Add(mark);

            loadTauDiChuyen();
        }

        private void loadTauDiChuyen()
        {
            //List<PairDTO> lstTauPair = con.convertPair(tauBus.layVitriCuoiAll().Tables[0]);
            List<PairDTO> lstBaoPair = con.convertPair(baoBus.layVitriCuoiAll().Tables[0]);
            string msg = "";
            if (Global.GlobalVariables.mapHanhtrinhtau.Count != 0)
            {

                foreach (KeyValuePair<string, int> entry in Global.GlobalVariables.mapHanhtrinhtau)
                {
                    int reload = 1;
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
                        int danger = 0;
                        foreach (PairDTO pair in lstBaoPair)
                        {
                            var sCoord = new GeoCoordinate(ht.vido, ht.kinhdo);
                            var eCoord = new GeoCoordinate(pair.vido, pair.kinhdo);
                            var x = sCoord.GetDistanceTo(eCoord);
                            if (x <= Constant.DANGER_RANGE)
                            {
                                danger = 1;
                                lstTauDanger.Add("'" + ht.matau + "'");
                                break;
                            }
                        }
                        PointLatLng lat = new PointLatLng(ht.vido, ht.kinhdo);
                        if (danger == 0)
                        {
                            marker = new GMarkerGoogle(lat, GMarkerGoogleType.blue_small);
                        }
                        else
                        {
                            marker = new GMarkerGoogle(lat, GMarkerGoogleType.purple);
                            if (reload == 1)
                            {
                                rtbDanger.Text += "\nCảnh báo lúc: " + DateTime.Now.ToString("dd-MM-yyyy  HH:mm:ss")
                        + "\n+Tàu" + ht.matau + " đang đi vào vùng nguy hiểm \n-------------------";
                                reload = 0;
                            }
                        }

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

            // Baox
            if (GlobalVariables.mapHanhtrinhBao.Count > 0)
            {
                foreach (KeyValuePair<string, int> entry in GlobalVariables.mapHanhtrinhBao)
                {
                    GMapOverlay mapOverlay = new GMapOverlay("hanhtrinhbao");
                    gmap.Overlays.Add(mapOverlay);
                    List<BaoVitriDTO> lstHanhTrinh = con.convertBaoVitri(baoBus.getVitriBao(entry.Value).Tables[0]);
                    GMapMarker marker;
                    List<PointLatLng> lstLatLng = new List<PointLatLng>();

                    foreach (BaoVitriDTO bao in lstHanhTrinh)
                    {
                        msg = bao.tenbao + " \nvĩ độ : " + bao.vido + "\nkinh độ : " + bao.kinhdo + " \nTrạng thái : " + bao.trangthai + " \nThời gian : " + DateUtils.getDateTime(bao.thoigian);

                        PointLatLng lat = new PointLatLng(bao.vido, bao.kinhdo);
                        marker = new GMarkerGoogle(lat, GMarkerGoogleType.yellow_small);
                        lstLatLng.Add(lat);
                        marker.ToolTipText = msg;
                        marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                        mapOverlay.Markers.Add(marker);

                        CreateCircle(bao, 1143.899431 * 50);
                    }

                    GMapRoute routers = new GMapRoute(lstLatLng, "hanhtrinhbao");
                    routers.Stroke = new Pen(Color.DarkRed, 3);
                    mapOverlay.Routes.Add(routers);
                }
            }


            initDgv();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            gmap.Refresh();
            gmap.Overlays.Clear();
            initMap();
            rtbState.Text = Global.GlobalVariables.messageStates;

            // Tracking
            if (theodoi == 1)
            {
                DataSet ds = tauBus.layVitriCuoi(cmbTau.SelectedValue.ToString());
                double vi = ds.Tables[0].Rows[0].Field<double>("vido");
                double ki = ds.Tables[0].Rows[0].Field<double>("kinhdo");
                gmap.Position = new GMap.NET.PointLatLng(vi, ki);
                gmap.Zoom = 10;
            }

            // daNger zOne

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmGuiToaDo frm = new frmGuiToaDo();

            frm.Show(this);
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
            frmQuanly frm = new frmQuanly();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void baoTSMI_Click(object sender, EventArgs e)
        {
            frmMophongBao toadoBao = new frmMophongBao();
            toadoBao.Show(this);
        }

        private void quanlyBaoTSMI_Click(object sender, EventArgs e)
        {
            frmQuanlyBao quanlyBao = new frmQuanlyBao();
            quanlyBao.ShowDialog();
        }

        private void btnTheodoi_Click(object sender, EventArgs e)
        {
            if (theodoi == 0)
            {
                theodoi = 1;
                btnTheodoi.Text = "Dừng";
                cmbTau.Enabled = false;
                DataSet ds = tauBus.layVitriCuoi(cmbTau.SelectedValue.ToString());
                double vi = ds.Tables[0].Rows[0].Field<double>("vido");
                double ki = ds.Tables[0].Rows[0].Field<double>("kinhdo");
                gmap.Position = new GMap.NET.PointLatLng(vi, ki);
                gmap.Zoom = 10;
            }
            else
            {
                theodoi = 0;
                btnTheodoi.Text = "Theo dõi";
                cmbTau.Enabled = true;
                gmap.Position = new GMap.NET.PointLatLng(16.197737, 108.835373);
                gmap.Zoom = 7;
            }
        }

        private void initDgv()
        {
            string taus = String.Join(", ", lstTauDanger);
            DataSet ds = tauBus.getListTauDanger(taus);
            dgvTauDanger.DataSource = ds.Tables[0];
        }


        #region   ------Create circle-------
        private void CreateCircle(BaoVitriDTO bao, double radius)
        {
            GMapOverlay ol = new GMapOverlay("ol");
            gmap.Overlays.Add(ol);
            PointLatLng point = new PointLatLng(bao.vido, bao.kinhdo);
            int segments = 1000;

            List<PointLatLng> gpollist = new List<PointLatLng>();

            for (int i = 0; i < segments; i++)
                gpollist.Add(FindPointAtDistanceFrom(point, i, radius / 1000));

            GMapPolygon gpol = new GMapPolygon(gpollist, "pol");
            gpol.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
            gpol.Stroke = new Pen(Color.CadetBlue, 1);
            //ol.Markers.Add(new GMarkerGoogle(new PointLatLng(bao.vido, bao.kinhdo), GMarkerGoogleType.blue_small));
            ol.Polygons.Add(gpol);
        }

        public static GMap.NET.PointLatLng FindPointAtDistanceFrom(GMap.NET.PointLatLng startPoint, double initialBearingRadians, double distanceKilometres)
        {
            const double radiusEarthKilometres = 6371.01;
            var distRatio = distanceKilometres / radiusEarthKilometres;
            var distRatioSine = Math.Sin(distRatio);
            var distRatioCosine = Math.Cos(distRatio);

            var startLatRad = DegreesToRadians(startPoint.Lat);
            var startLonRad = DegreesToRadians(startPoint.Lng);

            var startLatCos = Math.Cos(startLatRad);
            var startLatSin = Math.Sin(startLatRad);

            var endLatRads = Math.Asin((startLatSin * distRatioCosine) + (startLatCos * distRatioSine * Math.Cos(initialBearingRadians)));

            var endLonRads = startLonRad + Math.Atan2(
                          Math.Sin(initialBearingRadians) * distRatioSine * startLatCos,
                          distRatioCosine - startLatSin * Math.Sin(endLatRads));

            return new GMap.NET.PointLatLng(RadiansToDegrees(endLatRads), RadiansToDegrees(endLonRads));
        }

        public static double DegreesToRadians(double degrees)
        {
            const double degToRadFactor = Math.PI / 180;
            return degrees * degToRadFactor;
        }

        public static double RadiansToDegrees(double radians)
        {
            const double radToDegFactor = 180 / Math.PI;
            return radians * radToDegFactor;
        }

        private void rtbState_TextChanged(object sender, EventArgs e)
        {
            rtbState.SelectionStart = rtbState.Text.Length;
            rtbState.ScrollToCaret();
        }

        private void rtbDanger_TextChanged(object sender, EventArgs e)
        {
            rtbDanger.SelectionStart = rtbDanger.Text.Length;
            rtbDanger.ScrollToCaret();
        }

        #endregion ------End create circle-------

        private void dgvTauDanger_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (e.RowIndex >= 0)
            {
                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                {
                    string msg = "\nGửi cảnh báo đến tàu " + dgvTauDanger.Rows[e.RowIndex].Cells[0].Value.ToString() + " thành công"
                        + "\nThời gian: " + DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss")
                        + "\n--------------";
                    rtbWarning.Text += msg;
                }
                else
                {
                    DataSet ds = tauBus.layVitriCuoi(dgvTauDanger.Rows[e.RowIndex].Cells[0].Value.ToString());
                    double vi = ds.Tables[0].Rows[0].Field<double>("vido");
                    double ki = ds.Tables[0].Rows[0].Field<double>("kinhdo");
                    gmap.Position = new GMap.NET.PointLatLng(vi, ki);
                    gmap.Zoom = 10;
                }
            }

        }

        private void rtbWarning_TextChanged(object sender, EventArgs e)
        {
            rtbWarning.SelectionStart = rtbWarning.Text.Length;
            rtbWarning.ScrollToCaret();
        }
    }
}
