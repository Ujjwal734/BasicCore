using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCore
{
    public class OddEveen
    {
        public void OddEven()
        {
            Console.WriteLine("Enter a number to check Number is Odd Or Even");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
                Console.WriteLine("Number is Even :- " + num);
            else
                Console.WriteLine("Number is Odd :- " + num);
        }
    }
}
