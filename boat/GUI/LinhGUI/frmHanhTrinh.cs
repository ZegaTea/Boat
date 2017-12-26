using boat.ConBaoService;
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
    public partial class frmHanhTrinh : Form
    {
        private ConBaoServiceClient conBaoServiceClient;
        private DataSet dsHanhTrinh;
        private String maConBao;
        public frmHanhTrinh()
        {
            conBaoServiceClient = new ConBaoServiceClient();
            InitializeComponent();
        }

        public frmHanhTrinh(String maConBao)
        {
            conBaoServiceClient = new ConBaoServiceClient();
            this.maConBao = maConBao;
            InitializeComponent();
        }

        private void frmHanhTrinh_Load(object sender, EventArgs e)
        {
            dsHanhTrinh = conBaoServiceClient.layDSHanhTrinh(maConBao);
            dgvHanhTrinh.DataSource = dsHanhTrinh.Tables[0];

            dgvHanhTrinh.Columns["ma"].HeaderText = "Mã";
            dgvHanhTrinh.Columns["ma"].Width = 40;
            dgvHanhTrinh.Columns["trangthai"].HeaderText = "Trạng Thái";
            dgvHanhTrinh.Columns["trangthai"].Width = 100;

        }

        private void btnQuanLyViTri_Click(object sender, EventArgs e)
        {
            if (dgvHanhTrinh.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Chưa chọn bản ghi");
                return;
            }
            DataGridViewRow drv = dgvHanhTrinh.SelectedRows[0];
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

            int maHanhTrinh = int.Parse(dr["ma"].ToString());
            frmQuanLyViTri frmQuanLyViTri = new frmQuanLyViTri(maHanhTrinh);
            frmQuanLyViTri.ShowDialog();
        }

        private void dgvHanhTrinh_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvHanhTrinh.Columns[e.ColumnIndex].Name == "trangthai")
            {
                if (e.Value != null)
                {
                    int ma = int.Parse(e.Value.ToString());
                    switch (ma)
                    {
                        case 0:
                            e.Value = "Đứng Yên";
                            break;
                        case 1:
                            e.Value = "Di chuyển";
                            break;
                    }
                }
            }
        }
    }
}
