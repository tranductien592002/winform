using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.GUI
{
    public partial class Form2 : Form
    {
        string strRecei, strRecei1;
        private string text1;

        public Form2()
        {
            InitializeComponent();
        }
        public Form2(string text)
        {
            Text = text;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtXuatTS.Text = strRecei;
            txtXuatMS.Text = strRecei1;
        }

        public Form2(string str, string str1, string str2, string str3, string str4, string text3)
        {
            this.strRecei = str;
            this.strRecei1 = str1;
            InitializeComponent();
        }

        public Form2(string text, string text1) : this(text)
        {
            this.text1 = text1;
        }
    }
}
