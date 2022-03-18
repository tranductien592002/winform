using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listViewbt.Columns[0].Width = (int)(listViewbt.Width * 0.35);
            listViewbt.Columns[1].Width = (int)(listViewbt.Width * 0.35);
            // hien thi cot
            listViewbt.View = View.Details;
            //the hien dang mang luoi
            listViewbt.GridLines = true;
            //chon ca 1 dong
            listViewbt.FullRowSelect = true;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txt_MSV.Text == "")
            {
                MessageBox.Show("Hãy Nhập Mã Sinh Viên!","Thông Báo");
                txt_MSV.Focus();
                return;
            }
            if (txt_hoTen.Text == "")
            {
                MessageBox.Show("Hãy Nhập Họ Tên Sinh Viên", "Thông Báo");
                txt_hoTen.Focus();
                return;
            }
            
                ListViewItem item = listViewbt.Items.Add(txt_MSV.Text);
                item.SubItems.Add(txt_hoTen.Text);
                txt_MSV.Text = "";
                txt_hoTen.Text = "";
                pictureBox1.Image = new Bitmap(Application.StartupPath + "\\GUI\\iphone_12_pro_max_4.jpg");
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (listViewbt.SelectedItems.Count > 0)
            {
                listViewbt.Items.Remove(listViewbt.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Phải chọn ít nhất 1 dòng để xóa!");
            }
        }

        private void btnTT_Click(object sender, EventArgs e)
        {
            GUI.Form1 form1 = new GUI.Form1();
            form1.ShowDialog();
        }
    }
}
