namespace boat.GUI.LinhGUI
{
    partial class frmHanhTrinh
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
            this.dgvHanhTrinh = new System.Windows.Forms.DataGridView();
            this.btnQuanLyViTri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHanhTrinh)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHanhTrinh
            // 
            this.dgvHanhTrinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHanhTrinh.Location = new System.Drawing.Point(12, 21);
            this.dgvHanhTrinh.Name = "dgvHanhTrinh";
            this.dgvHanhTrinh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHanhTrinh.Size = new System.Drawing.Size(260, 150);
            this.dgvHanhTrinh.StandardTab = true;
            this.dgvHanhTrinh.TabIndex = 0;
            this.dgvHanhTrinh.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvHanhTrinh_CellFormatting);
            // 
            // btnQuanLyViTri
            // 
            this.btnQuanLyViTri.Location = new System.Drawing.Point(94, 187);
            this.btnQuanLyViTri.Name = "btnQuanLyViTri";
            this.btnQuanLyViTri.Size = new System.Drawing.Size(93, 33);
            this.btnQuanLyViTri.TabIndex = 1;
            this.btnQuanLyViTri.Text = "Quản Lý Vị Trí";
            this.btnQuanLyViTri.UseVisualStyleBackColor = true;
            this.btnQuanLyViTri.Click += new System.EventHandler(this.btnQuanLyViTri_Click);
            // 
            // frmHanhTrinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 232);
            this.Controls.Add(this.btnQuanLyViTri);
            this.Controls.Add(this.dgvHanhTrinh);
            this.Name = "frmHanhTrinh";
            this.Text = "Hành Trình";
            this.Load += new System.EventHandler(this.frmHanhTrinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHanhTrinh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHanhTrinh;
        private System.Windows.Forms.Button btnQuanLyViTri;
    }
}