namespace boat.GUI
{
    partial class frmQuanlyBao
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
            this.dgvDSConBao = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnChiTiet = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnHanhTrinh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSConBao)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDSConBao
            // 
            this.dgvDSConBao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSConBao.Location = new System.Drawing.Point(27, 12);
            this.dgvDSConBao.MultiSelect = false;
            this.dgvDSConBao.Name = "dgvDSConBao";
            this.dgvDSConBao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSConBao.Size = new System.Drawing.Size(724, 282);
            this.dgvDSConBao.TabIndex = 0;
            this.dgvDSConBao.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDSConBao_CellFormatting);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(65, 333);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(92, 38);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm Cơn Bão";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.Location = new System.Drawing.Point(426, 333);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(92, 38);
            this.btnChiTiet.TabIndex = 2;
            this.btnChiTiet.Text = "Xem Chi Tiết";
            this.btnChiTiet.UseVisualStyleBackColor = true;
            this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(626, 333);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(92, 38);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa Cơn Bão";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnHanhTrinh
            // 
            this.btnHanhTrinh.Location = new System.Drawing.Point(225, 333);
            this.btnHanhTrinh.Name = "btnHanhTrinh";
            this.btnHanhTrinh.Size = new System.Drawing.Size(92, 38);
            this.btnHanhTrinh.TabIndex = 4;
            this.btnHanhTrinh.Text = "Hành Trình Bão";
            this.btnHanhTrinh.UseVisualStyleBackColor = true;
            this.btnHanhTrinh.Click += new System.EventHandler(this.btnHanhTrinh_Click);
            // 
            // frmQuanlyBao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 397);
            this.Controls.Add(this.btnHanhTrinh);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnChiTiet);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvDSConBao);
            this.Name = "frmQuanlyBao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Bão";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSConBao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSConBao;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnChiTiet;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnHanhTrinh;
    }
}