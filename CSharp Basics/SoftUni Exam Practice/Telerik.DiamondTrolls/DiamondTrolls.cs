using System;

    class DiamondTrolls
    {
        static void Main()
        {
            Console.Write("Baa Zil, Please enter the length of the top of your diamond: ");
            int top = int.Parse(Console.ReadLine());

            int diamondWidth = (top * 2) + 1;
            int diamondHeight = (6 + ((top - 3) / 2) * 3);
            char symbol = '*';
            char dot = '.';

            //Building the top of the diamond
            int symbolsOnLine = diamondWidth;
            int dotsOnLine = symbolsOnLine - top;
            string dots = new string(dot, dotsOnLine / 2);
            string symbols = new string(symbol, top);
            string newLine = dots + symbols + dots;
            Console.WriteLine(newLine);    
           
            //Now for the first part up until the middle
            int dotsOnCurrentLine = (symbolsOnLine - 3) / 2;
            int dotsOutsideDiamond = dotsOnCurrentLine / 2;
            int dotsInsideDiamond = dotsOutsideDiamond;
            for (int i = 0; i < (diamondHeight / 3) - 1; i++)
            {
                string dotsOutside = new string(dot, dotsOutsideDiamond);
                string dotsInside = new string(dot, dotsInsideDiamond);
                string line = dotsOutside + symbol + dotsInside + symbol + dotsInside + symbol + dotsOutside;
                dotsOutsideDiamond -= 1;
                dotsInsideDiamond += 1;
                Console.WriteLine(line);
            }

            //This is the full line of Baa Zil's diamond
            string fullLine = new string(symbol, diamondWidth);
            Console.WriteLine(fullLine);

            //And now for the rest of the diamond
            do
            {
                dotsOutsideDiamond += 1;
                dotsInsideDiamond -= 1;
                string dotsOutside = new string(dot, dotsOutsideDiamond);
                string dotsInside = new string(dot, dotsInsideDiamond);
                string line = dotsOutside + symbol + dotsInside + symbol + dotsInside + symbol + dotsOutside;
                Console.WriteLine(line);
            }
            while (dotsInsideDiamond > 0);

            //And finally for the tip of the diamond
            int dotsOnFinalLine = (symbolsOnLine / 2);
            string dotsOnLastLine = new string(dot, dotsOnFinalLine);
            Console.WriteLine(dotsOnLastLine + symbol + dotsOnLastLine);
        }
    }