using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseWeek3_Alvin
{


    class PersegiPanjang
    {
        public double panjang, lebar, luas, keliling;
        public void getInput()
        {
            Console.WriteLine("===========// Persegi Panjang \\============= ");
            Console.WriteLine("Masukan panjang = ");
            panjang = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Masukan lebar = ");
            lebar = Convert.ToDouble(Console.ReadLine());
        }

        public double getluas()
        {
            return luas = panjang * lebar;
        }

        public double getkeliling()
        {
            return keliling =2 * panjang + 2*lebar;
        }





    }
}
