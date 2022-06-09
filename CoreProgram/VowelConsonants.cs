using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreProgram
{
    internal class VowelConsonants
    {
        public void checkVowel()
        {
            Console.WriteLine("Enter character :");
            char ch = Console.ReadLine()[0];

            if( ch=='a' || ch=='e' || ch == 'i' || ch == 'o' || ch == 'u' ||
                ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            { Console.WriteLine("Char {0} is a Vowel",ch); }
            else
            { Console.WriteLine("Char {0} is a Consonant", ch); }
        }
    }
}
