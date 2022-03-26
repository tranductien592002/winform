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
using System.Configuration;

namespace WindowsFormsApp5.GUI
{
    public partial class Hang : Form
    {
        SqlConnection con;
      //  SqlCommand sqlCommand;
        string str = "";
        public Hang()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetHangHoa().Tables[0];
            //Hienthi();
            dataGridView1.AutoSize = true;
         //   dataGridView1.DataMember = "Hang";
        }
        DataSet GetHangHoa()
        {
            //sqlconnection
            //su dung xong la tu dong
            DataSet data = new DataSet();
            string query = "select * from Hang";
            using (SqlConnection connection = new SqlConnection(DAL.connectionString.connection))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }
        public void Hienthi()
        {
            string sqlselect = " select * from Hang";
            SqlCommand cmd = new SqlCommand(sqlselect, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            /*   try
               {
                   string sqlintsert = "insert into Hang values(@Mahang,@Tenhang,@Dongia,@Ghichu)";
                  SqlCommand  cmd = new SqlCommand(sqlintsert, con);
                   cmd.Parameters.AddWithValue("Mahang", txt_maHang.Text);
                   cmd.Parameters.AddWithValue("Tenhang", txt_tenHang.Text);
                   cmd.Parameters.AddWithValue("DonGia", txt_donGia.Text);
                   cmd.Parameters.AddWithValue("Ghichu", txt_ghiChu.Text);
                   cmd.ExecuteNonQuery();
                   GetHangHoa();
             //  }
             //  catch(Exception e1)
             //  {
              //     MessageBox.Show(e1.Message,"Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
             //  }
            */
            dataGridView1.DataSource = GetHoaDonCT().Tables[0];
            //Hienthi();
            dataGridView1.AutoSize = true;
            //   dataGridView1.DataMember = "Hang";
        }
        DataSet GetHoaDonCT()
        {
            //sqlconnection
            //su dung xong la tu dong
            DataSet data = new DataSet();
            string query = "select * from HoaDonCT";
            using (SqlConnection connection = new SqlConnection(DAL.connectionString.connection))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        } 

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetKhachHang().Tables[0];
            //Hienthi();
            dataGridView1.AutoSize = true;
            //   dataGridView1.DataMember = "Hang";
        }
        DataSet GetKhachHang()
        {
            //sqlconnection
            //su dung xong la tu dong
            DataSet data = new DataSet();
            string query = "select * from KhachHang";
            using (SqlConnection connection = new SqlConnection(DAL.connectionString.connection))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetHoaDon().Tables[0];
            //Hienthi();
            dataGridView1.AutoSize = true;
            //   dataGridView1.DataMember = "Hang";
        }
        DataSet GetHoaDon()
        {
            //sqlconnection
            //su dung xong la tu dong
            DataSet data = new DataSet();
            string query = "select * from HoaDon";
            using (SqlConnection connection = new SqlConnection(DAL.connectionString.connection))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }
    
    }
}
