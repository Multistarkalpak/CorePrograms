using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreProgram
{
    internal class Power2
    {
        public void Power_of_two()
        {
            Console.WriteLine("Enter the Number:");
            int number = Convert.ToInt32(Console.ReadLine());

            while (number < 0 || number > 31)
            {
                Console.WriteLine("Please Enter The vaild number:");
            }

            for (int i = 0; i <= number; i++)
            {
                Console.WriteLine(Math.Pow(2, i));
            }
        }
    }
}
