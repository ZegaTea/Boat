using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using boat.ServiceReferenceTauThuyen_Tuandv;
using System.IO;

namespace boat.GUI
{
    public partial class frmQuanlyTau : Form
    {
        ServiceTauThuyenClient client;
        private int check = 0;
        private string linkImg = "";
        private Tuan_dv_TauThuyenModel t;
        string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
        public frmQuanlyTau()
        {
            InitializeComponent();
            client = new ServiceTauThuyenClient();
            cmbLoaiTau.DataSource = client.layDanhSachLoaiTau().Tables[0];
            cmbLoaiTau.ValueMember = "ma";
            cmbLoaiTau.DisplayMember = "tenloaitau";
            cmbQuocGia.DataSource = client.layDanhSachQuocGia().Tables[0];
            cmbQuocGia.ValueMember = "ma";
            cmbQuocGia.DisplayMember = "tenquocgia";
        }

        private void frmQuanlyTau_Load(object sender, EventArgs e)
        {
            dgvTau.DataSource = client.layDanhSachTau().Tables[0];
                   
        }
      
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            txtMaTau.Enabled = true;
            txtMMSI.Enabled = true;
            txtTaitrong.Enabled = true;
            txtTenTau.Enabled = true;
            cmbLoaiTau.Enabled = true;
            cmbQuocGia.Enabled = true;
            check = 1;
            txtMaTau.Text = "";
            txtMMSI.Text = "";
            txtTaitrong.Text = "";
            txtTenTau.Text = "";
            simpleButton4.Enabled = true;
            simpleButton1.Enabled = false;
            simpleButton2.Enabled = false;
            simpleButton3.Enabled = false;
            simpleButton5.Enabled = true;
            simpleButton6.Enabled = true;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            txtMaTau.Enabled = false;
            txtMMSI.Enabled = true;
            txtTaitrong.Enabled = true;
            txtTenTau.Enabled = true;
            cmbLoaiTau.Enabled = true;
            cmbQuocGia.Enabled = true;
            check = 2;
            simpleButton4.Enabled = true;
            simpleButton1.Enabled = false;
            simpleButton2.Enabled = false;
            simpleButton3.Enabled = false;
            simpleButton5.Enabled = true;
            simpleButton6.Enabled = true;
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            string[] s = linkImg.Split('\\');
            if (check == 1)
            {
                try
                {
                    long.Parse(txtTaitrong.Text);
                }
                catch
                {
                    MessageBox.Show("trọng tải phải nhập số");
                    return;
                }
                string targetPath = path.Substring(0, path.Length - 9) + @"GUI\ImageTau\"+ s[s.Length - 1];
               
                if (!File.Exists(targetPath))
                {
                    System.IO.File.Copy(linkImg, targetPath, true);
                }
                Tuan_dv_TauThuyenModel tau = new Tuan_dv_TauThuyenModel()
                {
                    ma = txtMaTau.Text,
                    maloaitau = cmbLoaiTau.SelectedValue.ToString(),
                    maquocgia = cmbQuocGia.SelectedValue.ToString(),
                    MMSI = txtMMSI.Text,
                    taitrong = long.Parse(txtTaitrong.Text),
                    tentau = txtTenTau.Text,
                    image =s[s.Length - 1]
                   
                };
                if (client.ThemTauThuyen(tau) > 0)
                {
                    MessageBox.Show("Thêm tàu thành công");
                }
                else MessageBox.Show("Thêm tàu thất bại");

            }
            else  if(check==2)
            {
                try
                {
                    long.Parse(txtTaitrong.Text);
                }
                catch
                {
                    MessageBox.Show("trọng tải phải nhập số");
                    return;
                }
                string targetPath = path.Substring(0, path.Length - 9) + @"GUI\ImageTau\" + s[s.Length - 1];

                if (!File.Exists(targetPath))
                {
                    System.IO.File.Copy(linkImg, targetPath, true);
                }
                Tuan_dv_TauThuyenModel tau = new Tuan_dv_TauThuyenModel()
                {
                    ma = txtMaTau.Text,
                    maloaitau = cmbLoaiTau.SelectedValue.ToString(),
                    maquocgia = cmbQuocGia.SelectedValue.ToString(),
                    MMSI = txtMMSI.Text,
                    taitrong = long.Parse(txtTaitrong.Text),
                    tentau = txtTenTau.Text,
                    image =( s[s.Length - 1] != t.image) ? (s[s.Length - 1]):t.image
                };

                if (client.SuaTauThuyen(tau) > 0)
                {
                    MessageBox.Show("Sửa tàu thành công");
                }
                else MessageBox.Show("Sửa tàu thất bại");
            }
            simpleButton4.Enabled = false;
            simpleButton5.Enabled = false;
            simpleButton1.Enabled = true;
            simpleButton2.Enabled = true;
            simpleButton3.Enabled = true;
            simpleButton6.Enabled = false;
            txtMaTau.Enabled = false;
            txtMMSI.Enabled = false;
            txtTaitrong.Enabled = false;
            txtTenTau.Enabled = false;
            cmbLoaiTau.Enabled = false;
            cmbQuocGia.Enabled = false;
            frmQuanlyTau_Load(sender, e);
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
           if( MessageBox.Show("Bạn có chắc chắn muốn xóa?","Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (client.XoaTauThuyen(txtMaTau.Text) > 0)
                {
                    MessageBox.Show("Xóa tàu thành công");
                }
                else MessageBox.Show("Xóa tàu thất bại");
                frmQuanlyTau_Load(sender, e);
            }
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            frmQuanlyTau_Load(sender, e);
            simpleButton5.Enabled = false;
            simpleButton4.Enabled = false;
            simpleButton1.Enabled = true;
            simpleButton2.Enabled = true;
            simpleButton3.Enabled = true;
            simpleButton6.Enabled = false;
            txtMaTau.Enabled = false;
            txtMMSI.Enabled = false;
            txtTaitrong.Enabled = false;
            txtTenTau.Enabled = false;
            cmbLoaiTau.Enabled = false;
            cmbQuocGia.Enabled = false;
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
               linkImg = openFileDialog1.FileName;
                pictureEdit1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void dgvTau_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
               
                t = client.GetTauThuyenById(dgvTau.Rows[e.RowIndex].Cells["MaTau"].Value.ToString());
                if (t != null)
                {
                    txtMaTau.Text = t.ma;
                    txtMMSI.Text = t.MMSI;
                    txtTaitrong.Text = t.taitrong.ToString();
                    txtTenTau.Text = t.tentau;
                    cmbLoaiTau.SelectedItem = t.maloaitau;
                    cmbQuocGia.SelectedItem = t.maquocgia;

                    linkImg= path.Substring(0, path.Length - 9) + @"GUI\ImageTau\" + t.image;
                    pictureEdit1.Image = Image.FromFile(linkImg);

                }
            }
        }

        private void txtMaTau_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
