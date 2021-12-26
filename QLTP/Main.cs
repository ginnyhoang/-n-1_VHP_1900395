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
    public partial class Main : Form
    {
       
      

        public Main()
        {
            InitializeComponent();
            ThongBao();
          
        }
        public void ThongBao()
        {
            SqlConnection conn = KetNoi.GetConnection();
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            string sql = "select * from ThucPham where NgayHetHan = (SELECT DATEADD(DAY, DATEDIFF(DAY, 0, GETDATE()), 0) +3) ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Dispose();
            dgvTB.Rows.Clear();
            if (dt.Rows.Count > 0)
            {
                
                    foreach (DataRow dr in dt.Rows) { 
                        DataGridViewRow row = new DataGridViewRow();
                    if (Convert.ToDateTime(row.Cells[2].Value) == DateTime.Today)
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                        row.CreateCells(dgvTB);
                        row.Cells[0].Value = dr[1].ToString().Trim();
                        row.Cells[1].Value = dr[2].ToString().Trim();
                        dgvTB.Rows.Add(row);
                    }
                    else
                    {
                        foreach (DataRow dtr in dt.Rows)
                        {
                            DataGridViewRow r = new DataGridViewRow();
                            row.CreateCells(dgvTB);
                            row.Cells[0].Value = dr[1].ToString().Trim();
                            row.Cells[1].Value = dr[2].ToString().Trim();
                            dgvTB.Rows.Add(row);
                        }
                    }

                }

            }

            conn.Close();
            }
           
        

        private void Main_Load(object sender, EventArgs e)
        {
            ThongBao();
        }

        private void TSMI_QLNC_Click(object sender, EventArgs e)
        {
            QLNC NC = new QLNC();
            NC.ShowDialog();
        }

        private void TSMI_QLLTP_Click(object sender, EventArgs e)
        {
            QLLTP LTP = new QLLTP();
            LTP.ShowDialog();
        }

        private void TSMI_QLTP_Click(object sender, EventArgs e)
        {
            QLTP TP = new QLTP();
            TP.ShowDialog();
            
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                System.Windows.Forms.Application.Exit();
            }
        }
      
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
           
                DialogResult RS = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (RS == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
