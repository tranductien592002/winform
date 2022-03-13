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
    public partial class Form2 : Form
    {
        string strRecei,strRecei1,strRecei2,strRecei3;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Form2(string text)
        {
            Text = text;
        }

        public Form2(string str, string str1, string str2, string str3)
        {
            this.strRecei = str;
            this.strRecei1 = str1;
            this.strRecei2 = str2;
            this.strRecei3 = str3;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txt_xuatMH.Text = strRecei;
            txt_xuatTH.Text = strRecei1;
            txt_xuatDG.Text = strRecei2;
            txt_xuatSL.Text = strRecei3;
        }
    }
}
