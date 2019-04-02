using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int hasil;
            Calculator cal = new Calculator();
            hasil = cal.Penjumlahan(10, 2);
            CetakHasil("Hasil Penjumlahan = " + hasil);
            hasil = cal.Penjumlahan(10, 2, 3);
            CetakHasil("Hasil Penjumlahan overload = " + hasil);
            hasil = cal.Pengurangan(7, 2);
            CetakHasil("Hasil Pengurangan = " + hasil);
            hasil = Calculator.Perkalian(5, 2);
            CetakHasil("Hasil Perkalian = " + hasil);
            Console.ReadKey();
        }
        static void CetakHasil(string hasil)
        {
            Console.WriteLine(hasil);
        }
    }
}
