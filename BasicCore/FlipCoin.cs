using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCore
{
    public class FlipCoin
    {
        const double Check = 0.5;
        double headcount = 0, tailcount = 0;
        public void Flip()
        {
            Random random = new Random();
            Console.WriteLine("Enter How many times you Flip the Coin :- ");
            int number = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < number; i++)
            {
                double option = random.NextDouble();
                if (option < Check)
                    headcount++;
                else
                    tailcount++;
            }
            Console.WriteLine("Head Count" +(headcount/number)*100);
            Console.WriteLine("Tail Count" + (tailcount / number) * 100);
        }
    }
}
