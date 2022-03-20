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
    public partial class TamGiac : Form
    {
        int a, b, c, x, y, z;

        private void button3_Click(object sender, EventArgs e)
        {
            FormTinhTong formTinh = new FormTinhTong();
            formTinh.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BUS.kiemtratamgiac kiemtratamgiac = new BUS.kiemtratamgiac(txt_A, txt_B, txt_C);
            txt_KQDT.Text = kiemtratamgiac.TinhDT().ToString();
        }

        private void Thoát_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox[] textBox = new TextBox[] { txt_A,txt_B,txt_C,txt_KQ     };
            BUS.kiemtratamgiac kiemtratamgiac = new BUS.kiemtratamgiac(txt_A, txt_B, txt_C);
            txt_KQ.Text = kiemtratamgiac.TinhCV().ToString();
        }

        public TamGiac()
        {
            InitializeComponent();
        }

        private void btn_ktraTG_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(txt_A.Text);
            b = Convert.ToInt32(txt_B.Text);
            c = Convert.ToInt32(txt_C.Text);
            x = a * a;
                y = b * b;
                z = c * c;
            if (a + b > c && a + c > b && b + c > a)
            {
                if (x == y || y == z || z == x)
                {
                    if (x == y || z == y)
                        txt_ktra.Text = "Tam giác đều";
                    else
                    {
                        if (x == y + z || y == x + z || z == x + y)
                            txt_ktra.Text = "Tam Giác Vuông cân";
                        else
                            txt_ktra.Text = "Tam Giác Cân";
                    }

                }
                else
                {
                    if (x == y + z || y == z + x || z == x + y)
                        txt_ktra.Text = "Tam giác vuông";
                    else
                        txt_ktra.Text = "Tam Giác Thường";
                }
            }
            else
                txt_ktra.Text = "Ba cạnh không tạo thanh tam giác";
        }
    }
}
