using System;

    class PrintSequence
    {
        static void Main(string[] args)
        {
            int positiveNumbers = 2;
            int negativeNumbers = -3;
            int counter = 5;

            for (int i = 0; i < counter; i++)
            {
                Console.Write("{0}, {1}, ", positiveNumbers, negativeNumbers);
                positiveNumbers += 2;
                negativeNumbers -= 2;
            }
        }
    }
