using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCore
{
    public class Swap
    {
        public void Swaping()
        {
            Console.WriteLine("Enter a number1 and number2 for Swaping :- ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before Swap Number1 = "+ num1+ "\nNumber2 = "+ num2);
            num1 = num1 * num2;
            num2 = num1 / num2;
            num1 = num1 / num2;
            Console.WriteLine("After Swap Number1 = " + num1 + "\nNumber2 = " + num2);
        }
    }
}
