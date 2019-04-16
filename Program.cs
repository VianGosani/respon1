using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrog2324
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan karya = new Karyawan();
            karya.Nik = "1903021123";
            karya.Nama = "Vian";
            karya.GajiBulanan = 5000000;

            Karyawan karya2 = new Karyawan();
            karya2.Nik = "1903021124";
            karya2.Nama = "Gosani";
            karya2.GajiBulanan = 8000000;

            if (karya.GajiBulanan < 0)
                karya.GajiBulanan = 0;
            if (karya2.GajiBulanan < 0)
                karya2.GajiBulanan = 0;

            Console.WriteLine("No Nik\t\tNama\tGaji Bulanan");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("1. {0}\t{1}\t{2}",karya.Nik, karya.Nama, karya.GajiBulanan);
            Console.WriteLine("2. {0}\t{1}\t{2}", karya2.Nik, karya2.Nama, karya2.GajiBulanan);

            Console.WriteLine("");
            Console.WriteLine("Asyiiiiik kenaikan gaji 10%!!");
            Console.WriteLine("");
            
            Console.WriteLine("No Nik\t\tNama\tGaji Bulanan");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("1. {0}\t{1}\t{2}", karya.Nik, karya.Nama, karya.GajiBulanan + karya.GajiBulanan * 0.10);
            Console.WriteLine("2. {0}\t{1}\t{2}", karya2.Nik, karya2.Nama, karya2.GajiBulanan + karya2.GajiBulanan * 0.10);
            Console.ReadKey();
        }
    }
}
