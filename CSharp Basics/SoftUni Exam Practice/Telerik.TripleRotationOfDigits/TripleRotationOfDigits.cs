using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telerik.TripleRotationOfDigits
{
    class TripleRotationOfDigits
    {
        static void Main(string[] args)
        {
            string k = Console.ReadLine();
            string number = string.Empty;

            for (int i = 0; i < 3; i++)
            {
            char addNumber = k.Last();
            number = addNumber + k.Remove(k.Length - 1);
            number = number.TrimStart(new char[] { '0' });
            k = number;
            }
            Console.WriteLine(number);

            
        }
	}
}
