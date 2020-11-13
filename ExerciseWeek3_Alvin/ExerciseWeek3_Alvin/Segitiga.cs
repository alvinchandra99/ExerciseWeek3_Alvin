using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseWeek3_Alvin
{
    class Segitiga
    {
        public double alas, tinggi, luas, keliling, sisi;
        public void getInput()
        {
            Console.WriteLine("===========// Segitiga Sama Kaki\\============= ");
            Console.WriteLine("Masukan Alas = ");
            alas = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Masukan Tinggi = ");
            tinggi = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Masukan sisi = ");
            sisi = Convert.ToDouble(Console.ReadLine());

        }
        public double getLuas()
        {
            return luas = alas * tinggi / 2;
        }
        public double getKeliling()
        {
            return keliling = alas + 2 * sisi;
        }


    }
}
