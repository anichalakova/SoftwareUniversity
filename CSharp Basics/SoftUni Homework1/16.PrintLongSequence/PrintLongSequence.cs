using System;
    class PrintLongSequence
    {
        static void Main()
        {
            Console.BufferHeight = 1001;
            for (int i = 1; i <= 1000; i++)
            {
                Console.WriteLine(i);
            }
        }
    }