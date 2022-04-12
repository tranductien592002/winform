using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            GUI.Form2 frm = new Form2(txt_maHang.Text,txt_tenHang.Text,txt_donGia.Text,txt_soLuong.Text);
            this.Hide();
            frm.ShowDialog();
            
        }
    }
}
