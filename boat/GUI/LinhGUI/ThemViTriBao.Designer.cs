namespace boat.GUI.LinhGUI
{
    partial class ThemViTriBao
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
            this.tbKinhDo = new System.Windows.Forms.TextBox();
            this.tbViDo = new System.Windows.Forms.TextBox();
            this.tbVanToc = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.lb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbKinhDo
            // 
            this.tbKinhDo.Location = new System.Drawing.Point(109, 34);
            this.tbKinhDo.Name = "tbKinhDo";
            this.tbKinhDo.Size = new System.Drawing.Size(155, 20);
            this.tbKinhDo.TabIndex = 0;
            // 
            // tbViDo
            // 
            this.tbViDo.Location = new System.Drawing.Point(109, 81);
            this.tbViDo.Name = "tbViDo";
            this.tbViDo.Size = new System.Drawing.Size(155, 20);
            this.tbViDo.TabIndex = 1;
            // 
            // tbVanToc
            // 
            this.tbVanToc.Location = new System.Drawing.Point(109, 140);
            this.tbVanToc.Name = "tbVanToc";
            this.tbVanToc.Size = new System.Drawing.Size(155, 20);
            this.tbVanToc.TabIndex = 2;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(134, 197);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(24, 37);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(44, 13);
            this.lb.TabIndex = 5;
            this.lb.Text = "Kinh độ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Vĩ độ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Vận tốc";
            // 
            // ThemViTriBao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 241);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.tbVanToc);
            this.Controls.Add(this.tbViDo);
            this.Controls.Add(this.tbKinhDo);
            this.Name = "ThemViTriBao";
            this.Text = "ThemViTriBao";
            this.Load += new System.EventHandler(this.ThemViTriBao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbKinhDo;
        private System.Windows.Forms.TextBox tbViDo;
        private System.Windows.Forms.TextBox tbVanToc;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}