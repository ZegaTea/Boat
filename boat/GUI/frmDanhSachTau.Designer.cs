namespace boat.GUI
{
    partial class frmDanhSachTau
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDanhSachTau));
            this.gmap = new GMap.NET.WindowsForms.GMapControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quanlytauTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.quanlyquocgiaTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.quanlyloaitaiTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvTau = new System.Windows.Forms.DataGridView();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbChiTiet = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTaitrong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQuocGia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLoaiTau = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMMSI = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenTau = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaTau = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTau)).BeginInit();
            this.grbChiTiet.SuspendLayout();
            this.SuspendLayout();
            // 
            // gmap
            // 
            this.gmap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gmap.AutoSize = true;
            this.gmap.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gmap.Bearing = 0F;
            this.gmap.CanDragMap = true;
            this.gmap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmap.GrayScaleMode = false;
            this.gmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmap.LevelsKeepInMemmory = 5;
            this.gmap.Location = new System.Drawing.Point(0, 45);
            this.gmap.MarkersEnabled = true;
            this.gmap.MaxZoom = 18;
            this.gmap.MinZoom = 2;
            this.gmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmap.Name = "gmap";
            this.gmap.NegativeMode = false;
            this.gmap.PolygonsEnabled = true;
            this.gmap.RetryLoadTile = 0;
            this.gmap.RoutesEnabled = true;
            this.gmap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmap.ShowTileGridLines = false;
            this.gmap.Size = new System.Drawing.Size(504, 497);
            this.gmap.TabIndex = 6;
            this.gmap.Zoom = 13D;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanlytauTSMI,
            this.quanlyquocgiaTSMI,
            this.quanlyloaitaiTSMI});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(830, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quanlytauTSMI
            // 
            this.quanlytauTSMI.Image = ((System.Drawing.Image)(resources.GetObject("quanlytauTSMI.Image")));
            this.quanlytauTSMI.Name = "quanlytauTSMI";
            this.quanlytauTSMI.Size = new System.Drawing.Size(96, 20);
            this.quanlytauTSMI.Text = "Quản lý tàu";
            this.quanlytauTSMI.Click += new System.EventHandler(this.quanlytauTSMI_Click);
            // 
            // quanlyquocgiaTSMI
            // 
            this.quanlyquocgiaTSMI.Image = ((System.Drawing.Image)(resources.GetObject("quanlyquocgiaTSMI.Image")));
            this.quanlyquocgiaTSMI.Name = "quanlyquocgiaTSMI";
            this.quanlyquocgiaTSMI.Size = new System.Drawing.Size(125, 20);
            this.quanlyquocgiaTSMI.Text = "Quản lý quốc gia";
            this.quanlyquocgiaTSMI.Click += new System.EventHandler(this.quanlyquocgiaTSMI_Click);
            // 
            // quanlyloaitaiTSMI
            // 
            this.quanlyloaitaiTSMI.Image = ((System.Drawing.Image)(resources.GetObject("quanlyloaitaiTSMI.Image")));
            this.quanlyloaitaiTSMI.Name = "quanlyloaitaiTSMI";
            this.quanlyloaitaiTSMI.Size = new System.Drawing.Size(118, 20);
            this.quanlyloaitaiTSMI.Text = "Quản lý loại tàu";
            this.quanlyloaitaiTSMI.Click += new System.EventHandler(this.quanlyloaitaiTSMI_Click);
            // 
            // dgvTau
            // 
            this.dgvTau.AllowUserToAddRows = false;
            this.dgvTau.AllowUserToDeleteRows = false;
            this.dgvTau.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTau.Location = new System.Drawing.Point(510, 314);
            this.dgvTau.Name = "dgvTau";
            this.dgvTau.ReadOnly = true;
            this.dgvTau.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTau.Size = new System.Drawing.Size(308, 221);
            this.dgvTau.TabIndex = 9;
            this.dgvTau.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTau_CellClick);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiem.Location = new System.Drawing.Point(609, 288);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(209, 20);
            this.txtTimKiem.TabIndex = 10;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(521, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tìm kiếm";
            // 
            // grbChiTiet
            // 
            this.grbChiTiet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grbChiTiet.Controls.Add(this.label7);
            this.grbChiTiet.Controls.Add(this.txtTaitrong);
            this.grbChiTiet.Controls.Add(this.label6);
            this.grbChiTiet.Controls.Add(this.txtQuocGia);
            this.grbChiTiet.Controls.Add(this.label5);
            this.grbChiTiet.Controls.Add(this.txtLoaiTau);
            this.grbChiTiet.Controls.Add(this.label4);
            this.grbChiTiet.Controls.Add(this.txtMMSI);
            this.grbChiTiet.Controls.Add(this.label3);
            this.grbChiTiet.Controls.Add(this.txtTenTau);
            this.grbChiTiet.Controls.Add(this.label2);
            this.grbChiTiet.Controls.Add(this.txtMaTau);
            this.grbChiTiet.Location = new System.Drawing.Point(510, 48);
            this.grbChiTiet.Name = "grbChiTiet";
            this.grbChiTiet.Size = new System.Drawing.Size(320, 226);
            this.grbChiTiet.TabIndex = 12;
            this.grbChiTiet.TabStop = false;
            this.grbChiTiet.Text = "Thông tin chi tiết";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Tải trọng";
            // 
            // txtTaitrong
            // 
            this.txtTaitrong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTaitrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaitrong.Location = new System.Drawing.Point(99, 197);
            this.txtTaitrong.Name = "txtTaitrong";
            this.txtTaitrong.ReadOnly = true;
            this.txtTaitrong.Size = new System.Drawing.Size(209, 20);
            this.txtTaitrong.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Quốc gia";
            // 
            // txtQuocGia
            // 
            this.txtQuocGia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuocGia.Location = new System.Drawing.Point(99, 164);
            this.txtQuocGia.Name = "txtQuocGia";
            this.txtQuocGia.ReadOnly = true;
            this.txtQuocGia.Size = new System.Drawing.Size(209, 20);
            this.txtQuocGia.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Loại tàu";
            // 
            // txtLoaiTau
            // 
            this.txtLoaiTau.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLoaiTau.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoaiTau.Location = new System.Drawing.Point(99, 127);
            this.txtLoaiTau.Name = "txtLoaiTau";
            this.txtLoaiTau.ReadOnly = true;
            this.txtLoaiTau.Size = new System.Drawing.Size(209, 20);
            this.txtLoaiTau.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "MMSI";
            // 
            // txtMMSI
            // 
            this.txtMMSI.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMMSI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMMSI.Location = new System.Drawing.Point(99, 90);
            this.txtMMSI.Name = "txtMMSI";
            this.txtMMSI.ReadOnly = true;
            this.txtMMSI.Size = new System.Drawing.Size(209, 20);
            this.txtMMSI.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Tên tàu";
            // 
            // txtTenTau
            // 
            this.txtTenTau.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenTau.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTau.Location = new System.Drawing.Point(99, 54);
            this.txtTenTau.Name = "txtTenTau";
            this.txtTenTau.ReadOnly = true;
            this.txtTenTau.Size = new System.Drawing.Size(209, 20);
            this.txtTenTau.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mã tàu";
            // 
            // txtMaTau
            // 
            this.txtMaTau.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaTau.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTau.Location = new System.Drawing.Point(99, 22);
            this.txtMaTau.Name = "txtMaTau";
            this.txtMaTau.ReadOnly = true;
            this.txtMaTau.Size = new System.Drawing.Size(209, 20);
            this.txtMaTau.TabIndex = 12;
            // 
            // frmDanhSachTau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 543);
            this.Controls.Add(this.grbChiTiet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.dgvTau);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.gmap);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmDanhSachTau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý";
            this.Load += new System.EventHandler(this.frmDanhSachTau_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTau)).EndInit();
            this.grbChiTiet.ResumeLayout(false);
            this.grbChiTiet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GMap.NET.WindowsForms.GMapControl gmap;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quanlytauTSMI;
        private System.Windows.Forms.ToolStripMenuItem quanlyquocgiaTSMI;
        private System.Windows.Forms.ToolStripMenuItem quanlyloaitaiTSMI;
        private System.Windows.Forms.DataGridView dgvTau;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbChiTiet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtQuocGia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLoaiTau;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMMSI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenTau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaTau;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTaitrong;
    }
}