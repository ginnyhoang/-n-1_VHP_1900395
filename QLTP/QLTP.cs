using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QLTP
{
    public partial class QLTP : Form
    {
        public QLTP()
        {
            InitializeComponent();
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void reset()
        {
            txtMaTP.Text = "";
            txtTenTP.Text = "";
            dtpNgayHetHan.Text = "1/1/2021";
            cbMaloai.Text = "Chọn Mã Loại";
            cbMaNC.Text = "Chọn Mã Nơi Chứa";
        }
        private void LoadData_TP()
        {
            try
            {
                SqlConnection conn = KetNoi.GetConnection();
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string sql = "select* from [dbo].[ThucPham]";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                da.Dispose();
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(dgvTP);
                        row.Cells[0].Value = dr[0].ToString().Trim();
                        row.Cells[1].Value = dr[1].ToString().Trim();
                        row.Cells[2].Value = dr[2].ToString().Trim();
                        row.Cells[3].Value = dr[3].ToString().Trim();
                        row.Cells[4].Value = dr[4].ToString().Trim();
                        dgvTP.Rows.Add(row);
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void loadCbMaLoai()
        {
            try
            {
                SqlConnection conn = KetNoi.GetConnection();
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                string strSQL = "select * from [dbo].[LoaiTP]";
                SqlCommand cmd = new SqlCommand(strSQL, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                da.Dispose();
                conn.Close();
                cbMaloai.DataSource = dt;
                cbMaloai.ValueMember = "MaLoai";
                cbMaloai.DisplayMember = "TenLoai";
            }
            catch (Exception e)
            {
                MessageBox.Show("Error " + e.Message.ToString());
            }
        }
        private void loadCbNC()
        {
            try
            {
                SqlConnection conn = KetNoi.GetConnection();
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                string strSQL = "select * from [dbo].[NoiChua]";
                SqlCommand cmd = new SqlCommand(strSQL, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                da.Dispose();
                conn.Close();
                cbMaNC.DataSource = dt;
                cbMaNC.ValueMember = "MaNC";
                cbMaNC.DisplayMember = "TenNC";
            }
            catch (Exception e)
            {
                MessageBox.Show("Error " + e.Message.ToString());
            }
        }
        private void QLTP_Load(object sender, EventArgs e)
        {
            reset();
            LoadData_TP();
            loadCbNC();
            loadCbMaLoai();
            LockButton(false);
        }
        private void LockButton(bool Add)
        {
            btnThem.Enabled = !Add;
            btnSua.Enabled = Add;
            btnXoa.Enabled = Add;
        }
        private void dgvTP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LockButton(true);
            txtMaTP.Enabled = false;
            int numrow = e.RowIndex;
            txtMaTP.Text = dgvTP.Rows[numrow].Cells[0].Value.ToString();
            txtTenTP.Text = dgvTP.Rows[numrow].Cells[1].Value.ToString();
            dtpNgayHetHan.Text = dgvTP.Rows[numrow].Cells[2].Value.ToString();
            cbMaloai.SelectedValue = dgvTP.Rows[numrow].Cells[3].Value.ToString();
            cbMaNC.SelectedValue = dgvTP.Rows[numrow].Cells[4].Value.ToString();
        }

        private void TSMI_XoaAll_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Rs =
              MessageBox.Show("Bạn có chắc muốn xóa toàn bộ dữ liệu không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (Rs == DialogResult.OK)
                {
                    SqlConnection conn = KetNoi.GetConnection();
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    dgvTP.Rows.Clear();
                    string sql = "Delete from [dbo].[ThucPham]";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    LoadData_TP();
                    MessageBox.Show("Đã xóa toàn bộ dữ liệu", "Thông báo", MessageBoxButtons.OK);
                    conn.Close();
                }
            }
            catch
            {
                LoadData_TP();
                loadCbMaLoai();
                loadCbNC();
                MessageBox.Show("Không thể xóa toàn bộ dữ liệu");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = KetNoi.GetConnection();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string sql = "SELECT * FROM [dbo].[ThucPham] where MaTP ='" + txtMaTP.Text + "'";
            SqlCommand cmd1 = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd1.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Mã thực phẩm đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (txtMaTP.Text.Trim() != "" && txtTenTP.Text.Trim() != "")
                    {

                        SqlConnection Conn = KetNoi.GetConnection();
                        if (Conn.State == ConnectionState.Closed)
                            Conn.Open();
                        dgvTP.Rows.Clear();
                        string SQL = "insert into [dbo].[ThucPham] values (@MaTP, @TenTP,@NgayHetHan,@MaLoai,@MaNC)";
                        SqlCommand cmd = new SqlCommand(SQL, Conn);
                        cmd.Parameters.AddWithValue("@MaTP", txtMaTP.Text.Trim());
                        cmd.Parameters.AddWithValue("@TenTP", txtTenTP.Text.Trim());
                        cmd.Parameters.AddWithValue("@NgayHetHan", dtpNgayHetHan.Value.Date);
                        cmd.Parameters.AddWithValue("@MaLoai", cbMaloai.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@MaNC", cbMaNC.SelectedValue.ToString());
                        cmd.ExecuteNonQuery();
                        reset();
                        LoadData_TP();
                        loadCbNC();
                        loadCbMaLoai();
                        LockButton(false);
                        Conn.Close();

                    }

                    else
                    {
                        MessageBox.Show("Vui lòng nhập mã thực phẩm hoặc tên thực phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.Message);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaTP.Text.Trim() != "" && txtTenTP.Text.Trim() != "")
                {

                    SqlConnection Conn = KetNoi.GetConnection();
                    if (Conn.State == ConnectionState.Closed)
                        Conn.Open();
                    dgvTP.Rows.Clear();
                    string SQL = "update [dbo].[ThucPham] set TenTP =  @TenTP, NgayHetHan = @NgayHetHan, MaLoai = @MaLoai, MaNC = @MaNC where MaTP = @MaTP";
                    SqlCommand cmd = new SqlCommand(SQL, Conn);
                    cmd.Parameters.AddWithValue("@MaTP", txtMaTP.Text.Trim());
                    cmd.Parameters.AddWithValue("@TenTP", txtTenTP.Text.Trim());
                    cmd.Parameters.AddWithValue("@NgayHetHan", dtpNgayHetHan.Value.Date);
                    cmd.Parameters.AddWithValue("@MaLoai", cbMaloai.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@MaNC", cbMaNC.SelectedValue.ToString());
                    cmd.ExecuteNonQuery();
                    reset();
                    LoadData_TP();
                    loadCbNC();
                    loadCbMaLoai();
                    Conn.Close();

                }

                else
                {
                    MessageBox.Show("Vui lòng chọn nơi cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
            LockButton(false);
            txtMaTP.Enabled = true;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (txtMaTP.Text.Trim() == "" || txtTenTP.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn thông tin để xóa", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    SqlConnection Conn = KetNoi.GetConnection();
                    if (Conn.State == ConnectionState.Closed)
                        Conn.Open();
                    dgvTP.Rows.Clear();
                    string SQL = "Delete from [dbo].[ThucPham] where MaTP = @MaTP";
                    SqlCommand cmd = new SqlCommand(SQL, Conn);
                    cmd.Parameters.AddWithValue("@MaTP", txtMaTP.Text.Trim());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã xóa thành công", "Thông báo", MessageBoxButtons.OK);
                    reset();
                    LoadData_TP();
                    loadCbNC();
                    loadCbMaLoai();

                    Conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.Message);
                }
            }

            }
    }
}
