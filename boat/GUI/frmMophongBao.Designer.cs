namespace boat.GUI
{
    partial class frmMophongBao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMophongBao));
            this.lblText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDung = new System.Windows.Forms.Button();
            this.btnGui = new System.Windows.Forms.Button();
            this.cmbBao = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(99, 83);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(99, 13);
            this.lblText.TabIndex = 9;
            this.lblText.Text = "Đang gửi tọa độ ... ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Chọn cơn bão";
            // 
            // btnDung
            // 
            this.btnDung.Location = new System.Drawing.Point(165, 119);
            this.btnDung.Name = "btnDung";
            this.btnDung.Size = new System.Drawing.Size(97, 23);
            this.btnDung.TabIndex = 7;
            this.btnDung.Text = "Stop";
            this.btnDung.UseVisualStyleBackColor = true;
            this.btnDung.Click += new System.EventHandler(this.btnDung_Click);
            // 
            // btnGui
            // 
            this.btnGui.Location = new System.Drawing.Point(53, 119);
            this.btnGui.Name = "btnGui";
            this.btnGui.Size = new System.Drawing.Size(97, 23);
            this.btnGui.TabIndex = 6;
            this.btnGui.Text = "Mô phỏng";
            this.btnGui.UseVisualStyleBackColor = true;
            this.btnGui.Click += new System.EventHandler(this.btnGui_Click);
            // 
            // cmbBao
            // 
            this.cmbBao.FormattingEnabled = true;
            this.cmbBao.Location = new System.Drawing.Point(102, 32);
            this.cmbBao.Name = "cmbBao";
            this.cmbBao.Size = new System.Drawing.Size(183, 21);
            this.cmbBao.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMophongBao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 167);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDung);
            this.Controls.Add(this.btnGui);
            this.Controls.Add(this.cmbBao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMophongBao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mô phỏng bão";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMophongBao_FormClosing);
            this.Load += new System.EventHandler(this.frmMophongBao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDung;
        private System.Windows.Forms.Button btnGui;
        private System.Windows.Forms.ComboBox cmbBao;
        private System.Windows.Forms.Timer timer1;
    }
}