using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        string tentaikhoan = "ductien";
        string matkhau = "ductien";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_TK.Text == "")
            {
                MessageBox.Show("Hãy nhập tài khoản của bạn", "Thông Báo");
                return;
            }
            else {
                if (kiemTradangNhap(txt_TK.Text, txt_MK.Text))
                {
                    GUI.FormTinhTong form = new GUI.FormTinhTong();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sai tên tài khoản hoặc mật khẩu", "Lỗi");
                    txt_TK.Focus();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        bool kiemTradangNhap(string tentaikhoan,string matkhau)
        {
            if(tentaikhoan==this.tentaikhoan && matkhau == this.matkhau)
            {
                return true;
            }
            return false;
        }
    }
}
