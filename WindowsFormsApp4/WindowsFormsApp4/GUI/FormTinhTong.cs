using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4.GUI
{
    public partial class FormTinhTong : Form
    {
        public FormTinhTong()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TextBox[] textBox = new TextBox[] { txt_ToString, txt_so1, txt_so2 };
            this.Close();
            Form1 form = new Form1();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BUS.ClasstinhTong classtinhTong = new BUS.ClasstinhTong(txt_so1, txt_so2);
            txt_ToString.Text = classtinhTong.TinhTong().ToString();
        }

        private void FormTinhTong_Load(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TamGiac tamGiac = new TamGiac();
            tamGiac.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
