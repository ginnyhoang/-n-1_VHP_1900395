namespace QLTP
{
    partial class QLTP
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaTP = new System.Windows.Forms.TextBox();
            this.txtTenTP = new System.Windows.Forms.TextBox();
            this.dtpNgayHetHan = new System.Windows.Forms.DateTimePicker();
            this.dgvTP = new System.Windows.Forms.DataGridView();
            this.MaTP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayHetHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TSMI_XoaAll = new System.Windows.Forms.ToolStripMenuItem();
            this.cbMaloai = new System.Windows.Forms.ComboBox();
            this.cbMaNC = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTP)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(0, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(826, 61);
            this.label1.TabIndex = 16;
            this.label1.Text = "Quản Lý Thực Phẩm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Mã Thực Phẩm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Tên Thực Phẩm:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Ngày Hết Hạn:";
            // 
            // txtMaTP
            // 
            this.txtMaTP.Location = new System.Drawing.Point(164, 87);
            this.txtMaTP.MaxLength = 10;
            this.txtMaTP.Name = "txtMaTP";
            this.txtMaTP.Size = new System.Drawing.Size(257, 22);
            this.txtMaTP.TabIndex = 20;
            // 
            // txtTenTP
            // 
            this.txtTenTP.Location = new System.Drawing.Point(164, 140);
            this.txtTenTP.Name = "txtTenTP";
            this.txtTenTP.Size = new System.Drawing.Size(257, 22);
            this.txtTenTP.TabIndex = 21;
            // 
            // dtpNgayHetHan
            // 
            this.dtpNgayHetHan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayHetHan.Location = new System.Drawing.Point(164, 190);
            this.dtpNgayHetHan.Name = "dtpNgayHetHan";
            this.dtpNgayHetHan.Size = new System.Drawing.Size(257, 22);
            this.dtpNgayHetHan.TabIndex = 22;
            // 
            // dgvTP
            // 
            this.dgvTP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTP,
            this.TenTP,
            this.NgayHetHan,
            this.MaLoai,
            this.MaNC});
            this.dgvTP.Location = new System.Drawing.Point(8, 327);
            this.dgvTP.Name = "dgvTP";
            this.dgvTP.ReadOnly = true;
            this.dgvTP.RowTemplate.Height = 24;
            this.dgvTP.Size = new System.Drawing.Size(806, 316);
            this.dgvTP.TabIndex = 23;
            this.dgvTP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTP_CellContentClick);
            // 
            // MaTP
            // 
            this.MaTP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaTP.HeaderText = "Mã Thực Phẩm";
            this.MaTP.Name = "MaTP";
            this.MaTP.ReadOnly = true;
            // 
            // TenTP
            // 
            this.TenTP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenTP.HeaderText = "Tên Thực Phẩm";
            this.TenTP.Name = "TenTP";
            this.TenTP.ReadOnly = true;
            // 
            // NgayHetHan
            // 
            this.NgayHetHan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayHetHan.HeaderText = "Ngày Hết Hạn";
            this.NgayHetHan.Name = "NgayHetHan";
            this.NgayHetHan.ReadOnly = true;
            // 
            // MaLoai
            // 
            this.MaLoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaLoai.HeaderText = "Mã Loại";
            this.MaLoai.Name = "MaLoai";
            this.MaLoai.ReadOnly = true;
            // 
            // MaNC
            // 
            this.MaNC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaNC.HeaderText = "Mã Nơi Chứa";
            this.MaNC.Name = "MaNC";
            this.MaNC.ReadOnly = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(48, 257);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(91, 34);
            this.btnThem.TabIndex = 24;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(252, 257);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(91, 34);
            this.btnSua.TabIndex = 25;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(660, 257);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(91, 34);
            this.btnReset.TabIndex = 27;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_XoaAll});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(826, 28);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TSMI_XoaAll
            // 
            this.TSMI_XoaAll.Name = "TSMI_XoaAll";
            this.TSMI_XoaAll.Size = new System.Drawing.Size(93, 24);
            this.TSMI_XoaAll.Text = "Xóa Tất Cả";
            this.TSMI_XoaAll.Click += new System.EventHandler(this.TSMI_XoaAll_Click);
            // 
            // cbMaloai
            // 
            this.cbMaloai.FormattingEnabled = true;
            this.cbMaloai.Location = new System.Drawing.Point(601, 87);
            this.cbMaloai.Name = "cbMaloai";
            this.cbMaloai.Size = new System.Drawing.Size(151, 24);
            this.cbMaloai.TabIndex = 29;
            // 
            // cbMaNC
            // 
            this.cbMaNC.FormattingEnabled = true;
            this.cbMaNC.Location = new System.Drawing.Point(601, 140);
            this.cbMaNC.Name = "cbMaNC";
            this.cbMaNC.Size = new System.Drawing.Size(151, 24);
            this.cbMaNC.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(533, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "Mã Loại:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(502, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 32;
            this.label6.Text = "Mã Nơi Chứa:";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(456, 257);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(91, 34);
            this.btnXoa.TabIndex = 33;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // QLTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 705);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbMaNC);
            this.Controls.Add(this.cbMaloai);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvTP);
            this.Controls.Add(this.dtpNgayHetHan);
            this.Controls.Add(this.txtTenTP);
            this.Controls.Add(this.txtMaTP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "QLTP";
            this.Text = " ";
            this.Load += new System.EventHandler(this.QLTP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTP)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaTP;
        private System.Windows.Forms.TextBox txtTenTP;
        private System.Windows.Forms.DateTimePicker dtpNgayHetHan;
        private System.Windows.Forms.DataGridView dgvTP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTP;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayHetHan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNC;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_XoaAll;
        private System.Windows.Forms.ComboBox cbMaloai;
        private System.Windows.Forms.ComboBox cbMaNC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button btnXoa;
    }
}