// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
namespace CoreProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            int choice=1;

            while(choice!=0)
            {
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Flip Coin");
                Console.WriteLine("2. Leap Year");
                Console.WriteLine("3. Power of 2");
                Console.WriteLine("4. Harmonic Functions");
                Console.WriteLine("5. Factors");
                Console.WriteLine("6. Quotient and Remainder");
                Console.WriteLine("7. Swap two numbers");
                Console.WriteLine("8. Even Odd");
                Console.WriteLine("9. Vowels and Consonants");
                Console.WriteLine("10. Largest in 3 numbers");
                Console.WriteLine("Enter Choice : ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 0: return;

                    case 1:
                        FlipCoin flip = new FlipCoin();
                        flip.Flip_coin();
                        break;
                    case 2:
                        LeapYear leap = new LeapYear();
                        leap.Leap_Year();
                        break;
                    case 3:
                        Power2 power = new Power2();
                        power.Power_of_two();
                        break;
                    case 4:
                        Harmonic harmonic = new Harmonic();
                        harmonic.Harmonics();
                        break;
                    case 5:
                        Factors fac = new Factors();
                        fac.factors();
                        break;
                    case 6:
                        QuotientRemainder qr = new QuotientRemainder();
                        qr.Quotient_Remainder();
                        break;
                    case 7:
                        Swap swp = new Swap();
                        swp.swap();
                        break;
                    case 8:
                        EvenOdd EO = new EvenOdd();
                        EO.evenodd();
                        break;
                    case 9:
                        VowelConsonants chr = new VowelConsonants();
                        chr.checkVowel();
                        break;
                    case 10:
                        LargestIn3 max = new LargestIn3();
                        max.largest();
                        break;
                    default:
                        Console.WriteLine("Invalid input. Input 0-10");
                        break;
                }

            }

        }
    }
}
