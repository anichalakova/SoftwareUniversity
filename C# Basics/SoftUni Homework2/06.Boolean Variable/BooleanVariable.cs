using System;

    class BooleanVariable
    {
        static void Main()
        {
            Console.WriteLine("Are you a female?");
            string gender = Console.ReadLine();

            if (gender == "yes")
            {
                Console.WriteLine("You are a female");
            }
            else
            {
                Console.WriteLine("You are not a female");
            }
        }
    }