namespace QLTP
{
    partial class QLLTP
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
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TSMI_XoaAll = new System.Windows.Forms.ToolStripMenuItem();
            this.txtTenLoai = new System.Windows.Forms.TextBox();
            this.txtMaLoai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvLTP = new System.Windows.Forms.DataGridView();
            this.MaNC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLTP)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(891, 93);
            this.label1.TabIndex = 6;
            this.label1.Text = "Quản Lý Loại Thực Phẩm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_XoaAll});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(891, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TSMI_XoaAll
            // 
            this.TSMI_XoaAll.Name = "TSMI_XoaAll";
            this.TSMI_XoaAll.Size = new System.Drawing.Size(93, 24);
            this.TSMI_XoaAll.Text = "Xóa Tất Cả";
            this.TSMI_XoaAll.Click += new System.EventHandler(this.TSMI_XoaAll_Click);
            // 
            // txtTenLoai
            // 
            this.txtTenLoai.Location = new System.Drawing.Point(118, 189);
            this.txtTenLoai.Name = "txtTenLoai";
            this.txtTenLoai.Size = new System.Drawing.Size(195, 22);
            this.txtTenLoai.TabIndex = 18;
            // 
            // txtMaLoai
            // 
            this.txtMaLoai.Location = new System.Drawing.Point(118, 111);
            this.txtMaLoai.MaxLength = 10;
            this.txtMaLoai.Name = "txtMaLoai";
            this.txtMaLoai.Size = new System.Drawing.Size(200, 22);
            this.txtMaLoai.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(38, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tên Loại:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(38, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Mã Loại:";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(196, 339);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(122, 39);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(35, 339);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(122, 39);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(196, 278);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(122, 39);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(35, 278);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(122, 39);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = " Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvLTP
            // 
            this.dgvLTP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLTP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNC,
            this.TenNC});
            this.dgvLTP.Location = new System.Drawing.Point(364, 111);
            this.dgvLTP.Name = "dgvLTP";
            this.dgvLTP.ReadOnly = true;
            this.dgvLTP.RowTemplate.Height = 24;
            this.dgvLTP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLTP.Size = new System.Drawing.Size(489, 297);
            this.dgvLTP.TabIndex = 10;
            this.dgvLTP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLTP_CellContentClick);
            // 
            // MaNC
            // 
            this.MaNC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaNC.HeaderText = "Mã Loại";
            this.MaNC.Name = "MaNC";
            // 
            // TenNC
            // 
            this.TenNC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenNC.HeaderText = "Tên Loại";
            this.TenNC.Name = "TenNC";
            // 
            // QLLTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 435);
            this.Controls.Add(this.txtTenLoai);
            this.Controls.Add(this.txtMaLoai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvLTP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "QLLTP";
            this.Text = "QLLTP";
            this.Load += new System.EventHandler(this.QLLTP_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLTP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_XoaAll;
        private System.Windows.Forms.TextBox txtTenLoai;
        private System.Windows.Forms.TextBox txtMaLoai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvLTP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNC;
    }
}