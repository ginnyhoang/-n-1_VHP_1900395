namespace QLTP
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Thoat = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_QL = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_QLNC = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_QLLTP = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_QLTP = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvTB = new System.Windows.Forms.DataGridView();
            this.TenTP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayHetHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTB)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.TSMI_QL});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(976, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Thoat});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.hệThốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // TSMI_Thoat
            // 
            this.TSMI_Thoat.Name = "TSMI_Thoat";
            this.TSMI_Thoat.Size = new System.Drawing.Size(181, 26);
            this.TSMI_Thoat.Text = "Thoát";
            this.TSMI_Thoat.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // TSMI_QL
            // 
            this.TSMI_QL.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_QLNC,
            this.TSMI_QLLTP,
            this.TSMI_QLTP});
            this.TSMI_QL.Name = "TSMI_QL";
            this.TSMI_QL.Size = new System.Drawing.Size(73, 24);
            this.TSMI_QL.Text = "Quản Lý";
            // 
            // TSMI_QLNC
            // 
            this.TSMI_QLNC.Name = "TSMI_QLNC";
            this.TSMI_QLNC.Size = new System.Drawing.Size(245, 26);
            this.TSMI_QLNC.Text = "Quản Lý Nơi Chứa";
            this.TSMI_QLNC.Click += new System.EventHandler(this.TSMI_QLNC_Click);
            // 
            // TSMI_QLLTP
            // 
            this.TSMI_QLLTP.Name = "TSMI_QLLTP";
            this.TSMI_QLLTP.Size = new System.Drawing.Size(245, 26);
            this.TSMI_QLLTP.Text = "Quản Lý Loại Thực Phẩm";
            this.TSMI_QLLTP.Click += new System.EventHandler(this.TSMI_QLLTP_Click);
            // 
            // TSMI_QLTP
            // 
            this.TSMI_QLTP.Name = "TSMI_QLTP";
            this.TSMI_QLTP.Size = new System.Drawing.Size(245, 26);
            this.TSMI_QLTP.Text = "Quản Lý Thực Phẩm";
            this.TSMI_QLTP.Click += new System.EventHandler(this.TSMI_QLTP_Click);
            // 
            // dgvTB
            // 
            this.dgvTB.BackgroundColor = System.Drawing.Color.White;
            this.dgvTB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenTP,
            this.NgayHetHan});
            this.dgvTB.Location = new System.Drawing.Point(472, 56);
            this.dgvTB.Name = "dgvTB";
            this.dgvTB.ReadOnly = true;
            this.dgvTB.RowTemplate.Height = 24;
            this.dgvTB.Size = new System.Drawing.Size(492, 215);
            this.dgvTB.TabIndex = 1;
            // 
            // TenTP
            // 
            this.TenTP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenTP.HeaderText = "Tên thực phẩm";
            this.TenTP.Name = "TenTP";
            this.TenTP.ReadOnly = true;
            // 
            // NgayHetHan
            // 
            this.NgayHetHan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayHetHan.HeaderText = "Ngày hết hạn";
            this.NgayHetHan.Name = "NgayHetHan";
            this.NgayHetHan.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(472, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(492, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "DANH SÁCH THỰC PHẨM SẮP HẾT HẠN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(976, 447);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTB);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Thực Phẩm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Thoat;
        private System.Windows.Forms.ToolStripMenuItem TSMI_QL;
        private System.Windows.Forms.ToolStripMenuItem TSMI_QLNC;
        private System.Windows.Forms.ToolStripMenuItem TSMI_QLLTP;
        private System.Windows.Forms.ToolStripMenuItem TSMI_QLTP;
        private System.Windows.Forms.DataGridView dgvTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTP;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayHetHan;
        private System.Windows.Forms.Label label1;
    }
}

