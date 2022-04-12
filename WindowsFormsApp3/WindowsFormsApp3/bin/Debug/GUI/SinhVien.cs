using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.GUI
{
    class SinhVien
    {
        string maSV, tenSV;
        public SinhVien()
        {

        }
        public SinhVien(string maSV, string tenSv)
        {
            this.maSV = maSV;
            this.tenSV = tenSV;
        }
        public string MSV { get { return this.maSV; } set { this.maSV = value; } }
        public string TSV { get { return this.tenSV; } set { this.tenSV = value; } }

    }
}
