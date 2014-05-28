using System;

    class Three_Six_Nine
    {
        static void Main()
        {
            Console.WriteLine("Please insert a three-digit number");
            int num = int.Parse(Console.ReadLine());

            int c = num % 10;
            num /= 10;
            int b = num % 10;
            num /= 10;
            int a = num;

            if (b == 3)
            {
                int sum = a + c;
                Console.WriteLine("The sum of {0} and {1} is {2}", a, c, sum);
                if (sum % 3 == 0)
                {
                    Console.WriteLine("{0} divided by three is: {1}", sum, sum / 3);
                }
                else
                {
                    Console.WriteLine("The remainder of the division of {0} and three is: {1}", sum, sum % 3);
                }
            }
            else if (b == 6)
            {
                int sum = a * c;
                Console.WriteLine("The sum of {0} and {1} is {2}", a, c, sum);
                if (sum % 3 == 0)
                {
                    Console.WriteLine("{0} divided by three is: {1}", sum, sum / 3);
                }
                else
                {
                    Console.WriteLine("The remainder of the division of {0} and three is: {1}", sum, sum % 3);
                }
            }
            else if (b == 9)
            {
                int sum = a % c;
                Console.WriteLine("The sum of {0} and {1} is {2}", a, c, sum);
                if (sum % 3 == 0)
                {
                    Console.WriteLine("{0} divided by three is: {1}", sum, sum / 3);
                }
                else
                {
                    Console.WriteLine("The remainder of the division of {0} and three is: {1}", sum, sum % 3);
                }
            }
            else
            {
                Console.WriteLine("You haven't entered a valid code!!! Act like a spy pls.");
            }
        }
    }
