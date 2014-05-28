using System;

class FormattingNumbers
{
    static void Main()
    {
        Console.Write("Enter number A : ");
        int a = int.Parse(Console.ReadLine());

        
        Console.Write("Enter number B : ");
        float b = float.Parse(Console.ReadLine());
        Console.Write("Enter number C : ");
        float c = float.Parse(Console.ReadLine());

        string inHex = a.ToString("x");
        string inBin = Convert.ToString(a, 2);

        Console.WriteLine("|{0,-10}|{1,10:F10}|{2,10:F2}|{3,-10:F3}"
                            , inHex, inBin.PadLeft(10, '0'), Math.Round(b, 2), Math.Round(c, 3));
        }   
    }