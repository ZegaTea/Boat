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
    public partial class ThemViTriBao : Form
    {
        private ConBaoServiceClient conBaoServiceClient;
        private int maHanhTrinh;
        private bool isForEditing;
        private string kinhDo, viDo, vanToc;
        public ThemViTriBao()
        {
            conBaoServiceClient = new ConBaoServiceClient();
            InitializeComponent();
        }

        public ThemViTriBao(int maHanhTrinh, bool isForEditing)
        {
            conBaoServiceClient = new ConBaoServiceClient();
            this.isForEditing = isForEditing;
            this.maHanhTrinh = maHanhTrinh;
            InitializeComponent();
        }

        public ThemViTriBao(int maHanhTrinh, bool isForEditing, string kinhDo, string viDo, string vanToc)
        {
            conBaoServiceClient = new ConBaoServiceClient();
            this.isForEditing = isForEditing;
            this.maHanhTrinh = maHanhTrinh;
            this.kinhDo = kinhDo;
            this.viDo = viDo;
            this.vanToc = vanToc;
            InitializeComponent();
        }

        private void ThemViTriBao_Load(object sender, EventArgs e)
        {
            if (isForEditing)
            {
                tbKinhDo.Text = kinhDo;
                tbViDo.Text = viDo;
                tbVanToc.Text = vanToc;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            float kinhDo = float.Parse(tbKinhDo.Text);
            float viDo = float.Parse(tbViDo.Text);
            long timeStamp = DateUtils.getTimeInMilis();
            float vanToc = float.Parse(tbVanToc.Text);


            DialogResult result = MessageBox.Show("Bạn chắc chắn?", "Thông Báo",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                bool kqa = false;
                if (!isForEditing)
                {
                    kqa = conBaoServiceClient.themViTriBao(maHanhTrinh, viDo, kinhDo, timeStamp, vanToc);
                }
                else
                {
                    kqa = conBaoServiceClient.suaViTriBao(maHanhTrinh, viDo, kinhDo, timeStamp, vanToc);
                }
                
                if (!kqa)
                {
                    MessageBox.Show("Lỗi ghi dữ liệu", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Thành công!", "Thông báo");
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
