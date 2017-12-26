using boat.ConBaoService;
using boat.Model.DTO;
using boat.Util;
using BoatService.Service.linh;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boat.GUI.LinhGUI
{
    public partial class frmChiTiet : Form
    {
        private ConBaoServiceClient conBaoServiceClient;
        private int maHanhTrinh;
        public frmChiTiet()
        {
            conBaoServiceClient = new ConBaoServiceClient();
            InitializeComponent();
        }

        public frmChiTiet(int maHanhTrinh)
        {
            conBaoServiceClient = new ConBaoServiceClient();
            this.maHanhTrinh = maHanhTrinh;
            InitializeComponent();
        }

        private void frmChiTiet_Load(object sender, EventArgs e)
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


            initMap(maHanhTrinh);
        }

        private void initMap(int maHanhTrinh)
        {
            GMapOverlay mapOverLay = new GMapOverlay("map1");
            gmap.Overlays.Add(mapOverLay);

            List<ViTriBaoDTO> lst = ConvertUtils.convertViTriBao(conBaoServiceClient.layViTriBao(maHanhTrinh).Tables[0]);

            //GMapMarker mark = new GMarkerGoogle(new PointLatLng(11.999697, 113.148193), GMarkerGoogleType.blue_pushpin);
            GMapMarker mark;
            //for (int i = 0; i <= 4; i++)
            //{
            //    mark = new GMarkerGoogle(new PointLatLng(16.702629 + (i * 0.02), 109.083252 + (i * 0.05)), GMarkerGoogleType.blue_pushpin);
            //    mapOverLay.Markers.Add(mark);
            //}
            Global.GlobalVariables.mapLatLng = new Dictionary<int, LatLng>();
            foreach (ViTriBaoDTO vitri in lst)
            {
                mark = new GMarkerGoogle(new PointLatLng(vitri.vido, vitri.kinhdo), GMarkerGoogleType.green_small);
                mark.ToolTipText = " \nvĩ độ : " + vitri.vido + "\nkinh độ : " + vitri.kinhdo + "\n Lần gửi tín hiệu cuối: " + DateUtils.getDateTime(vitri.thoigian)+" vận tốc: "+vitri.vanToc;
                mark.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                mapOverLay.Markers.Add(mark);


                Global.GlobalVariables.mapLatLng.Add(maHanhTrinh, new LatLng(vitri.vido, vitri.kinhdo));
            }

        }
    }
}
