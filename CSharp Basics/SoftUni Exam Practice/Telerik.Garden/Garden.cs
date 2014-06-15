using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telerik.Garden
{
    class Garden
    {
        static void Main(string[] args)
        {
            double tomatoSeeds = double.Parse(Console.ReadLine());
            double tomatoArea = double.Parse(Console.ReadLine());
            double cucumberSeeds = double.Parse(Console.ReadLine());
            double cucumberArea = double.Parse(Console.ReadLine());
            double potatoSeeds = double.Parse(Console.ReadLine());
            double potatoArea = double.Parse(Console.ReadLine());
            double carrotSeeds = double.Parse(Console.ReadLine());
            double carrotArea = double.Parse(Console.ReadLine());
            double cabbageSeeds = double.Parse(Console.ReadLine());
            double cabbageArea = double.Parse(Console.ReadLine());
            double beansSeeds = double.Parse(Console.ReadLine());

            double tomatoPrice = 0.5 * tomatoSeeds;
            double cucumberPrice = 0.4 * cucumberSeeds;
            double potatoPrice = 0.25 * potatoSeeds;
            double carrotPrice = 0.6 * carrotSeeds;
            double cabbagePrice = 0.3 * cabbageSeeds;
            double beansPrice = 0.4 * beansSeeds;
            double totalPrice = tomatoPrice + cucumberPrice + potatoPrice + carrotPrice + cabbagePrice + beansPrice;

            double occupiedArea = tomatoArea + cucumberArea + potatoArea + carrotArea + cabbageArea;
            double beansArea = 250 - occupiedArea;

            Console.WriteLine("Total costs: {0:F2}", totalPrice);

            if (beansArea > 0)
            {
                Console.WriteLine("Beans area: {0}", beansArea);
                
            }
            else if (beansArea == 0)
            {
                Console.WriteLine("No area for beans");
            }
            else if (beansArea < 0)
            {
                Console.WriteLine("Insufficient area");
            }
        }
    }
}
