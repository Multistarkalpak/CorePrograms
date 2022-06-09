using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreProgram
{
    internal class FlipCoin
    {
        public void Flip_coin()
        {
            Console.WriteLine("Enter the Number_of_Flip:");
            int Number_of_Flip = Convert.ToInt32(Console.ReadLine());

            int heads = 0;
            int tails = 0;

            while (Number_of_Flip <= 0)
            {
                Console.WriteLine("Invalid Input, Please enter the number greater than 0,");
                Console.WriteLine("Please enter again:  ");
                Number_of_Flip = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < Number_of_Flip; i++)
            {
                Random Flip = new Random();
                int hot = Flip.Next(0, 2);
                if (hot < 0.5)
                {
                    tails++;

                }
                else
                {
                    heads++;
                }
            }
                float Heads_present = (float)heads * 100 / Number_of_Flip;
                float Tails_present = (float)tails * 100 / Number_of_Flip;
                Console.WriteLine("Heads_present: " + Heads_present);
                Console.WriteLine("Tails_present" + Tails_present);
            
        }
    }
}
