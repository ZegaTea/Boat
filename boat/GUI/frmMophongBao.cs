using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using boat.BUS;
using boat.Global;
using boat.Util;
using boat.Model.DTO;

namespace boat.GUI
{
    public partial class frmMophongBao : Form
    {
        private BaoBUS baoBus = new BaoBUS();
        private LatLng l;
        public frmMophongBao()
        {
            InitializeComponent();
        }

        private void frmMophongBao_Load(object sender, EventArgs e)
        {
            lblText.Visible = false;
            DataSet tau = baoBus.getListBao();
            cmbBao.DataSource = tau.Tables["tenbao"];
            cmbBao.DisplayMember = "tenconbao";
            cmbBao.ValueMember = "ma";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblText.Text = DateUtils.getTimeInMilis().ToString();

            LatLng latlng = randLatLng();
            l = latlng;
            baoBus.addToVitriBao(GlobalVariables.mapHanhtrinhBao[cmbBao.SelectedValue.ToString()], latlng.vido, latlng.kinhdo, DateUtils.getTimeInMilis());

            //rtbState.Text = oldMsg + ("Thông tin di chuyển " + i + ": \n" + msg + "\n" + DateTime.Now.ToString() + "\n------------\n");
        }

        private void btnGui_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.mapHanhtrinhBao.ContainsKey(cmbBao.SelectedValue.ToString()))
            {
                MessageBox.Show(cmbBao.Text.ToString() + " mã số " + cmbBao.SelectedValue + " đang gửi tín hiệu. Vui lòng chọn cơn bão khác", "Lỗi !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lblText.Visible = true;
                cmbBao.Enabled = false;
                lblText.Text = DateUtils.getTimeInMilis().ToString();

                int maHanhTrinh = baoBus.addToHanhtrinhBao(cmbBao.SelectedValue.ToString());

                GlobalVariables.mapHanhtrinhBao.AddOrUpdate(cmbBao.SelectedValue.ToString(), maHanhTrinh, (key, oldValue) => maHanhTrinh);

                //int oldId = Global.GlobalVariables.mapHanhTrinhCu[cmbTau.SelectedValue.ToString()];
                l = GlobalVariables.mapHanhtrinhBaoCu[cmbBao.SelectedValue.ToString()];
                LatLng latlng = randLatLng();
                l = latlng;
                baoBus.addToVitriBao(maHanhTrinh, latlng.vido, latlng.kinhdo, DateUtils.getTimeInMilis());

                //string msg = "Tàu: " + cmbTau.Text.ToString() + "\nMã số: " + cmbTau.SelectedValue + " \nvĩ độ : " + latlng.vido + "\nkinh độ : " + latlng.kinhdo;

                ////rtbState.Text = oldMsg + ("Thông tin di chuyển " + i + ": \n" + msg + "\n" + DateTime.Now.ToString() + "\n------------\n");
                //Global.GlobalVariables.messageStates += ("Thông tin di chuyển : \n" + msg + "\n" + DateTime.Now.ToString() + "\n------------\n");
                timer1.Start();
            }
        }

        private LatLng randLatLng()
        {
            try
            {
                LatLng valueOut;
                GlobalVariables.mapHanhtrinhBaoCu.TryRemove(cmbBao.SelectedValue.ToString(), out valueOut);
            }
            catch (Exception ex)
            {

            }

            LatLng newLatLng = new LatLng();
            long x = DateUtils.getTimeInMilis();
            Random rand = new Random();
            newLatLng.vido = l.vido + 0.01;
            newLatLng.kinhdo = l.kinhdo - 0.01;

            //newLatLng.vido = l.vido + 0.01;
            //newLatLng.kinhdo = l.kinhdo + 0.003;
            return newLatLng;
        }

        private void btnDung_Click(object sender, EventArgs e)
        {
            int outValue;
            lblText.Visible = false;
            timer1.Stop();
            baoBus.huyHanhtrinhBao(GlobalVariables.mapHanhtrinhBao[cmbBao.SelectedValue.ToString()]);
            GlobalVariables.mapHanhtrinhBao.TryRemove(cmbBao.SelectedValue.ToString(), out outValue);
            GlobalVariables.mapHanhtrinhBaoCu.AddOrUpdate(cmbBao.SelectedValue.ToString(), l, (key, oldValue) => l);
            cmbBao.Enabled = true;
        }

        private void frmMophongBao_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Global.GlobalVariables.mapHanhtrinhBao.ContainsKey(cmbBao.SelectedValue.ToString()))
            {
                timer1.Stop();
                lblText.Visible = false;
                DialogResult res = MessageBox.Show("Bão vẫn đang mô phỏng. Bạn có muốn dừng hành trình ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    //lblText.Visible = false;
                    //timer1.Stop();
                    baoBus.huyHanhtrinhBao(Global.GlobalVariables.mapHanhtrinhBao[cmbBao.SelectedValue.ToString()]);
                    int outValue;
                    Global.GlobalVariables.mapHanhtrinhBao.TryRemove(cmbBao.SelectedValue.ToString(), out outValue);
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
