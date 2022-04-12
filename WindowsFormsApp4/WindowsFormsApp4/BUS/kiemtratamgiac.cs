using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4.BUS
{
    class kiemtratamgiac
    {
        int a, b, c, x, y, z;
        public kiemtratamgiac(TextBox txt_A, TextBox txt_B, TextBox txt_C)
        {
            A = DAL.chuyendoichuoithanhsonguyen.chuyendoi(txt_A.Text);
            B = DAL.chuyendoichuoithanhsonguyen.chuyendoi(txt_B.Text);
            C = DAL.chuyendoichuoithanhsonguyen.chuyendoi(txt_C.Text);
        }
        public int A { get { return this.a; } set { this.a = value; } }
        public int B { get { return this.b; } set { this.b = value; } }
        public int C { get { return this.c; } set { this.c = value; } }
        public int X { get { return this.x; } set { this.x = value; } }
        public int Y { get { return this.y; } set { this.y = value; } }
        public int Z { get { return this.z; } set { this.z = value; } }

        /*    public void kiemtra()
            { x = a * a;
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
        */
        public int TinhCV()
        {
            return A + B + C;
        }
        public int TinhDT()
        {
            int P = (A + B + C) / 2;
            return (int)Math.Sqrt(P * (P - A) * (P - B) * (P - C));
        }
    }
}
