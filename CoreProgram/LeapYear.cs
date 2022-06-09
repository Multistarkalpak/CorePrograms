using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreProgram
{
    internal class LeapYear
    {
        public void Leap_Year()
        {
            Console.WriteLine("Enter the Year:");
            int Year = Convert.ToInt32(Console.ReadLine());

            while (Year < 1000 || Year > 9999)
            {
                Console.WriteLine("Enter the 4 digit year:");
                Year = Convert.ToInt32(Console.ReadLine());
            }
            //if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0))
            if (Year % 4 == 0)
            {
                Console.WriteLine(Year + "Is a leap Year");
            }
            else
            {
                Console.WriteLine(Year + "Is not a leap Year");
            }
        }

    }
}
