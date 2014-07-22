using System;

    class NumberComparer
    {
        static void Main()
        {
            Console.Write("Please insert number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Please insert the second number: ");
            int num2 = int.Parse(Console.ReadLine());


            if (num1 > num2)
            {
                Console.WriteLine("The greater number is {0}", num1);
            }
            else if (num1 < num2)
            {
                Console.WriteLine("The greater number is {0}", num2);
            }
            else
            {
                Console.WriteLine("The numbers are equal.");
            }

        }
    }
