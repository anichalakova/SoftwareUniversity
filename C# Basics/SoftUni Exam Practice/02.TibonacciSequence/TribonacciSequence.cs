using System;

    class TribonacciSequence
    {
        static void Main()
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            ushort nth = ushort.Parse(Console.ReadLine());
            int sum = 0;
            if (nth == 1)
            {
                Console.WriteLine(n1);
            }
            else if (nth == 2)
            {
                Console.WriteLine(n2);
            }
            else if (nth == 3)
            {
                Console.WriteLine(n3);
            }
            else
            {
                for (int i = 4; i <= nth; i++)
                {
                    sum = n1 + n2 + n3;
                    n1 = n2;
                    n2 = n3;
                    n3 = sum;
                }
            }
            Console.WriteLine(sum);
        }
    }
