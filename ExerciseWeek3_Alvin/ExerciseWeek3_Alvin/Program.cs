using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseWeek3_Alvin
{
    class Program
    {
        public int pilih;
        static void Main(string[] args)
        {
           
                Console.WriteLine("MENGHITUNG LUAS BANGUN DATAR");
                Console.WriteLine("------------------------------");
                Console.WriteLine("1. Persegi");
                Console.WriteLine("2. Persegi Panjang");
                Console.WriteLine("3. Segitiga");
                Console.WriteLine("4. Lingkaran");
                Console.WriteLine("5. Belah Ketupat");
                Console.WriteLine("------------------------------");
                Console.WriteLine("Masukan pilihan dalam bentuk angka = ");
                int pilih = Convert.ToInt32(Console.ReadLine());
           

       
            switch (pilih)
            {
                case 1:
                    try
                    {
                        Persegi persegi = new Persegi();

                        persegi.getInput();
                        Console.WriteLine("Nilai Luas Persegi : " + persegi.getluas());
                        Console.WriteLine("Nilai Keliling Persegi : " + persegi.getkeliling());
                    }
                    catch (Exception error)
                    {
                        Console.WriteLine(error);
                    }


                    break;
                case 2:
                    // code block

                    try
                    {

                        PersegiPanjang persegiPanjang = new PersegiPanjang();

                        persegiPanjang.getInput();
                        Console.WriteLine("Nilai Luas Persegi Panjang : " + persegiPanjang.getluas());
                        Console.WriteLine("Nilai Keliling Persegi : " + persegiPanjang.getkeliling());

                    }

                    catch (Exception error)
                    {
                        Console.WriteLine(error);
                    }
                    break;
                case 3:
                    try
                    {

                        Segitiga segitiga = new Segitiga();


                        segitiga.getInput();
                        Console.WriteLine("Nilai Luas Segitiga : " + segitiga.getLuas());
                        Console.WriteLine("Nilai Keliling Segitiga : " + segitiga.getKeliling());

                    }
                    catch (Exception error)
                    {
                        Console.WriteLine(error);
                    }
                    break;
                case 4:
                    try
                    {


                        Lingkaran lingkaran = new Lingkaran();
                        lingkaran.getInput();
                        Console.WriteLine("Nilai Luas lingkaran : " + lingkaran.getLuas());
                        Console.WriteLine("Nilai Keliling lingkaran : " + lingkaran.getKeliling());
                    }
                    catch (Exception error)
                    {
                        Console.WriteLine(error);
                    }

                    break;
            }

               


        }
    }
}
