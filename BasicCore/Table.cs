using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCore
{
    public class Table
    {
        public void Power()
        {
            Console.WriteLine("Enter a power upto where you want a table :- ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= number; i++)
            {
                Console.WriteLine(2 + "^"+i +"=" +Math.Pow(2,i));
            }
        }
    }
}
