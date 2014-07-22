using System;

    class ComparingFloats
    {
        static void Main(string[] args)
        {
            double var1 = 5.3;
            double var2 = 6.01;
            Console.WriteLine("The variables are {0} and {1}", var1, var2);
            Console.WriteLine((var1 > var2) ? "The first variable is bigger" : "The second variable is bigger");

            double var3 = 5.00000001;
            double var4 = 5.00000003;
            Console.WriteLine("The variables are {0} and {1}", var3, var4);
            Console.WriteLine((var3 > var4) ? "The first variable is bigger" : "The second variable is bigger");

            double var5 = 5.00000005;
            double var6 = 5.00000001;
            Console.WriteLine("The variables are {0} and {1}", var5, var6);
            Console.WriteLine((var5 > var6) ? "The first variable is bigger" : "The second variable is bigger");
            
            double var7 = -0.0000007;
            double var8 = 0.00000007;
            Console.WriteLine("The variables are {0} and {1}", var7, var8);
            Console.WriteLine((var7 > var8) ? "The first variable is bigger" : "The second variable is bigger");

            double var9 = -4.999999;
            double var10 = -4.999998;
            Console.WriteLine("The variables are {0} and {1}", var9, var10);
            Console.WriteLine((var9 > var10) ? "The first variable is bigger" : "The second variable is bigger");

            double var11 = 4.999999;
            double var12 = 4.999998;
            Console.WriteLine("The variables are {0} and {1}", var11, var12);
            Console.WriteLine((var11 > var12) ? "The first variable is bigger" : "The second variable is bigger");
        }
    }