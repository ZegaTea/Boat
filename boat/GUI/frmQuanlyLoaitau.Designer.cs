namespace boat.GUI
{
    partial class frmQuanlyLoaitau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanlyLoaitau));
            this.gmapLoaitau = new GMap.NET.WindowsForms.GMapControl();
            this.dgvShipType = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtShipType = new System.Windows.Forms.TextBox();
            this.txtNameShipType = new System.Windows.Forms.TextBox();
            this.txtIDShipType = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShipType)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gmapLoaitau
            // 
            this.gmapLoaitau.Bearing = 0F;
            this.gmapLoaitau.CanDragMap = true;
            this.gmapLoaitau.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmapLoaitau.GrayScaleMode = false;
            this.gmapLoaitau.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmapLoaitau.LevelsKeepInMemmory = 5;
            this.gmapLoaitau.Location = new System.Drawing.Point(12, 24);
            this.gmapLoaitau.MarkersEnabled = true;
            this.gmapLoaitau.MaxZoom = 2;
            this.gmapLoaitau.MinZoom = 2;
            this.gmapLoaitau.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmapLoaitau.Name = "gmapLoaitau";
            this.gmapLoaitau.NegativeMode = false;
            this.gmapLoaitau.PolygonsEnabled = true;
            this.gmapLoaitau.RetryLoadTile = 0;
            this.gmapLoaitau.RoutesEnabled = true;
            this.gmapLoaitau.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmapLoaitau.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmapLoaitau.ShowTileGridLines = false;
            this.gmapLoaitau.Size = new System.Drawing.Size(465, 405);
            this.gmapLoaitau.TabIndex = 1;
            this.gmapLoaitau.Zoom = 0D;
            // 
            // dgvShipType
            // 
            this.dgvShipType.AllowUserToAddRows = false;
            this.dgvShipType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShipType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShipType.Location = new System.Drawing.Point(497, 280);
            this.dgvShipType.Name = "dgvShipType";
            this.dgvShipType.Size = new System.Drawing.Size(357, 149);
            this.dgvShipType.TabIndex = 2;
            this.dgvShipType.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShipType_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã loại tàu";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tnLuu);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtShipType);
            this.groupBox1.Controls.Add(this.txtNameShipType);
            this.groupBox1.Controls.Add(this.txtIDShipType);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(493, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 187);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin loại tàu";
            // 
            // tnLuu
            // 
            this.tnLuu.Location = new System.Drawing.Point(268, 147);
            this.tnLuu.Name = "tnLuu";
            this.tnLuu.Size = new System.Drawing.Size(75, 23);
            this.tnLuu.TabIndex = 14;
            this.tnLuu.Text = "Lưu";
            this.tnLuu.UseVisualStyleBackColor = true;
            this.tnLuu.Click += new System.EventHandler(this.tnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(153, 147);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtShipType
            // 
            this.txtShipType.Location = new System.Drawing.Point(117, 111);
            this.txtShipType.Name = "txtShipType";
            this.txtShipType.Size = new System.Drawing.Size(226, 20);
            this.txtShipType.TabIndex = 8;
            // 
            // txtNameShipType
            // 
            this.txtNameShipType.Location = new System.Drawing.Point(117, 70);
            this.txtNameShipType.Name = "txtNameShipType";
            this.txtNameShipType.Size = new System.Drawing.Size(226, 20);
            this.txtNameShipType.TabIndex = 7;
            // 
            // txtIDShipType
            // 
            this.txtIDShipType.Location = new System.Drawing.Point(117, 28);
            this.txtIDShipType.Name = "txtIDShipType";
            this.txtIDShipType.Size = new System.Drawing.Size(226, 20);
            this.txtIDShipType.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kiểu tàu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên loại tàu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(494, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tìm kiếm";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(549, 237);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // frmQuanlyLoaitau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 441);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvShipType);
            this.Controls.Add(this.gmapLoaitau);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQuanlyLoaitau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý loại tàu";
            this.Load += new System.EventHandler(this.frmQuanlyLoaitau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShipType)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GMap.NET.WindowsForms.GMapControl gmapLoaitau;
        private System.Windows.Forms.DataGridView dgvShipType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtShipType;
        private System.Windows.Forms.TextBox txtNameShipType;
        private System.Windows.Forms.TextBox txtIDShipType;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button tnLuu;
    }
}