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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listViewSV.Columns[0].Width = (int)(listViewSV.Width * 0.35);
            listViewSV.Columns[1].Width = (int)(listViewSV.Width * 0.35);
            // hien thi cot
            listViewSV.View = View.Details;
            //the hien dang mang luoi
            listViewSV.GridLines = true;
            //chon ca 1 dong
            listViewSV.FullRowSelect = true;
        }
    }
}
