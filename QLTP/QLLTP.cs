using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QLTP
{
    public partial class QLLTP : Form
    {
        public QLLTP()
        {
            InitializeComponent();
        }
        private void reset()
        {
            txtMaLoai.Text = "";
            txtTenLoai.Text = "";
       
        }
        private void LoadData_LTP()
        {
            try
            {
                SqlConnection conn = KetNoi.GetConnection();
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string sql = "select* from [dbo].[LoaiTP]";
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
                        row.CreateCells(dgvLTP);
                        row.Cells[0].Value = dr[0].ToString().Trim();
                        row.Cells[1].Value = dr[1].ToString().Trim();
                        dgvLTP.Rows.Add(row);
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LockButton(bool Add)
        {
            btnThem.Enabled = !Add;
            btnSua.Enabled = Add;
            btnXoa.Enabled = Add;
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
                    dgvLTP.Rows.Clear();
                    string sql = "Delete from [dbo].[LoaiTP]";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    LoadData_LTP();
                    MessageBox.Show("Đã xóa toàn bộ dữ liệu", "Thông báo", MessageBoxButtons.OK);
                    conn.Close();
                }
            }
            catch
            {
                LoadData_LTP();
                MessageBox.Show("Không thể xóa toàn bộ dữ liệu");
            }
        }

        private void QLLTP_Load(object sender, EventArgs e)
        {
            reset();
            LoadData_LTP();
            LockButton(false);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            SqlConnection conn = KetNoi.GetConnection();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string sql = "SELECT * FROM [dbo].[LoaiTP] where MaLoai ='" + txtMaLoai.Text + "'";
            SqlCommand cmd1 = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd1.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Mã loại đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (txtMaLoai.Text.Trim() != "" && txtTenLoai.Text.Trim() != "")
                    {

                        SqlConnection Conn = KetNoi.GetConnection();
                        if (Conn.State == ConnectionState.Closed)
                            Conn.Open();
                        dgvLTP.Rows.Clear();
                        string SQL = "insert into [dbo].[LoaiTP] values (@MaLoai, @TenLoai)";
                        SqlCommand cmd = new SqlCommand(SQL, Conn);
                        cmd.Parameters.AddWithValue("@MaLoai", txtMaLoai.Text.Trim());
                        cmd.Parameters.AddWithValue("@TenLoai", txtTenLoai.Text.Trim());
                        cmd.ExecuteNonQuery();
                        reset();
                        LoadData_LTP();
                        LockButton(false);
                        Conn.Close();

                    }

                    else
                    {
                        MessageBox.Show("Vui lòng nhập mã loại hoặc tên loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dgvLTP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LockButton(true);
            txtMaLoai.Enabled = false;
            int numrow = e.RowIndex;
            txtMaLoai.Text = dgvLTP.Rows[numrow].Cells[0].Value.ToString();
            txtTenLoai.Text = dgvLTP.Rows[numrow].Cells[1].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtMaLoai.Text.Trim() != "" && txtTenLoai.Text.Trim() != "")
                {
                    SqlConnection Conn = KetNoi.GetConnection();
                    if (Conn.State == ConnectionState.Closed)
                        Conn.Open();
                    dgvLTP.Rows.Clear();
                    string SQL = "Update [dbo].[LoaiTP] Set TenLoai = @TenLoai where MaLoai = @MaLoai";
                    SqlCommand cmd = new SqlCommand(SQL, Conn);
                    cmd.Parameters.AddWithValue("@MaLoai", txtMaLoai.Text.Trim());
                    cmd.Parameters.AddWithValue("@TenLoai", txtTenLoai.Text.Trim());
                    cmd.ExecuteNonQuery();
                    Conn.Close();
                    reset();
                    LoadData_LTP();
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaLoai.Text.Trim() == "" || txtTenLoai.Text.Trim() == "")
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
                    dgvLTP.Rows.Clear();
                    string SQL = "Delete from [dbo].[LoaiTP] where MaLoai = @MaLoai";
                    SqlCommand cmd = new SqlCommand(SQL, Conn);
                    cmd.Parameters.AddWithValue("@MaLoai", txtMaLoai.Text.Trim());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã xóa thành công", "Thông báo", MessageBoxButtons.OK);
                    reset();
                    LoadData_LTP();
                    Conn.Close();
                }
                catch
                {
                    LoadData_LTP();
                    MessageBox.Show("Không thể xóa loại thực phẩm này\nvì đang tồn tại trong bảng thực phẩm");
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
            txtMaLoai.Enabled = true;
            LockButton(false);
        }
    }
}

