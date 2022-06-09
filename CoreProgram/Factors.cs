using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreProgram
{
    internal class Factors
    {
        public void factors()
        {
            Console.WriteLine("Enter the number:");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("factors for are:");

            for (int i = 1; i <=number; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}
