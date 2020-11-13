using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuasdanKeliling
{
    class Base
    {
        static void Main(string[] args)
        {
            string bd;

            Persegi persegi = new Persegi();
            PersegiPanjang persegipanjang = new PersegiPanjang();
            Jajargenjang jajargenjang = new Jajargenjang();
            Segitiga segitiga = new Segitiga();
            Lingkaran lingkaran = new Lingkaran();

            do
            {

                {
                    Console.Clear();
                    Console.WriteLine("Pilih bangun datar yang akan dihitung : ");
                    Console.WriteLine(" 1. Persegi ");
                    Console.WriteLine(" 2. Persegi panjang ");
                    Console.WriteLine(" 3. Jajar Genjang ");
                    Console.WriteLine(" 4. Segitiga ");
                    Console.WriteLine(" 5. Lingkaran ");
                    Console.WriteLine();
                    Console.Write(" Masukan Pilihan = ");
                    bd = Console.ReadLine();

                    if (bd == "1")
                    {
                        persegi.HitungPersegi();

                    }

                    else if (bd == "2")
                    {
                        persegipanjang.HitungPersegiPanjang();
                    }

                    else if (bd == "3")
                    {
                        jajargenjang.HitungJajarGenjang();
                    }

                    else if (bd == "4")
                    {
                        segitiga.HitungSegitiga();
                    }

                    else
                    {
                        lingkaran.HitungLingkaran();
                    }

                }
                Console.WriteLine("___________________________________");
                Console.WriteLine("Kembali Ke Menu Utama ?? (y/n)");
                bd = Console.ReadLine();
            }
            while (bd == "y" || bd == "Y");

            Console.ReadKey();
        }
    }
}
