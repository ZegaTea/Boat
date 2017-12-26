using boat.ConBaoService;
using boat.GUI.LinhGUI;
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

namespace boat.GUI
{
    public partial class frmQuanlyBao : Form
    {
        private ConBaoServiceClient conBaoServiceClient;
        private ConvertUtils conv;
        private DateUtils dateUtils;
        private DataSet dsConBao;
        private frmThemConBao frmThemConBao;
        public frmQuanlyBao()
        {
            conBaoServiceClient = new ConBaoServiceClient();
            conv = new ConvertUtils();
            dsConBao = new DataSet();
            InitializeComponent();
            showData();
        }

        private void showData()
        {
            dsConBao = conBaoServiceClient.layDanhSachBao();
            dgvDSConBao.DataSource = dsConBao.Tables[0];

            dgvDSConBao.Columns["ma"].HeaderText = "Mã";
            dgvDSConBao.Columns["ma"].Width = 100;
            dgvDSConBao.Columns["tenConBao"].HeaderText = "Tên cơn bão";
            dgvDSConBao.Columns["tenConBao"].Width = 150;
            dgvDSConBao.Columns["ghiChu"].HeaderText = "Ghi Chú";
            dgvDSConBao.Columns["ghiChu"].Width = 200;
            dgvDSConBao.Columns["thoiGianHinhThanh"].HeaderText = "Thời gian hình thành";
            dgvDSConBao.Columns["thoiGianHinhThanh"].Width = 130;
            dgvDSConBao.Columns["maTinhTrang"].HeaderText = "Tình trạng";
            dgvDSConBao.Columns["maTinhTrang"].Width = 100;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemConBao = new frmThemConBao();
            frmThemConBao.ShowDialog();
        }

        private void dgvDSConBao_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvDSConBao.Columns[e.ColumnIndex].Name == "matinhtrang")
            {
                if (e.Value != null)
                {
                    int ma = int.Parse(e.Value.ToString());
                    switch (ma)
                    {
                        case 0:
                            e.Value = "Dự báo";
                            break;
                        case 1:
                            e.Value = "Mới hình thành";
                            break;
                        case 2:
                            e.Value = "Mạnh";
                            break;
                        case 3:
                            e.Value = "Siêu bão";
                            break;
                        case 4:
                            e.Value = "Suy yếu";
                            break;
                        case 5:
                            e.Value = "Áp thấp";
                            break;
                        case 6:
                            e.Value = "Tan";
                            break;

                    }
                }
            }

            if (dgvDSConBao.Columns[e.ColumnIndex].Name == "thoigianhinhthanh")
            {
                if (e.Value != null)
                {
                    long timeStamp = long.Parse(e.Value.ToString());
                    String dateTime = DateUtils.getDateTime(timeStamp);
                    e.Value = dateTime;

                }

            }
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            frmChiTiet frmChitiet = new frmChiTiet(6);
            frmChitiet.ShowDialog();
        }

        private void btnHanhTrinh_Click(object sender, EventArgs e)
        {
            if (dgvDSConBao.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Chưa chọn bản ghi");
                return;
            }
            DataGridViewRow drv = dgvDSConBao.SelectedRows[0];
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

            string maConBao = dr["ma"].ToString();

            frmHanhTrinh frmHanhTrinh = new frmHanhTrinh(maConBao);
            frmHanhTrinh.ShowDialog();
        }
    }
}
