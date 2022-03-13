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
    public partial class Form1 : Form
        
    {
        float Tu1,Tu2,Mau1,Mau2,Tu,Mau,ductien;

        private void btl_Chia_Click(object sender, EventArgs e)
        {
            Tu1 = float.Parse(txt_TS1.Text);
            Tu2 = float.Parse(txt_TS2.Text);
            Mau1 = float.Parse(txt_MS1.Text);
            Mau2 = float.Parse(txt_MS2.Text);
            Tu = (Tu1 * Mau2);
            Mau = (Mau1 * Tu2);
            ductien = USCLN(Tu, Mau);
            txt_toStringTS.Text = Convert.ToString(Tu / ductien);
            txt_toTringMS.Text = Convert.ToString(Mau / ductien);
        }

        private void btTiepTuc_Click(object sender, EventArgs e)
        {
            GUI.Form2 frm = new Form2( txt_toStringTS.Text, txt_toTringMS.Text,txt_TS1.Text,txt_TS2.Text,txt_MS1.Text,txt_MS2.Text);
            this.Hide();
            txt_TS1.ResetText();
            txt_TS2.ResetText();
            txt_MS1.ResetText();
            txt_MS2.ResetText();
            txt_toStringTS.ResetText();
            txt_toTringMS.ResetText();
            Tu = 0; Tu1 = 0; Tu2 = 0;
            Mau = 0; Mau1 = 0; Mau2 = 0;
            ductien = 0;
            frm.ShowDialog();
        }

        private void btl_Nhan_Click(object sender, EventArgs e)
        {
            Tu1 = float.Parse(txt_TS1.Text);
            Tu2 = float.Parse(txt_TS2.Text);
            Mau1 = float.Parse(txt_MS1.Text);
            Mau2 = float.Parse(txt_MS2.Text);
            Tu = ( Tu1 * Tu2 );
            Mau = (Mau1 * Mau2);
            ductien = USCLN(Tu, Mau);
            txt_toStringTS.Text = Convert.ToString(Tu / ductien);
            txt_toTringMS.Text = Convert.ToString(Mau / ductien);
        }

        private void btl_Tru_Click(object sender, EventArgs e)
        {
            Tu1 = float.Parse(txt_TS1.Text);
            Tu2 = float.Parse(txt_TS2.Text);
            Mau1 = float.Parse(txt_MS1.Text);
            Mau2 = float.Parse(txt_MS2.Text);
            Tu = (Tu1 * Mau2) - (Tu2 * Mau1);
            Mau = Mau1 * Mau2;
            ductien = USCLN(Tu, Mau);
            txt_toStringTS.Text = Convert.ToString(Tu / ductien);
            txt_toTringMS.Text = Convert.ToString(Mau / ductien);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
          /* Tu1 = float.Parse(txt_TS1.Text);
           Tu2 = float.Parse(txt_TS2.Text);
           Mau1 = float.Parse(txt_MS1.Text);
           Mau2 = float.Parse(txt_MS2.Text);
          */
        }
        public static float USCLN(float a, float b)
        {
            if (b == 0)
                return a;
            else
                return USCLN(b, a % b);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btc_Cong_Click(object sender, EventArgs e)
        {
            Tu1 = float.Parse(txt_TS1.Text);
            Tu2 = float.Parse(txt_TS2.Text);
            Mau1 = float.Parse(txt_MS1.Text);
            Mau2 = float.Parse(txt_MS2.Text);
            Tu = (Tu1 * Mau2) + (Tu2 * Mau1);
            Mau = (Mau1 * Mau2);
            ductien = USCLN(Tu, Mau);
            txt_toStringTS.Text = Convert.ToString(Tu / ductien);
            txt_toTringMS.Text = Convert.ToString(Mau / ductien);
        }
    }
}
