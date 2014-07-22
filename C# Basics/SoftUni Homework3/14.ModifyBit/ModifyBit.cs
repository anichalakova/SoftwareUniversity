using System;

class ModifyABitAtGivenPosition
{
    static void Main()
    {
        Console.Write("Enter number : ");
        int number = Int32.Parse(Console.ReadLine());
        Console.Write("Enter position : ");
        byte position = Byte.Parse(Console.ReadLine());
        Console.Write("Enter value : ");
        byte value = Byte.Parse(Console.ReadLine());
        string binaryNumberString = Convert.ToString(number, 2).PadLeft(16, '0');
        Console.WriteLine("Binary representation number#{0}: {1}", number, binaryNumberString);
        if (value == 0)
        {
            int mask = ~(1 << position);
            int result = number & mask;
            string binaryNumber = Convert.ToString(result, 2).PadLeft(16, '0');
            Console.WriteLine("Result : {0}", result);
            Console.WriteLine("Binary result : {0}", binaryNumber);
        }
        else
        {
            int mask = 1 << position;
            int result = number | mask;
            string binaryNumber = Convert.ToString(result, 2).PadLeft(16, '0');
            Console.WriteLine("Result : {0}", result);
            Console.WriteLine("Binary result : {0}", binaryNumber);
        }
    }
}