using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreProgram
{
    internal class Harmonic
    {
        public void Harmonics()
        {
            float Result_Harmonic = (float)0;

            Console.WriteLine("Enter the value of n for Nth number:");
            int N = Convert.ToInt32(Console.ReadLine());

            while (N == 0)
            {
                Console.WriteLine("Enter The Valid Input:");
                N = Convert.ToInt32(Console.ReadLine());
            }
            for (float i = 1; i <= N; i++)
            {
                Result_Harmonic += (float) 1 / i;
            }
            Console.WriteLine("The Nth harmonic is given by {0}", Result_Harmonic);
        }
    }
}
