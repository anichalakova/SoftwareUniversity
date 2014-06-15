using System;

    class PrimeNumberCheck
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert the number that you want to check");
            int num = int.Parse(Console.ReadLine());
            bool isPrime = true;

            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                }
            }

            Console.WriteLine("Is your number prime? {0}", isPrime);
        }
    }