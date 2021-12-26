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
    /* 
     * 1. Làm sao để cho người dùng không sửa được trên giao diện
     * 2. Làm sao khi bấm nút reset thì mất dữ liệu
     * 3. Làm sao để không trùng dữ liệu khi bấm nút thêm 1 lần nữa
     * 4. Tại sao khi bấm lên dòng dữ liệu nó không hiện lên thanh textbox
     * 5. Làm sao để khóa người dùng dưới 10 kí tự để phù hợp với Database
     * 6. Tại sao khi bấm vào mã hoặc tên của nơi chứa thì báo lỗi và dừng chương trình
     * 
     */
    public partial class QLNC : Form
    {
        public QLNC()
        {
            InitializeComponent();
        }

        private void LoadData_NC(){
            try
            {
                SqlConnection conn = KetNoi.GetConnection();
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string sql = "select* from [dbo].[NoiChua]";
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
                        row.CreateCells(dgvNC);
                        row.Cells[0].Value = dr[0].ToString().Trim();
                        row.Cells[1].Value = dr[1].ToString().Trim();
                        dgvNC.Rows.Add(row);
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void reset()
        {
            txtMaNC.Text = "";
            txtTenNC.Text = "";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (txtMaNC.Text.Trim() == "" || txtTenNC.Text.Trim() == "")
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
                    dgvNC.Rows.Clear();
                    string SQL = "Delete from [dbo].[NoiChua] where MaNC = @MaNC";
                    SqlCommand cmd = new SqlCommand(SQL, Conn);
                    cmd.Parameters.AddWithValue("@MaNC", txtMaNC.Text.Trim());
                    cmd.Parameters.AddWithValue("@TenNC", txtTenNC.Text.Trim());
                    cmd.ExecuteNonQuery();
                    txtMaNC.Enabled = false;
                    MessageBox.Show("Đã xóa thành công", "Thông báo", MessageBoxButtons.OK);
                    reset();
                    LoadData_NC();
                    Conn.Close();
                }
                catch
                {
                    LoadData_NC();
                    MessageBox.Show("Không thể xóa nơi chứa này\nvì đang tồn tại trong bảng thực phẩm");
                }
            }
        }
        

        private void QLNC_Load(object sender, EventArgs e)
        {
            LoadData_NC();
            LockButton(false);
        }

        private void LockButton(bool Add)
        {
            btnThem.Enabled = !Add;
            btnSua.Enabled = Add;
            btnXoa.Enabled = Add;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            reset();
            txtMaNC.Enabled = true;
            LockButton(false);
        }

       
        private void btnThem_Click(object sender, EventArgs e)

        {

            SqlConnection conn = KetNoi.GetConnection();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string sql = "SELECT * FROM [dbo].[NoiChua] where MaNC ='"+txtMaNC.Text+"'";
            SqlCommand cmd1 = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd1.ExecuteReader();
            if (dr.Read())
            { 
                    MessageBox.Show("Mã nơi chứa đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                else
                {
                    try
                    {
                        if (txtMaNC.Text.Trim() != "" && txtTenNC.Text.Trim() != "")
                        {
                            SqlConnection Conn = KetNoi.GetConnection();
                            if (Conn.State == ConnectionState.Closed)
                                Conn.Open();
                            dgvNC.Rows.Clear();
                            string SQL = "insert into [dbo].[NoiChua] values (@MaNC, @TenNC)";
                            SqlCommand cmd = new SqlCommand(SQL, Conn);
                            cmd.Parameters.AddWithValue("@MaNC", txtMaNC.Text.Trim());
                            cmd.Parameters.AddWithValue("@TenNC", txtTenNC.Text.Trim());
                            cmd.ExecuteNonQuery();
                            reset();
                            LoadData_NC();
                            LockButton(false);
                            Conn.Close();

                        }
                        else
                        {
                            MessageBox.Show("Vui lòng nhập mã nơi chứa hoặc tên nơi chứa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error " + ex.Message);
                    }
                }
            }
        

        private void dgvNC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 
            LockButton(true);
            txtMaNC.Enabled = false;
            int numrow = e.RowIndex;
            txtMaNC.Text = dgvNC.Rows[numrow].Cells[0].Value.ToString();
            txtTenNC.Text = dgvNC.Rows[numrow].Cells[1].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaNC.Text.Trim() != "" && txtTenNC.Text.Trim() != "")
                {
                    SqlConnection Conn = KetNoi.GetConnection();
                    if (Conn.State == ConnectionState.Closed)
                        Conn.Open();
                    dgvNC.Rows.Clear();
                    string SQL = "Update [dbo].[NoiChua] Set TenNC = @TenNC where MaNC = @MaNC";
                    SqlCommand cmd = new SqlCommand(SQL, Conn);
                    cmd.Parameters.AddWithValue("@MaNC", txtMaNC.Text.Trim());
                    cmd.Parameters.AddWithValue("@TenNC", txtTenNC.Text.Trim());
                    cmd.ExecuteNonQuery();
                    Conn.Close();
                    reset();
                    LoadData_NC();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TSMI_XoaALL_Click(object sender, EventArgs e)
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
                    dgvNC.Rows.Clear();
                    string sql = "Delete from [dbo].[NoiChua]";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    LoadData_NC();
                    MessageBox.Show("Đã xóa toàn bộ dữ liệu", "Thông báo", MessageBoxButtons.OK);
                    conn.Close();
                }
            }
            catch
            {
                LoadData_NC();
                MessageBox.Show("Không thể xóa toàn bộ dữ liệu");
              }
            }
           
        }
    }

