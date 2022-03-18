using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.GUI
{
    class SinhVien
    {
        private string maSV, tenSV,sdt,diaChi,ngaySinh;
        public SinhVien()
        {

        }
        public SinhVien(string maSV, string tenSv,string sdt,string diaChi,string ngaySinh)
        {
            this.maSV = maSV;
            this.tenSV = tenSV;
            this.sdt = sdt;
            this.diaChi = diaChi;
            this.ngaySinh = ngaySinh;
        }
        public string MSV { get { return this.maSV; } set { this.maSV = value; } }
        public string TSV { get { return this.tenSV; } set { this.tenSV = value; } }
        public string SDT { get { return this.sdt; } set { this.sdt = value; } }
        public string DC { get { return this.diaChi; } set { this.diaChi = value; } }
        public string NS { get { return this.ngaySinh; } set { this.ngaySinh = value; } }

    }
}
