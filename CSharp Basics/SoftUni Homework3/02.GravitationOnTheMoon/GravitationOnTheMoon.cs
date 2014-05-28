using System;

    class GravitationOnTheMoon
    {
        static void Main(string[] args)
        {
            Console.Write("How much do you weigh? ");
            int weight = int.Parse(Console.ReadLine());
            double weightOnMoon = 0.17 * weight;

            Console.WriteLine("Your weight on the moon is {0}", weightOnMoon);
        }
    }