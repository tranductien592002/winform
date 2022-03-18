using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3.GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadDataGridView();
        }
        private DataTable dataTable = new DataTable();
        private void LoadDataGridView()
        {
            dataTable.Columns.Add("Mã Sinh Viên", typeof(string));
            dataTable.Columns.Add("Tên Sinh Viên", typeof(string));
            dataTable.Columns.Add("Ngày Sinh", typeof(string));
            dataTable.Columns.Add("SDT", typeof(string));
            dataTable.Columns.Add("Địa Chỉ", typeof(string));
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        /*    dataGridView1.Columns[0].Width = (int)(dataGridView1.Width * 0.25);
            dataGridView1.Columns[1].Width = (int)(dataGridView1.Width * 0.25);
            dataGridView1.Columns[2].Width = (int)(dataGridView1.Width * 0.25);
            dataGridView1.Columns[3].Width = (int)(dataGridView1.Width * 0.25);
            dataGridView1.Columns[4].Width = (int)(dataGridView1.Width * 0.25);
        */
            }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMSV.Text == "")
            {
                MessageBox.Show("Mã sinh viên không được bỏ trống", "Thông Báo");
                txtMSV.Focus();
                return;
            }
            if (txtTSV.Text == "")
            {
                MessageBox.Show("Tên sinh viên không được bỏ trống", "Thông Báo");
                txtTSV.Focus();
                return;
            }
            if (txtSDT.Text == "")
            {
                MessageBox.Show("Số điện thoại không được bỏ trống", "Thông Báo");
                txtSDT.Focus();
                return;
            }
            dataTable.Rows.Add(txtMSV.Text,txtTSV.Text,dateTimePicker1.Value ,txtSDT.Text, txtDC.Text);
            dataGridView1.DataSource = dataTable;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
            }
            else
            {
                MessageBox.Show("Phải chọn ít nhất 1 dòng để xóa!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
