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
    public partial class frmThemConBao : Form
    {
        private ConBaoServiceClient conBaoServiceClient;
        public frmThemConBao()
        {
            conBaoServiceClient = new ConBaoServiceClient();
            InitializeComponent();
            loadForm();
        }

        private void loadForm()
        {
            DataSet tinhTrang = conBaoServiceClient.layTinhTrang();
            cbTinhTrang.DataSource = tinhTrang.Tables["tinhtrang"];
            cbTinhTrang.DisplayMember = "tinhtrang";
            cbTinhTrang.ValueMember = "ma";

            cbTrangThai.Items.Add("Đứng yên");
            cbTrangThai.Items.Add("Di chuyển");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            String name = tbTenConBao.Text;
            String ghiChu = rtbGhiChu.Text;
            DateTime chosenTime = dtpThoiGian.Value;
            long timeStamp = DateUtils.convertToTimeMilis(chosenTime);
            int tinhTrang = 0;
            if(cbTinhTrang.ValueMember != null)
            {
               tinhTrang = int.Parse(cbTinhTrang.SelectedValue.ToString());
            }
            int trangThai = 0;
            if(cbTrangThai.SelectedItem != null)
            {
                object item = cbTrangThai.SelectedItem;
                if (item.Equals("Đứng yên")){
                    trangThai = 0;
                }
                else if(item.Equals("Di chuyển"))
                {
                    trangThai = 1;
                }
            }
            
            

            DialogResult result = MessageBox.Show("Bạn chắc chắn?", "Thông Báo",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                bool kqa = conBaoServiceClient.themConBao(name,ghiChu,timeStamp,tinhTrang,trangThai);
                if (!kqa)
                {
                    MessageBox.Show("Lỗi ghi dữ liệu", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo");
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }

            this.Dispose();
        }
    }
}
