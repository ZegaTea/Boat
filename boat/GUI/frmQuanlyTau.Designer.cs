namespace boat.GUI
{
    partial class frmQuanlyTau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanlyTau));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaTau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenTau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MMSI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.taitrong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LoaiTau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tenquocgia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.image = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.grbChiTiet = new System.Windows.Forms.GroupBox();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.lookUpEditQuocGia = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpEditLoaiTau = new DevExpress.XtraEditors.LookUpEdit();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txtTaitrong = new DevExpress.XtraEditors.TextEdit();
            this.txtMMSI = new DevExpress.XtraEditors.TextEdit();
            this.txtTenTau = new DevExpress.XtraEditors.TextEdit();
            this.txtMaTau = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.grbChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditQuocGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditLoaiTau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaitrong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMMSI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaTau.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1,
            this.repositoryItemCheckEdit1});
            this.gridControl1.Size = new System.Drawing.Size(503, 394);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaTau,
            this.TenTau,
            this.MMSI,
            this.taitrong,
            this.LoaiTau,
            this.tenquocgia,
            this.image});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // MaTau
            // 
            this.MaTau.Caption = "Mã tàu";
            this.MaTau.FieldName = "MaTau";
            this.MaTau.Name = "MaTau";
            this.MaTau.Visible = true;
            this.MaTau.VisibleIndex = 0;
            // 
            // TenTau
            // 
            this.TenTau.Caption = "Tên tàu";
            this.TenTau.FieldName = "TenTau";
            this.TenTau.Name = "TenTau";
            this.TenTau.Visible = true;
            this.TenTau.VisibleIndex = 1;
            // 
            // MMSI
            // 
            this.MMSI.Caption = "MMSI";
            this.MMSI.FieldName = "MMSI";
            this.MMSI.Name = "MMSI";
            this.MMSI.Visible = true;
            this.MMSI.VisibleIndex = 2;
            // 
            // taitrong
            // 
            this.taitrong.Caption = "Tải trọng";
            this.taitrong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.taitrong.FieldName = "taitrong";
            this.taitrong.Name = "taitrong";
            this.taitrong.Visible = true;
            this.taitrong.VisibleIndex = 3;
            // 
            // LoaiTau
            // 
            this.LoaiTau.Caption = "Loại tàu";
            this.LoaiTau.FieldName = "LoaiTau";
            this.LoaiTau.Name = "LoaiTau";
            this.LoaiTau.Visible = true;
            this.LoaiTau.VisibleIndex = 4;
            // 
            // tenquocgia
            // 
            this.tenquocgia.Caption = "Quốc gia";
            this.tenquocgia.FieldName = "tenquocgia";
            this.tenquocgia.Name = "tenquocgia";
            this.tenquocgia.Visible = true;
            this.tenquocgia.VisibleIndex = 5;
            // 
            // image
            // 
            this.image.Caption = "image";
            this.image.ColumnEdit = this.repositoryItemCheckEdit1;
            this.image.FieldName = "image";
            this.image.Name = "image";
            this.image.Visible = true;
            this.image.VisibleIndex = 6;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit1.Location = new System.Drawing.Point(33, 33);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(205, 96);
            this.pictureEdit1.TabIndex = 1;
            // 
            // grbChiTiet
            // 
            this.grbChiTiet.Controls.Add(this.simpleButton6);
            this.grbChiTiet.Controls.Add(this.simpleButton5);
            this.grbChiTiet.Controls.Add(this.lookUpEditQuocGia);
            this.grbChiTiet.Controls.Add(this.lookUpEditLoaiTau);
            this.grbChiTiet.Controls.Add(this.simpleButton4);
            this.grbChiTiet.Controls.Add(this.simpleButton3);
            this.grbChiTiet.Controls.Add(this.simpleButton2);
            this.grbChiTiet.Controls.Add(this.simpleButton1);
            this.grbChiTiet.Controls.Add(this.txtTaitrong);
            this.grbChiTiet.Controls.Add(this.txtMMSI);
            this.grbChiTiet.Controls.Add(this.txtTenTau);
            this.grbChiTiet.Controls.Add(this.txtMaTau);
            this.grbChiTiet.Controls.Add(this.label7);
            this.grbChiTiet.Controls.Add(this.pictureEdit1);
            this.grbChiTiet.Controls.Add(this.label6);
            this.grbChiTiet.Controls.Add(this.label5);
            this.grbChiTiet.Controls.Add(this.label4);
            this.grbChiTiet.Controls.Add(this.label3);
            this.grbChiTiet.Controls.Add(this.label2);
            this.grbChiTiet.Dock = System.Windows.Forms.DockStyle.Right;
            this.grbChiTiet.Location = new System.Drawing.Point(509, 0);
            this.grbChiTiet.Name = "grbChiTiet";
            this.grbChiTiet.Size = new System.Drawing.Size(307, 398);
            this.grbChiTiet.TabIndex = 13;
            this.grbChiTiet.TabStop = false;
            this.grbChiTiet.Text = "Thông tin chi tiết";
            // 
            // simpleButton6
            // 
            this.simpleButton6.Enabled = false;
            this.simpleButton6.Location = new System.Drawing.Point(243, 106);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(58, 23);
            this.simpleButton6.TabIndex = 37;
            this.simpleButton6.Text = "Browse";
            this.simpleButton6.Click += new System.EventHandler(this.simpleButton6_Click);
            // 
            // simpleButton5
            // 
            this.simpleButton5.Enabled = false;
            this.simpleButton5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton5.ImageOptions.Image")));
            this.simpleButton5.Location = new System.Drawing.Point(188, 363);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(54, 23);
            this.simpleButton5.TabIndex = 36;
            this.simpleButton5.Text = "Hủy";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // lookUpEditQuocGia
            // 
            this.lookUpEditQuocGia.Enabled = false;
            this.lookUpEditQuocGia.Location = new System.Drawing.Point(102, 292);
            this.lookUpEditQuocGia.Name = "lookUpEditQuocGia";
            this.lookUpEditQuocGia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditQuocGia.Size = new System.Drawing.Size(136, 20);
            this.lookUpEditQuocGia.TabIndex = 35;
            // 
            // lookUpEditLoaiTau
            // 
            this.lookUpEditLoaiTau.Enabled = false;
            this.lookUpEditLoaiTau.Location = new System.Drawing.Point(102, 257);
            this.lookUpEditLoaiTau.Name = "lookUpEditLoaiTau";
            this.lookUpEditLoaiTau.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditLoaiTau.Size = new System.Drawing.Size(136, 20);
            this.lookUpEditLoaiTau.TabIndex = 34;
            // 
            // simpleButton4
            // 
            this.simpleButton4.Enabled = false;
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(131, 363);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(54, 23);
            this.simpleButton4.TabIndex = 33;
            this.simpleButton4.Text = "Lưu";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(246, 363);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(52, 23);
            this.simpleButton3.TabIndex = 32;
            this.simpleButton3.Text = "Xóa";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(74, 363);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(50, 23);
            this.simpleButton2.TabIndex = 31;
            this.simpleButton2.Text = "Sửa";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(9, 363);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(58, 23);
            this.simpleButton1.TabIndex = 30;
            this.simpleButton1.Text = "Thêm";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txtTaitrong
            // 
            this.txtTaitrong.Enabled = false;
            this.txtTaitrong.Location = new System.Drawing.Point(102, 325);
            this.txtTaitrong.Name = "txtTaitrong";
            this.txtTaitrong.Size = new System.Drawing.Size(136, 20);
            this.txtTaitrong.TabIndex = 29;
            // 
            // txtMMSI
            // 
            this.txtMMSI.Enabled = false;
            this.txtMMSI.Location = new System.Drawing.Point(102, 218);
            this.txtMMSI.Name = "txtMMSI";
            this.txtMMSI.Size = new System.Drawing.Size(136, 20);
            this.txtMMSI.TabIndex = 28;
            // 
            // txtTenTau
            // 
            this.txtTenTau.Enabled = false;
            this.txtTenTau.Location = new System.Drawing.Point(102, 182);
            this.txtTenTau.Name = "txtTenTau";
            this.txtTenTau.Size = new System.Drawing.Size(136, 20);
            this.txtTenTau.TabIndex = 27;
            // 
            // txtMaTau
            // 
            this.txtMaTau.Enabled = false;
            this.txtMaTau.Location = new System.Drawing.Point(102, 147);
            this.txtMaTau.Name = "txtMaTau";
            this.txtMaTau.Size = new System.Drawing.Size(136, 20);
            this.txtMaTau.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Tải trọng";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Quốc gia";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Loại tàu";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "MMSI";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Tên tàu";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mã tàu";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "(*.png)|*.(jpg)";
            this.openFileDialog1.FilterIndex = 2;
            this.openFileDialog1.RestoreDirectory = true;
            // 
            // frmQuanlyTau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 398);
            this.Controls.Add(this.grbChiTiet);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmQuanlyTau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQuanlyTau";
            this.Load += new System.EventHandler(this.frmQuanlyTau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.grbChiTiet.ResumeLayout(false);
            this.grbChiTiet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditQuocGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditLoaiTau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaitrong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMMSI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaTau.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn MaTau;
        private DevExpress.XtraGrid.Columns.GridColumn TenTau;
        private DevExpress.XtraGrid.Columns.GridColumn MMSI;
        private DevExpress.XtraGrid.Columns.GridColumn taitrong;
        private DevExpress.XtraGrid.Columns.GridColumn LoaiTau;
        private DevExpress.XtraGrid.Columns.GridColumn tenquocgia;
        private DevExpress.XtraGrid.Columns.GridColumn image;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private System.Windows.Forms.GroupBox grbChiTiet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtTaitrong;
        private DevExpress.XtraEditors.TextEdit txtMMSI;
        private DevExpress.XtraEditors.TextEdit txtTenTau;
        private DevExpress.XtraEditors.TextEdit txtMaTau;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditQuocGia;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditLoaiTau;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}