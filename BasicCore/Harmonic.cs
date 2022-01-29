using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCore
{
    public class Harmonic
    {
        public void HarmonicNum()
        {
            Console.WriteLine("Enter number upto where you want a harmonic series :- ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your number :- " + num);
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine("1/{0} + ", i);
            }
        }
    }
}
