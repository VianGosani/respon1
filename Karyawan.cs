using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrog2324
{
    class Karyawan
    {
        private string nik;
        private string nama;
        private int gaji;

        // public string Nik { get; set; }
        // public string Nama { get; set; }
        // public int GajiBulanan { get; set; }
        
        public string Nik
        {
            get { return nik; }
            set { nik = value; }
        }
        public string Nama
        {
            get { return nama; }
            set { nama = value; }
        }
        public int GajiBulanan
        {
            get { return gaji; }
            set { gaji = value; }
        }
    }
}
