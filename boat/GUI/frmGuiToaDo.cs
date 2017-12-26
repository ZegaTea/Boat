using boat.BUS;
using boat.Global;
using boat.Model.DTO;
using boat.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Device.Location;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boat.GUI
{
    public partial class frmGuiToaDo : Form
    {
        TauthuyenBUS tauBus = new TauthuyenBUS();
        private BaoBUS baoBus = new BaoBUS();
        private ConvertUtils con = new ConvertUtils();
        private LatLng l;
        public frmGuiToaDo()
        {
            InitializeComponent();
        }

        private void frmGuiToaDo_Load(object sender, EventArgs e)
        {
            lblText.Visible = false;
            DataSet tau = tauBus.layDanhSachTau();
            cmbTau.DataSource = tau.Tables["tau"];
            cmbTau.DisplayMember = "tentau";
            cmbTau.ValueMember = "ma";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblText.ForeColor = Color.Black;
            lblText.Text = DateUtils.getTimeInMilis().ToString();

            LatLng latlng = randLatLng();
            l = latlng;
            tauBus.guiToaDo(Global.GlobalVariables.mapHanhtrinhtau[cmbTau.SelectedValue.ToString()], latlng.vido, latlng.kinhdo, DateUtils.getTimeInMilis());
            string msg = "Tàu: " + cmbTau.Text + "\nMã số: " + cmbTau.SelectedValue + " \nvĩ độ : " + latlng.vido + "\nkinh độ : " + latlng.kinhdo;

            //rtbState.Text = oldMsg + ("Thông tin di chuyển " + i + ": \n" + msg + "\n" + DateTime.Now.ToString() + "\n------------\n");
            Global.GlobalVariables.messageStates += ("Thông tin di chuyển : \n" + msg + "\n" + DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "\n------------\n");

            List<PairDTO> lstBaoPair = con.convertPair(baoBus.layVitriCuoiAll().Tables[0]);
            foreach (PairDTO pair in lstBaoPair)
            {
                var sCoord = new GeoCoordinate(l.vido, l.kinhdo);
                var eCoord = new GeoCoordinate(pair.vido, pair.kinhdo);
                var x = sCoord.GetDistanceTo(eCoord);
                if (x <= Constant.DANGER_RANGE)
                {
                    lblText.ForeColor = Color.Red;

                    lblText.Text = "Nguy hiểm: Tàu đang đi vào khu vực có bão";
                    break;
                }
            }
            //label1.Text = id;
        }

        private void btnGui_Click(object sender, EventArgs e)
        {

            if (Global.GlobalVariables.mapHanhtrinhtau.ContainsKey(cmbTau.SelectedValue.ToString()))
            {
                MessageBox.Show(cmbTau.Text.ToString() + " mã số " + cmbTau.SelectedValue + " đang gửi tín hiệu. Vui lòng chọn tàu khác", "Lỗi !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                

                lblText.Visible = true;
                cmbTau.Enabled = false;
                lblText.ForeColor = Color.Black;
                lblText.Text = DateUtils.getTimeInMilis().ToString();
                tauBus.themHanhtrinh(cmbTau.SelectedValue.ToString());
                int maHanhTrinh = tauBus.layMaHanhTrinh();

                Global.GlobalVariables.mapHanhtrinhtau.Add(cmbTau.SelectedValue.ToString(), maHanhTrinh);

                int oldId = Global.GlobalVariables.mapHanhTrinhCu[cmbTau.SelectedValue.ToString()];
                l = Global.GlobalVariables.mapLatLng[oldId];
                LatLng latlng = randLatLng();
                l = latlng;
                tauBus.guiToaDo(maHanhTrinh, latlng.vido, latlng.kinhdo, DateUtils.getTimeInMilis());

                string msg = "Tàu: " + cmbTau.Text.ToString() + "\nMã số: " + cmbTau.SelectedValue + " \nvĩ độ : " + latlng.vido + "\nkinh độ : " + latlng.kinhdo;

                //rtbState.Text = oldMsg + ("Thông tin di chuyển " + i + ": \n" + msg + "\n" + DateTime.Now.ToString() + "\n------------\n");
                Global.GlobalVariables.messageStates += ("Thông tin di chuyển : \n" + msg + "\n" + DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "\n------------\n");

                List<PairDTO> lstBaoPair = con.convertPair(baoBus.layVitriCuoiAll().Tables[0]);
                foreach (PairDTO pair in lstBaoPair)
                {
                    var sCoord = new GeoCoordinate(l.vido, l.kinhdo);
                    var eCoord = new GeoCoordinate(pair.vido, pair.kinhdo);
                    var x = sCoord.GetDistanceTo(eCoord);
                    if (x <= Constant.DANGER_RANGE)
                    {
                        lblText.ForeColor = Color.Red;
                        
                        lblText.Text = "Nguy hiểm: Tàu đang đi vào khu vực có bão";
                        break;
                    }
                }
                timer1.Start();
            }

            btnDung.Enabled = true;
            btnGui.Enabled = false;
        }

        private void btnDung_Click(object sender, EventArgs e)
        {
            lblText.Visible = false;
            timer1.Stop();
            tauBus.huyHanhTrinh(Global.GlobalVariables.mapHanhtrinhtau[cmbTau.SelectedValue.ToString()]);
            Global.GlobalVariables.mapHanhtrinhtau.Remove(cmbTau.SelectedValue.ToString());
            cmbTau.Enabled = true;

            btnDung.Enabled = false;
            btnGui.Enabled = true;
        }

        private LatLng randLatLng()
        {

            try
            {
                Global.GlobalVariables.mapLatLng.Remove(Global.GlobalVariables.mapHanhTrinhCu[cmbTau.SelectedValue.ToString()]);
            }
            catch (Exception ex)
            {
                
            }

            LatLng newLatLng = new LatLng();
            long x = DateUtils.getTimeInMilis();
            Random rand = new Random();
            //if (x % 2 == 0)
            //{
            //    newLatLng.vido = l.vido + (double)rand.Next(100) / 100;
            //    newLatLng.kinhdo = l.kinhdo + (double)rand.Next(1000) / 1000;
            //}
            //else
            //{
            //    newLatLng.vido = l.vido + (double)rand.Next(10) / 100;
            //    newLatLng.kinhdo = l.kinhdo - (double)rand.Next(10) / 1000;
            //}

            newLatLng.vido = l.vido + 0.01;
            newLatLng.kinhdo = l.kinhdo + 0.003;
            return newLatLng;
        }

        private void frmGuiToaDo_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (Global.GlobalVariables.mapHanhtrinhtau.ContainsKey(cmbTau.SelectedValue.ToString()))
            {
                timer1.Stop();
                lblText.Visible = false;
                DialogResult res = MessageBox.Show("Tàu vẫn đang di chuyển. Bạn có muốn dừng hành trình ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    //lblText.Visible = false;
                    //timer1.Stop();
                    tauBus.huyHanhTrinh(Global.GlobalVariables.mapHanhtrinhtau[cmbTau.SelectedValue.ToString()]);
                    Global.GlobalVariables.mapHanhtrinhtau.Remove(cmbTau.SelectedValue.ToString());
                    this.Close();
                }
                else
                {
                    e.Cancel = (e.CloseReason == CloseReason.UserClosing);
                    timer1.Start();
                    lblText.Visible = true;
                }
            }
        }
    }
}
