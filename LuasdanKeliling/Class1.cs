using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuasdanKeliling
{
    class Persegi
    {
        protected
        double s1 , s2, s3, L, K;

        public void HitungPersegi()
        {
            try
            {
                Console.WriteLine();
                Console.Write("Masukan Sisi = ");
                s1 = double.Parse(Console.ReadLine());
                L = s1 * s1;
                K = 4 * s1;

                Console.WriteLine();
                Console.WriteLine("Luas Persegi = " + L.ToString());
                Console.WriteLine("==================================");
                Console.WriteLine("Keliling Persegi = " + K.ToString());
            }
            catch (FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("ERROR !!");
                Console.WriteLine("FORMAT YANG ANDA MASUKAN SALAH");
            }
        }
    }

    class PersegiPanjang : Persegi
    {
        public void HitungPersegiPanjang()
        {
            try
            {
                Console.WriteLine();
                Console.Write("Masukan Panjang = ");
                s1 = double.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Masukan Lebar = ");
                s2 = double.Parse(Console.ReadLine());
                L = s1 * s2;
                K = 2 * (s1 + s2);

                Console.WriteLine();
                Console.WriteLine("Luas Persegi Panjang = " + L.ToString());
                Console.WriteLine("==================================");
                Console.WriteLine("Keliling Persegi Panjang = " + K.ToString());
            }
            catch (FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("ERROR !!");
                Console.WriteLine("FORMAT YANG ANDA MASUKAN SALAH");
            }
        }
    }

    class Jajargenjang : Persegi
    {
        public void HitungJajarGenjang()
        {
            try
            {
                Console.WriteLine();
                Console.Write("Masukan Alas = ");
                s1 = double.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Masukan Tinggi = ");
                s2 = double.Parse(Console.ReadLine());
                L = s1 * s2;
                K = 2 * (s1 + s2);

                Console.WriteLine();
                Console.WriteLine("Luas Jajar Genjang = " + L.ToString());
                Console.WriteLine("==================================");
                Console.WriteLine("Keliling Jajar Genjang = " + K.ToString());
            }
            catch (FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("ERROR !!");
                Console.WriteLine("FORMAT YANG ANDA MASUKAN SALAH");
            }
        }
    }
    class Segitiga : Persegi
    {
        public void HitungSegitiga()
        {
            try
            {
                Console.WriteLine();
                Console.Write("Masukan Alas = ");
                s1 = double.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Masukan Tinggi = ");
                s2 = double.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Masukan Sisi Miring= ");
                s3 = double.Parse(Console.ReadLine());
                L = (s1 * s2)/2;
                K = s1 + s2 + s3;

                Console.WriteLine();
                Console.WriteLine("Luas Segitiga = " + L.ToString());
                Console.WriteLine("==================================");
                Console.WriteLine("Keliling Segitiga = " + K.ToString());
            }
            catch (FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("ERROR !!");
                Console.WriteLine("FORMAT YANG ANDA MASUKAN SALAH");
            }
        }
    }

    class Lingkaran : Persegi
    {
        public void HitungLingkaran()
        {
            try
            {
                Console.WriteLine();
                Console.Write("Masukan Jari Jari = ");
                s1 = double.Parse(Console.ReadLine());
                
                L = 3.14 * (s1 * s1);
                K = 3.14 * (s1 * 2);

                Console.WriteLine();
                Console.WriteLine("Luas Lingkaran = " + L.ToString());
                Console.WriteLine("==================================");
                Console.WriteLine("Keliling Lingkaran = " + K.ToString());
            }
            catch (FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("ERROR !!");
                Console.WriteLine("FORMAT YANG ANDA MASUKAN SALAH");
            }
        }
    }
}
