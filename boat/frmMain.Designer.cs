namespace boat
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.gmap = new GMap.NET.WindowsForms.GMapControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mns = new System.Windows.Forms.MenuStrip();
            this.btnThem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanlyTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.bãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baoTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.quanlyBaoTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.rtbState = new System.Windows.Forms.RichTextBox();
            this.cmbTau = new System.Windows.Forms.ComboBox();
            this.btnTheodoi = new System.Windows.Forms.Button();
            this.rtbDanger = new System.Windows.Forms.RichTextBox();
            this.dgvTauDanger = new System.Windows.Forms.DataGridView();
            this.clMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnWarning = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtbWarning = new System.Windows.Forms.RichTextBox();
            this.mns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTauDanger)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.gmap.Location = new System.Drawing.Point(185, 76);
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
            this.gmap.Size = new System.Drawing.Size(426, 444);
            this.gmap.TabIndex = 3;
            this.gmap.Zoom = 13D;
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // mns
            // 
            this.mns.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThem,
            this.quanlyTSMI,
            this.bãoToolStripMenuItem});
            this.mns.Location = new System.Drawing.Point(0, 0);
            this.mns.Name = "mns";
            this.mns.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mns.Size = new System.Drawing.Size(848, 73);
            this.mns.TabIndex = 4;
            this.mns.Text = "menuStrip1";
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(74, 69);
            this.btnThem.Text = "Gửi tọa độ";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // quanlyTSMI
            // 
            this.quanlyTSMI.Image = ((System.Drawing.Image)(resources.GetObject("quanlyTSMI.Image")));
            this.quanlyTSMI.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.quanlyTSMI.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.quanlyTSMI.Name = "quanlyTSMI";
            this.quanlyTSMI.Size = new System.Drawing.Size(60, 69);
            this.quanlyTSMI.Text = "Quản lý";
            this.quanlyTSMI.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.quanlyTSMI.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.quanlyTSMI.Click += new System.EventHandler(this.quanlyTSMI_Click);
            // 
            // bãoToolStripMenuItem
            // 
            this.bãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baoTSMI,
            this.quanlyBaoTSMI});
            this.bãoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bãoToolStripMenuItem.Image")));
            this.bãoToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bãoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bãoToolStripMenuItem.Name = "bãoToolStripMenuItem";
            this.bãoToolStripMenuItem.Size = new System.Drawing.Size(64, 69);
            this.bãoToolStripMenuItem.Text = "Cơn bão";
            this.bãoToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bãoToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // baoTSMI
            // 
            this.baoTSMI.Image = ((System.Drawing.Image)(resources.GetObject("baoTSMI.Image")));
            this.baoTSMI.Name = "baoTSMI";
            this.baoTSMI.Size = new System.Drawing.Size(176, 22);
            this.baoTSMI.Text = "Mô phỏng cơn bão";
            this.baoTSMI.Click += new System.EventHandler(this.baoTSMI_Click);
            // 
            // quanlyBaoTSMI
            // 
            this.quanlyBaoTSMI.Image = ((System.Drawing.Image)(resources.GetObject("quanlyBaoTSMI.Image")));
            this.quanlyBaoTSMI.Name = "quanlyBaoTSMI";
            this.quanlyBaoTSMI.Size = new System.Drawing.Size(176, 22);
            this.quanlyBaoTSMI.Text = "Quản lý bão";
            this.quanlyBaoTSMI.Click += new System.EventHandler(this.quanlyBaoTSMI_Click);
            // 
            // rtbState
            // 
            this.rtbState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbState.Location = new System.Drawing.Point(617, 320);
            this.rtbState.Name = "rtbState";
            this.rtbState.ReadOnly = true;
            this.rtbState.Size = new System.Drawing.Size(232, 200);
            this.rtbState.TabIndex = 5;
            this.rtbState.Text = "-----------------------";
            this.rtbState.TextChanged += new System.EventHandler(this.rtbState_TextChanged);
            // 
            // cmbTau
            // 
            this.cmbTau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTau.FormattingEnabled = true;
            this.cmbTau.Location = new System.Drawing.Point(617, 77);
            this.cmbTau.Name = "cmbTau";
            this.cmbTau.Size = new System.Drawing.Size(146, 21);
            this.cmbTau.TabIndex = 6;
            // 
            // btnTheodoi
            // 
            this.btnTheodoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTheodoi.Location = new System.Drawing.Point(769, 77);
            this.btnTheodoi.Name = "btnTheodoi";
            this.btnTheodoi.Size = new System.Drawing.Size(78, 23);
            this.btnTheodoi.TabIndex = 7;
            this.btnTheodoi.Text = "Theo dõi";
            this.btnTheodoi.UseVisualStyleBackColor = true;
            this.btnTheodoi.Click += new System.EventHandler(this.btnTheodoi_Click);
            // 
            // rtbDanger
            // 
            this.rtbDanger.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbDanger.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDanger.ForeColor = System.Drawing.Color.Red;
            this.rtbDanger.Location = new System.Drawing.Point(617, 106);
            this.rtbDanger.Name = "rtbDanger";
            this.rtbDanger.ReadOnly = true;
            this.rtbDanger.Size = new System.Drawing.Size(232, 208);
            this.rtbDanger.TabIndex = 8;
            this.rtbDanger.Text = "-----------------------";
            this.rtbDanger.TextChanged += new System.EventHandler(this.rtbDanger_TextChanged);
            // 
            // dgvTauDanger
            // 
            this.dgvTauDanger.AllowUserToAddRows = false;
            this.dgvTauDanger.AllowUserToDeleteRows = false;
            this.dgvTauDanger.AllowUserToResizeRows = false;
            this.dgvTauDanger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTauDanger.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMa,
            this.clTen,
            this.btnWarning});
            this.dgvTauDanger.Location = new System.Drawing.Point(0, 19);
            this.dgvTauDanger.Name = "dgvTauDanger";
            this.dgvTauDanger.ReadOnly = true;
            this.dgvTauDanger.Size = new System.Drawing.Size(179, 218);
            this.dgvTauDanger.TabIndex = 9;
            this.dgvTauDanger.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTauDanger_CellClick);
            // 
            // clMa
            // 
            this.clMa.DataPropertyName = "ma";
            this.clMa.HeaderText = "Mã";
            this.clMa.Name = "clMa";
            this.clMa.ReadOnly = true;
            this.clMa.Width = 30;
            // 
            // clTen
            // 
            this.clTen.DataPropertyName = "tentau";
            this.clTen.HeaderText = "Tên";
            this.clTen.Name = "clTen";
            this.clTen.ReadOnly = true;
            this.clTen.Width = 80;
            // 
            // btnWarning
            // 
            this.btnWarning.DataPropertyName = "canhbao";
            this.btnWarning.HeaderText = "";
            this.btnWarning.Name = "btnWarning";
            this.btnWarning.ReadOnly = true;
            this.btnWarning.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnWarning.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnWarning.Width = 65;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.rtbWarning);
            this.groupBox1.Controls.Add(this.dgvTauDanger);
            this.groupBox1.Location = new System.Drawing.Point(0, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 443);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách tàu gặp nguy hiểm";
            // 
            // rtbWarning
            // 
            this.rtbWarning.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rtbWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbWarning.Location = new System.Drawing.Point(0, 243);
            this.rtbWarning.Name = "rtbWarning";
            this.rtbWarning.ReadOnly = true;
            this.rtbWarning.Size = new System.Drawing.Size(179, 194);
            this.rtbWarning.TabIndex = 10;
            this.rtbWarning.Text = "-----------------------";
            this.rtbWarning.TextChanged += new System.EventHandler(this.rtbWarning_TextChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 521);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rtbDanger);
            this.Controls.Add(this.btnTheodoi);
            this.Controls.Add(this.cmbTau);
            this.Controls.Add(this.rtbState);
            this.Controls.Add(this.mns);
            this.Controls.Add(this.gmap);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý tàu thuyền";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mns.ResumeLayout(false);
            this.mns.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTauDanger)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GMap.NET.WindowsForms.GMapControl gmap;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip mns;
        private System.Windows.Forms.ToolStripMenuItem btnThem;
        private System.Windows.Forms.RichTextBox rtbState;
        private System.Windows.Forms.ToolStripMenuItem quanlyTSMI;
        private System.Windows.Forms.ToolStripMenuItem bãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baoTSMI;
        private System.Windows.Forms.ToolStripMenuItem quanlyBaoTSMI;
        private System.Windows.Forms.ComboBox cmbTau;
        private System.Windows.Forms.Button btnTheodoi;
        private System.Windows.Forms.RichTextBox rtbDanger;
        private System.Windows.Forms.DataGridView dgvTauDanger;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTen;
        private System.Windows.Forms.DataGridViewButtonColumn btnWarning;
        private System.Windows.Forms.RichTextBox rtbWarning;
    }
}

