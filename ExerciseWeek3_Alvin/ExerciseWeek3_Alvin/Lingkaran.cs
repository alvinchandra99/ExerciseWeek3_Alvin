using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseWeek3_Alvin
{
    class Lingkaran
    {
        public double r, luas, keliling;
        public void getInput()
        {
            Console.WriteLine("===========// Lingkaran \\============= ");
            Console.WriteLine("Masukan jari jari lingkaran  = ");
            r = Convert.ToDouble(Console.ReadLine());
        }

        public double getLuas()
        {
            return luas = (22 * r * r) / 7;
        }
        public double getKeliling()
        {
            return keliling = 2 * 22 * r / 7;
        }
    }
}
