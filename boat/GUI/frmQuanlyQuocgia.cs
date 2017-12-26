using boat.BUS;
using boat.Model.DTO;
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
    public partial class frmQuanlyQuocgia : Form
    {
        QuocgiaBUS quocgiabus = new QuocgiaBUS();
        public frmQuanlyQuocgia()
        {
            InitializeComponent();
        }
        int dem = 0;
        void clear()
        {
            txtmaquocgia.Text = "";
            txttenquocgia.Text = "";
        }
        
        private void frmQuanlyQuocgia_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = quocgiabus.layDanhSachquocgia().Tables[0];
            dataGridView1.Columns["ma"].HeaderText = "Mã Quốc Gia";
            dataGridView1.Columns["tenquocgia"].HeaderText = "Tên Quốc Gia";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmaquocgia.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txttenquocgia.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }


        private void btnthem_Click(object sender, EventArgs e)
        {
            clear();
            dem = 1;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            txtmaquocgia.Enabled = true;
            dem = 2;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("bạn có chắc muốn xóa không ?", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {

                var b = quocgiabus.xoaQUOCGIA(txtmaquocgia.Text);
                if (b == true)
                {
                    MessageBox.Show("Xóa Thành Công");
                    clear();
                    frmQuanlyQuocgia_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Quốc gia này không thể xóa vì có thuyền của quốc gia đang hoạt động");
                    clear();
                    frmQuanlyQuocgia_Load(sender, e);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (dem == 1)
            {
                //them
                quocgiabus.themquocgia(txtmaquocgia.Text, txttenquocgia.Text);
                MessageBox.Show("Thêm Thành Công");
                frmQuanlyQuocgia_Load(sender, e);
            }
            if (dem == 2)
            {
                //update
                txtmaquocgia.Enabled = true;
                quocgiabus.suaquocgia(txtmaquocgia.Text, txttenquocgia.Text);
                MessageBox.Show("Sửa Thành Công");
                frmQuanlyQuocgia_Load(sender, e);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
