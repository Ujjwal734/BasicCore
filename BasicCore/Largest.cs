using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace BasicCore
{
    public class Largest
    {
        public void Large()
        {
            Console.WriteLine("Enter Three number to Check which is Largest :- ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2 && num1 > num3)
                Console.WriteLine("First Number is the largest number :- " + num1);
            else if(num2>num1 && num2>num3)
                Console.WriteLine("Second Number is the largest number :- "+ num2);
            else
                Console.WriteLine("Third Number is largest number :- "+ num3);
        }
    }
}
