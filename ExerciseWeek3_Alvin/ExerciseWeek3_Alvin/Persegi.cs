using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseWeek3_Alvin
{
    class Persegi
    {
        public double sisi, luas, keliling;
 
        public void getInput()
        {
            Console.WriteLine("===========// Persegi \\============= ");
            Console.WriteLine("Masukan sisi = ");
            sisi = Convert.ToDouble(Console.ReadLine());
        }
   

        public double getluas()
        {
            return luas = sisi * sisi;
        }

        public double getkeliling()
        {
            return keliling = 4 * sisi;
        }
    }
}
