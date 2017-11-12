namespace boat.GUI
{
    partial class frmGuiToaDo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGuiToaDo));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cmbTau = new System.Windows.Forms.ComboBox();
            this.btnGui = new System.Windows.Forms.Button();
            this.btnDung = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cmbTau
            // 
            this.cmbTau.FormattingEnabled = true;
            this.cmbTau.Location = new System.Drawing.Point(89, 37);
            this.cmbTau.Name = "cmbTau";
            this.cmbTau.Size = new System.Drawing.Size(183, 21);
            this.cmbTau.TabIndex = 0;
            // 
            // btnGui
            // 
            this.btnGui.Location = new System.Drawing.Point(40, 128);
            this.btnGui.Name = "btnGui";
            this.btnGui.Size = new System.Drawing.Size(97, 23);
            this.btnGui.TabIndex = 1;
            this.btnGui.Text = "Gửi tọa độ";
            this.btnGui.UseVisualStyleBackColor = true;
            this.btnGui.Click += new System.EventHandler(this.btnGui_Click);
            // 
            // btnDung
            // 
            this.btnDung.Location = new System.Drawing.Point(152, 128);
            this.btnDung.Name = "btnDung";
            this.btnDung.Size = new System.Drawing.Size(97, 23);
            this.btnDung.TabIndex = 2;
            this.btnDung.Text = "Stop";
            this.btnDung.UseVisualStyleBackColor = true;
            this.btnDung.Click += new System.EventHandler(this.btnDung_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chọn tàu";
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(86, 92);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(99, 13);
            this.lblText.TabIndex = 4;
            this.lblText.Text = "Đang gửi tọa độ ... ";
            // 
            // frmGuiToaDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 185);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDung);
            this.Controls.Add(this.btnGui);
            this.Controls.Add(this.cmbTau);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGuiToaDo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Gửi tọa độ tàu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGuiToaDo_FormClosing);
            this.Load += new System.EventHandler(this.frmGuiToaDo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox cmbTau;
        private System.Windows.Forms.Button btnGui;
        private System.Windows.Forms.Button btnDung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblText;
    }
}