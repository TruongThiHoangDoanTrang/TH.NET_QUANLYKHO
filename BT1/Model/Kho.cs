using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1.Model
{
    internal class Kho
    {
        private String MaKho;
        private String TenKho;
        private String DiaChi;

        public Kho() { }

        public Kho(string MaKho, string TenKho, string DiaChi)
        {
            this.MaKho = MaKho;
            this.TenKho = TenKho;
            this.DiaChi = DiaChi;
        }

        public String getMaKho() { return MaKho; }
        public String getTenKho() { return TenKho; } 
        public String getDiaChi() {  return DiaChi; }

        public void setMaKho(String Makho) {  this.MaKho = Makho;}
        public void setTenKho(String TenKho) { this.TenKho= TenKho;}
        public void setDiaChi(String DiaChi) { this.DiaChi= DiaChi;}
    }
}
