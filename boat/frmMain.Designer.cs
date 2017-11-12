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
            this.rtbState = new System.Windows.Forms.RichTextBox();
            this.bãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tạoCơnBãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýBãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mns.SuspendLayout();
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
            this.gmap.Location = new System.Drawing.Point(0, 76);
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
            this.gmap.Size = new System.Drawing.Size(624, 444);
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
            // rtbState
            // 
            this.rtbState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbState.Location = new System.Drawing.Point(630, 76);
            this.rtbState.Name = "rtbState";
            this.rtbState.Size = new System.Drawing.Size(218, 444);
            this.rtbState.TabIndex = 5;
            this.rtbState.Text = "-----------------------";
            // 
            // bãoToolStripMenuItem
            // 
            this.bãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tạoCơnBãoToolStripMenuItem,
            this.quảnLýBãoToolStripMenuItem});
            this.bãoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bãoToolStripMenuItem.Image")));
            this.bãoToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bãoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bãoToolStripMenuItem.Name = "bãoToolStripMenuItem";
            this.bãoToolStripMenuItem.Size = new System.Drawing.Size(60, 69);
            this.bãoToolStripMenuItem.Text = "Bão";
            this.bãoToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bãoToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tạoCơnBãoToolStripMenuItem
            // 
            this.tạoCơnBãoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tạoCơnBãoToolStripMenuItem.Image")));
            this.tạoCơnBãoToolStripMenuItem.Name = "tạoCơnBãoToolStripMenuItem";
            this.tạoCơnBãoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tạoCơnBãoToolStripMenuItem.Text = "Tạo cơn bão";
            // 
            // quảnLýBãoToolStripMenuItem
            // 
            this.quảnLýBãoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quảnLýBãoToolStripMenuItem.Image")));
            this.quảnLýBãoToolStripMenuItem.Name = "quảnLýBãoToolStripMenuItem";
            this.quảnLýBãoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quảnLýBãoToolStripMenuItem.Text = "Quản lý bão";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 521);
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
        private System.Windows.Forms.ToolStripMenuItem tạoCơnBãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýBãoToolStripMenuItem;
    }
}

