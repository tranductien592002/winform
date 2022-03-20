using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp4.BUS
{
    class ClasstinhTong
    {
        public int so1;
        public int so2;
        public ClasstinhTong()
        {

        }
        public ClasstinhTong(int so1, int so2)
        {
            this.so1 = so1;
            this.so2 = so2;
        }
        public int SO1 { get { return this.so1; } set { this.so1 = value; } }
        public int SO2 { get { return this.so2; } set { this.so2 = value; } }

        public ClasstinhTong(TextBox txt_so1, TextBox txt_so2)
        {
            SO1 = DAL.chuyendoichuoithanhsonguyen.chuyendoi(txt_so1.Text);
            SO2 = DAL.chuyendoichuoithanhsonguyen.chuyendoi(txt_so2.Text);
        }
        
        public int TinhTong()
        {
            return SO1 + SO2;
        }
    }
}
