using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCore
{
    public class Division
    {
        public void QutRem()
        {
            Console.WriteLine("Enter Number 1 and Number 2");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = num1 / num2;
            Console.WriteLine("Quotient = "+ num3);
            int num4 = num1 % num2;
            Console.WriteLine("Remainde = "+ num4);
          
        }
    }
}
