using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Illuminati
{
    class Illuminati
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            input = input.ToUpper();

            int numberOfVowels = 0;
            int sumOfLetters = 0;

            foreach (char letter in input)
            {
                if (letter == 'A' || letter == 'U' ||
                    letter == 'O' || letter == 'E' || letter == 'I')
                {
                    sumOfLetters += letter;
                    numberOfVowels++;
                }
            }
            Console.WriteLine(numberOfVowels);
            Console.WriteLine(sumOfLetters);
        }
    }
}