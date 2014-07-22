using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class IsoscelesTriangle
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            char symbol = '\x00A9';
            int triangleHeight;

            do
            {
                Console.Write("Enter triangle height = ");
                triangleHeight = int.Parse(Console.ReadLine());
            } while (triangleHeight <= 2);

            int symbolsInBase = triangleHeight;

            string spaceBeforeTip = new string(' ', triangleHeight - 1);
            string tip = spaceBeforeTip + symbol;

            Console.WriteLine(tip);

            int spacesInTriangle = 1;
            int spacesBeforeTriangle = triangleHeight - 2;
            for (int i = 0; i < triangleHeight - 2; i++)
            {
                string spacesBefore = new string(' ', spacesBeforeTriangle);
                spacesBeforeTriangle--;
                string spacesBetween = new string(' ', spacesInTriangle);
                spacesInTriangle += 2;
                string currentLine = spacesBefore + symbol + spacesBetween + symbol;
                Console.WriteLine(currentLine);
            }

            for (int i = 0; i < symbolsInBase; i++)
            {
                Console.Write(symbol + " ");
            }
            Console.WriteLine("This is your triangle!");
        }
    }