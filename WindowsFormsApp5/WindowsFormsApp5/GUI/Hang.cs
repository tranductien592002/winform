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

namespace WindowsFormsApp5.GUI
{
    public partial class Hang : Form
    {
        string connection = @"Data Source=LAPTOP-2BLG2VE2\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True";
        public Hang()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetHangHoa().Tables[0];
         //   dataGridView1.DataMember = "Hang";
        }
        DataSet GetHangHoa()
        {
            //sqlconnection
            //su dung xong la tu dong
            DataSet data = new DataSet();
            string query = "select * from Hang";
            using (SqlConnection connection = new SqlConnection())
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
