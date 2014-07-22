using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.PlayWithVariables
{
    class PlayWithVars
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a type: ");
            Console.WriteLine("1 -- > int");
            Console.WriteLine("2 -- > double");
            Console.WriteLine("3 -- > string");
            string pick = Console.ReadLine();
            if (pick == "1")
            {
                Console.Write("Please enter an integer: ");
                int integer = int.Parse(Console.ReadLine());
                Console.WriteLine(integer + 1);
            }
            else if (pick == "2")
            {
                Console.Write("Please enter a double: ");
                double number = double.Parse(Console.ReadLine());
                Console.WriteLine(number + 1);
            }
            else if (pick == "3")
            {
                Console.WriteLine("Please insert an integer: ");
                string text = Console.ReadLine();
                Console.WriteLine(text + '*');
            }
        }
    }
}
