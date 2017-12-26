using boat.ConBaoService;
using boat.Util;
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
    public partial class frmQuanLyViTri : Form
    {
        private ConBaoServiceClient conBaoServiceClient;
        private DataSet dsViTri;
        private int maHanhTrinh;
        public frmQuanLyViTri()
        {
            conBaoServiceClient = new ConBaoServiceClient();
            InitializeComponent();
        }

        public frmQuanLyViTri(int maHanhTrinh)
        {
            conBaoServiceClient = new ConBaoServiceClient();
            this.maHanhTrinh = maHanhTrinh;
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemViTriBao frmThemViTriBao = new ThemViTriBao(maHanhTrinh,false);
            frmThemViTriBao.ShowDialog();
        }

        private void frmQuanLyViTri_Load(object sender, EventArgs e)
        {
            dsViTri = conBaoServiceClient.layViTriBao(maHanhTrinh);
            dgvDSViTri.DataSource = dsViTri.Tables[0];

            dgvDSViTri.Columns["kinhdo"].HeaderText = "Kinh Độ";
            dgvDSViTri.Columns["kinhdo"].Width = 100;
            dgvDSViTri.Columns["vido"].HeaderText = "Vĩ Độ";
            dgvDSViTri.Columns["vido"].Width = 100;
            dgvDSViTri.Columns["thoigian"].HeaderText = "Thời gian";
            dgvDSViTri.Columns["thoigian"].Width = 150;
            dgvDSViTri.Columns["vantoc"].HeaderText = "Vận tốc";
            dgvDSViTri.Columns["vantoc"].Width = 100;
        }

        private void dgvDSViTri_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvDSViTri.Columns[e.ColumnIndex].Name == "thoigian")
            {
                if (e.Value != null)
                {
                    long timeStamp = long.Parse(e.Value.ToString());
                    String dateTime = DateUtils.getDateTime(timeStamp);
                    e.Value = dateTime;

                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvDSViTri.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Chưa chọn bản ghi");
                return;
            }
            DataGridViewRow drv = dgvDSViTri.SelectedRows[0];
            DataRowView drview = (DataRowView)drv.DataBoundItem;
            if (drview == null)
            {
                MessageBox.Show("Không lấy được dữ liệu");
                return;
            }
            DataRow dr = drview.Row;
            if (dr == null)
            {
                MessageBox.Show("Không lấy được dữ liệu");
                return;
            }
            string kinhDo = dr["kinhdo"].ToString();
            string viDo = dr["viDo"].ToString();
            string vanToc = dr["vanToc"].ToString();
            ThemViTriBao frmThemViTriBao = new ThemViTriBao(maHanhTrinh,true,kinhDo,viDo,vanToc);
            frmThemViTriBao.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDSViTri.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Chưa chọn bản ghi");
                return;
            }
            DataGridViewRow drv = dgvDSViTri.SelectedRows[0];
            DataRowView drview = (DataRowView)drv.DataBoundItem;
            if (drview == null)
            {
                MessageBox.Show("Không lấy được dữ liệu");
                return;
            }
            DataRow dr = drview.Row;
            if (dr == null)
            {
                MessageBox.Show("Không lấy được dữ liệu");
                return;
            }
            int maVitri = int.Parse(dr["ma"].ToString());

            DialogResult result = MessageBox.Show("Bạn chắc chắn?", "Thông Báo",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                bool ret = conBaoServiceClient.xoaViTriBao(maVitri);
                if (ret)
                {
                    MessageBox.Show("Xoá thành công", "Thông báo");
                    frmQuanLyViTri_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Xoá không thành công", "Thông báo");
                }
            }

        }
    }
}
