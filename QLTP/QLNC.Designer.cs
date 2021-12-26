namespace QLTP
{
    partial class QLNC
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
            this.dgvNC = new System.Windows.Forms.DataGridView();
            this.MaNC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaNC = new System.Windows.Forms.TextBox();
            this.txtTenNC = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TMSI_XoaAll = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_XoaALL = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNC)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvNC
            // 
            this.dgvNC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNC,
            this.TenNC});
            this.dgvNC.Location = new System.Drawing.Point(363, 140);
            this.dgvNC.Name = "dgvNC";
            this.dgvNC.ReadOnly = true;
            this.dgvNC.RowTemplate.Height = 24;
            this.dgvNC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNC.Size = new System.Drawing.Size(485, 297);
            this.dgvNC.TabIndex = 0;
            this.dgvNC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNC_CellContentClick);
            // 
            // MaNC
            // 
            this.MaNC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaNC.HeaderText = "Mã Nơi Chứa";
            this.MaNC.Name = "MaNC";
            this.MaNC.ReadOnly = true;
            // 
            // TenNC
            // 
            this.TenNC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenNC.HeaderText = "Tên Nơi Chứa";
            this.TenNC.Name = "TenNC";
            this.TenNC.ReadOnly = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(27, 305);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(122, 39);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = " Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(188, 305);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(122, 39);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(27, 366);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(122, 39);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(188, 366);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(122, 39);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(0, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(858, 93);
            this.label1.TabIndex = 5;
            this.label1.Text = "Quản Lý Nơi Chứa";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(8, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã Nơi Chứa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(8, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tên Nơi Chứa:";
            // 
            // txtMaNC
            // 
            this.txtMaNC.Location = new System.Drawing.Point(147, 140);
            this.txtMaNC.MaxLength = 10;
            this.txtMaNC.Name = "txtMaNC";
            this.txtMaNC.Size = new System.Drawing.Size(195, 22);
            this.txtMaNC.TabIndex = 8;
            // 
            // txtTenNC
            // 
            this.txtTenNC.Location = new System.Drawing.Point(147, 218);
            this.txtTenNC.Name = "txtTenNC";
            this.txtTenNC.Size = new System.Drawing.Size(195, 22);
            this.txtTenNC.TabIndex = 9;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_XoaALL});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(858, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
           
            // TSMI_XoaALL
            // 
            this.TSMI_XoaALL.Name = "TSMI_XoaALL";
            this.TSMI_XoaALL.Size = new System.Drawing.Size(93, 24);
            this.TSMI_XoaALL.Text = "Xóa Tất Cả";
            this.TSMI_XoaALL.Click += new System.EventHandler(this.TSMI_XoaALL_Click);
            // 
            // QLNC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(858, 449);
            this.Controls.Add(this.txtTenNC);
            this.Controls.Add(this.txtMaNC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvNC);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "QLNC";
            this.Text = "Quản Lý Nơi Chứa";
            this.Load += new System.EventHandler(this.QLNC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNC)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNC;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaNC;
        private System.Windows.Forms.TextBox txtTenNC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNC;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TMSI_XoaAll;
        private System.Windows.Forms.ToolStripMenuItem TSMI_XoaALL;
    }
}