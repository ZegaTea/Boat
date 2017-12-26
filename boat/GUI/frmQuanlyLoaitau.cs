using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using boat.ShipTypeServiceReference;
using GMap.NET;
using GMap.NET.MapProviders;

namespace boat.GUI
{
    public partial class frmQuanlyLoaitau : Form
    {
        private LoaiTauServiceClient shipTypeService = new LoaiTauServiceClient();
        private DataSet ListShipType = new DataSet();
        public frmQuanlyLoaitau()
        {
            InitializeComponent();
        }

        private void frmQuanlyLoaitau_Load(object sender, EventArgs e)
        {
            
            gmapLoaitau.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gmapLoaitau.MapProvider = GMapProviders.GoogleMap;
            gmapLoaitau.ShowCenter = false;
            gmapLoaitau.DisableFocusOnMouseEnter = true;
            gmapLoaitau.DragButton = MouseButtons.Left;
            gmapLoaitau.Zoom = 6;
            gmapLoaitau.Position = new GMap.NET.PointLatLng(16.197737, 108.835373);
           // gmapLoaitau.SetPositionByKeywords("Hanoi , Vietnam");

            loadDGV();
        }

        private void loadDGV()
        {
            ListShipType = shipTypeService.getListTypesShip1();
            dgvShipType.DataSource = ListShipType.Tables[0];
            dgvShipType.Columns["ma"].HeaderText = "Mã loại tàu";
            dgvShipType.Columns["tenloaitau"].HeaderText = "Tên loại tàu";
            dgvShipType.Columns["kieutau"].HeaderText = "Kiểu tàu";
        }

        private void dgvShipType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDShipType.Text = dgvShipType.CurrentRow.Cells["ma"].Value.ToString();
            txtNameShipType.Text = dgvShipType.CurrentRow.Cells["tenloaitau"].Value.ToString();
            txtShipType.Text = dgvShipType.CurrentRow.Cells["kieutau"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtIDShipType.Text = string.Empty;
            txtNameShipType.Text = string.Empty;
            txtShipType.Text = string.Empty;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtNameShipType.Text == "" || txtShipType.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
                return;
            }
            loaitau lt = new loaitau();
            lt.ma = txtIDShipType.Text;
            lt.tenloaitau = txtNameShipType.Text;
            lt.kieutau = txtShipType.Text;
            if (MessageBox.Show(string.Format("Sửa loại tàu"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (shipTypeService.UpdateTypesShip(lt ) == 0)
                {
                    MessageBox.Show("Đã sửa thành công!");
                    frmQuanlyLoaitau_Load(sender, e);
                }
                else MessageBox.Show("Thông tin chưa được sửa");
            }
        }

        private void tnLuu_Click(object sender, EventArgs e)
        {
            if (txtNameShipType.Text == "" || txtShipType.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
                return;
            }
            loaitau lt = new loaitau();
            lt.ma = txtIDShipType.Text;
            lt.tenloaitau = txtNameShipType.Text;
            lt.kieutau = txtShipType.Text;
            if (MessageBox.Show(string.Format("Thêm loại tàu "), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (shipTypeService.InsertTypesShip(lt) == 0)
                {
                    MessageBox.Show("Đã thêm thành công!");
                    frmQuanlyLoaitau_Load(sender, e);
                }
                else MessageBox.Show("Thông tin chưa được thêm");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string str = string.Format("ma like '%{0}%' or tenloaitau like '%{0}%' or kieutau like '%{0}%'", textBox1.Text.ToString());
            ListShipType.Tables["loaitau"].DefaultView.RowFilter = str;
        }
    }
}
